using System.ComponentModel;
using System.ServiceProcess;


namespace TaxDataStoreUpdater
{
    public class TaxDataStoreServiceInstaller : ServiceInstaller
    {
        public TaxDataStoreServiceInstaller()
        {
            this.DisplayName = Settings.Instance.ServiceName;
            this.ServiceName = Settings.Instance.ServiceName;
            this.Description = Settings.Instance.ServiceDescription;

            this.StartType = ServiceStartMode.Automatic;
        }
    }
}
