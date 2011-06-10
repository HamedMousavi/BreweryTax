using System.ServiceModel;


namespace TaxDataStoreUpdater
{

    [ServiceContract(Namespace = "TaxDataStoreUpdater")]
    public interface IUpdaterIpcService
    {

        [OperationContract]
        bool CheckForUpdates();

        [OperationContract]
        bool DownloadUpdates();

        [OperationContract]
        bool ApplyUpdates();

        [OperationContract]
        bool UpdateExists();

        [OperationContract]
        bool IsDownloadComplete();

        [OperationContract]
        int GetStatus();

        [OperationContract]
        bool ReloadSettings();
    }
}
