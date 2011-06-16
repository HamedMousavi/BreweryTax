

namespace ApplicationUpdater
{

    public class StateHandler
    {

        protected object lockObj;
        protected object state;


        public StateHandler(object initialState)
        {
            this.lockObj = new object();
            this.state = initialState;
        }


        public object Current
        {
            get
            {
                return this.state;
            }

            set
            {
                lock (this.lockObj)
                {
                    if (this.state != value)
                    {
                        this.state = value;
                        // UNDONE: RaiseStateChanged event
                    }
                }
            }
        }
    }
}
