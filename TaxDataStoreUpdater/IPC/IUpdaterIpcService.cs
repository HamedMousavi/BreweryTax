using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;


namespace TaxDataStoreUpdater
{

    [ServiceContract(Namespace = "TaxDataStoreUpdater")]
    public interface IUpdaterIpcService
    {
        void CheckForUpdates();
        void DownloadUpdates();
        void ApplyUpdates();
        bool UpdateExists();
        bool IsDownloadComplete();
        int GetStatus();
    }
}
