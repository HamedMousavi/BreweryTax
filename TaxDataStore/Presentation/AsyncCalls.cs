using System;

namespace TaxDataStore.Presentation
{
    // Warning: USE A SEPARATE INSTANCE FOR EACH CRITICAL SECTION
    public class AsyncCalls
    {

        protected object lockObject;


        public AsyncCalls()
        {
            this.lockObject = new object();
        }


        public bool Execute(System.Windows.Forms.Control context, Delegate function, params object[] parameters)
        {
            lock (this.lockObject)
            {
                if (context.InvokeRequired)
                {
                    int maxLoop = 100;

                    while (!context.IsHandleCreated)
                    {
                        System.Threading.Thread.Sleep(10);

                        if (--maxLoop <= 0)
                        {
                            // Failed to create control. Release thread.
                            return false;
                        }
                    }

                    if (parameters == null)
                    {
                        context.BeginInvoke(function);
                    }
                    else
                    {
                        context.BeginInvoke(function, parameters);
                    }

                    // Return false here since further calls shall not be executed.
                    // A new async call had been invoked
                    return false;
                }
            }

            return true;
        }
    }
}
