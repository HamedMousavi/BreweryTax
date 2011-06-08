using System;
using System.ServiceModel;


namespace TaxDataStoreUpdater
{

    public class UpdaterIpcServiceController
    {

        private ServiceHost ipcHost;


        public UpdaterIpcServiceController()
        {
        }

        
        public void Stop()
        {
            try
            {
                if (this.ipcHost != null)
                {
                    this.ipcHost.Close();
                    this.ipcHost = null;
                    EventLogger.Instance.Add("Ipc Stopped.");
                }
            }
            catch (Exception e)
            {
                EventLogger.Instance.Add("Error stopping IPC: " + e.Message);
            }
        }

        
        public void Start()
        {
            try
            {
                Stop();

                this.ipcHost = new ServiceHost(typeof(UpdaterIpcService));
                this.ipcHost.Open();
                EventLogger.Instance.Add("Ipc Started.");
            }
            catch (Exception e)
            {
                EventLogger.Instance.Add("Error starting IPC: " + e.Message);
            }
        }
    }
}
