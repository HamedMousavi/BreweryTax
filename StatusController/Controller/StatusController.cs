using System;
using System.Collections.Generic;
using System.Threading;
using StatusController.Abstract;
using StatusController.Entities;



namespace StatusController.Controller
{
    public class StatusController : IStatusController, IDisposable
    {

        protected readonly Int16 MessageCapacity = 1000;
        

        protected List<IStatusObserver> observers;
        protected SafeQueue messageQueue; 
        

        public StatusController()
        {
            this.messageQueue = new SafeQueue(MessageCapacity);
            this.observers = new List<IStatusObserver>();
            
            ThreadPool.QueueUserWorkItem(new WaitCallback(EventNotifier), this);
        }


        private void Close()
        {
            this.messageQueue.Dispose();
        }


        void EventNotifier(object owner)
        {
            while (true)
            {
                try
                {
                    IStatus message = this.messageQueue.Dequeue(true) as IStatus;
                    if (message != null)
                    {
                        foreach (IStatusObserver observer in this.observers)
                        {
                            observer.OnStatusChanged(message);
                        }
                    }
                    else
                    {
                        // Shall exit thread.
                        break;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
        }


        #region IStatusController Members


        public void UpdateStatus(IStatus status)
        {
            lock (this)
            {
                this.messageQueue.Enqueue(status);
            }
         }


        public void RegisterForEvents(IStatusObserver observer)
        {
            lock (this.observers)
            {
                if (!this.observers.Contains(observer))
                {
                    this.observers.Add(observer);
                }
            }
        }


        public void UnregisterFromEvents(IStatusObserver observer)
        {
            lock (this.observers)
            {
                this.observers.Remove(observer);
            }
        }


        #endregion


        #region IDisposable Members

        public void Dispose()
        {
            Close();
        }

        #endregion

    }
}
