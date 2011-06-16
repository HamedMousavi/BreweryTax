
namespace ApplicationUpdater
{

    public class IpcServiceDependencies
    {

        #region singleton

        protected static IpcServiceDependencies instance;
        protected static object instLock = new object();
        public static IpcServiceDependencies Instance
        {
            get
            {
                lock (instLock)
                {
                    if (instance == null)
                    {
                        instance = new IpcServiceDependencies();
                    }
                }

                return instance;
            }
        }

        #endregion


        public Updater Updater { get; set; }
    }
}
