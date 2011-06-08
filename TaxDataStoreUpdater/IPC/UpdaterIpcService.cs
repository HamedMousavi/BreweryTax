using System;
using System.ServiceModel;
using System.ServiceModel.Activation;


namespace TaxDataStoreUpdater
{

    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Multiple)
    ]
    [AspNetCompatibilityRequirements(RequirementsMode =
        AspNetCompatibilityRequirementsMode.NotAllowed)]
    public class UpdaterIpcService : IUpdaterIpcService
    {

        private Updater updater;


        public UpdaterIpcService()
        {
        }


        public UpdaterIpcService(Updater updater) :
            this()
        {
            this.updater = updater;
        }
        

        public void CheckForUpdates()
        {
            this.updater.CheckNow();
        }

        public void DownloadUpdates()
        {
            this.updater.DownloadUpdate();
        }

        public void ApplyUpdates()
        {
            this.updater.ApplyUpdate();
        }

        public bool UpdateExists()
        {
            return this.updater.IsNewVersionAvailable;
        }

        public bool IsDownloadComplete()
        {
            return this.updater.IsDownloadComplete;
        }
        
        public int GetStatus()
        {
            return (Int32)this.updater.Status;
        }
    }
}
