using System;
using System.ServiceModel;


namespace ApplicationUpdater
{

    [ServiceContract(Namespace = "ApplicationUpdater")]
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

        [OperationContract]
        DateTime? GetLastCheckTimestamp();

        [OperationContract]
        string GetNewVersionDetails();

        [OperationContract]
        void ShutDown();
    }
}
