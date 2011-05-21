using System;
using System.Collections;
using System.Threading;
using StatusController.Abstract;



namespace StatusController.Controller
{
    public class SafeQueue : IDisposable
    {

        protected readonly int INITIAL_CAPACITY = UInt16.MaxValue;
        
        protected const int ShutdownHandle = 0;
        protected const int SemaphoreHandle = 1;


        protected Queue queue;
        protected Semaphore semaphore;
        protected WaitHandle[] handles;


        public SafeQueue(int maximumCount)
        {
            this.queue = new Queue(INITIAL_CAPACITY);
            this.semaphore = new Semaphore(0, maximumCount);
            this.handles = new WaitHandle[2];

            this.handles[ShutdownHandle] = new AutoResetEvent(false);
            this.handles[SemaphoreHandle] = this.semaphore;
        }


        public bool IsEmpty 
        {
            get
            {
                if (this.queue == null) return true;

                return (this.queue.Count == 0);
            }
        }


        public bool Enqueue(object obj)
        {
            bool ret = false;

            Monitor.Enter(this);
            try
            {
                this.semaphore.Release();
                this.queue.Enqueue(obj);
                ret = true;
            }
            catch (SemaphoreFullException)
            {
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Monitor.Exit(this);
            }

            return ret;
        }


        public object Dequeue(bool block)
        {
            object ret = null;

            try
            {
                int res = WaitHandle.WaitAny(
                    this.handles, 
                    block ? Timeout.Infinite : 0, 
                    false);

                switch (res)
                {
                    case ShutdownHandle:
                        break;

                    case SemaphoreHandle:
                        ret = Dequeue();
                        break;

                    default:
                        // Probably timeout
                        break;
                }
            }
            catch (Exception ex)
            {
            }

            return ret;
        }

        
        private object Dequeue()
        {
            object ret = null;

            Monitor.Enter(this);
            try
            {
                if (this.queue.Count > 0)
                {
                    ret = this.queue.Dequeue();
                }
            }
            catch (InvalidOperationException)
            {
                //Errors.ErrorManager.Instance.SetException(ex);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Monitor.Exit(this);
            }

            return ret;
        }


        public void Close()
        {
            ((AutoResetEvent)this.handles[ShutdownHandle]).Set();
        }


        #region IDisposable Members

        public void Dispose()
        {
            Close();
            this.queue.Clear();
            this.handles[0].Close();
            this.semaphore.Close();
        }

        #endregion


        public int Count { get { return this.queue.Count; } }
    }
}
