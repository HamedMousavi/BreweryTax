using System.ComponentModel;
using System.ServiceProcess;


namespace TaxDataStoreUpdater
{
    public class TaxDataStoreProcessInstaller : ServiceProcessInstaller
    {
        public TaxDataStoreProcessInstaller()
        {
            this.Username = null;
            this.Password = null;
            this.Account = ServiceAccount.LocalService;
        }
    }
}
