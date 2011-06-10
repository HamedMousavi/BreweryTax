﻿using System;
using System.ServiceModel;
using System.ServiceModel.Activation;


namespace TaxDataStoreUpdater
{

    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Multiple)
    ]
    [AspNetCompatibilityRequirements(RequirementsMode =
        AspNetCompatibilityRequirementsMode.Allowed)]
    public class UpdaterIpcService : IUpdaterIpcService
    {

        private Updater updater;


        public UpdaterIpcService()
        {
            this.updater = IpcServiceDependencies.Instance.Updater;
        }


        public bool CheckForUpdates()
        {
            try
            {
                this.updater.CheckNow();
                return true;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
            return false;
        }

        public bool DownloadUpdates()
        {
            try
            {
                this.updater.DownloadUpdate();
                return true;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
            return false;
        }

        public bool ApplyUpdates()
        {
            try
            {
                this.updater.ApplyUpdate();
                return true;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
            return false;
        }

        public bool UpdateExists()
        {
            try
            {
                return this.updater.IsNewVersionAvailable;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
            return false;
        }

        public bool IsDownloadComplete()
        {
            try
            {
                return this.updater.IsDownloadComplete;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
            return false;
        }

        public int GetStatus()
        {
            try
            {
                return (Int32)this.updater.Status;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            } 
            
            return 0;
        }

        public bool ReloadSettings()
        {
            try
            {
                return ServiceIo.LoadSettings();
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
            return false;
        }
    }
}
