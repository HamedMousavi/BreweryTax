using System.ComponentModel;
using System.Configuration.Install;


namespace TaxDataStoreUpdater
{

    [RunInstaller(true)] 
    public class TaxDataStoreMainInstaller : Installer
    {
        public TaxDataStoreMainInstaller()
        {
            Installer[] installers = new Installer[] 
            {
                new TaxDataStoreProcessInstaller(),
                new TaxDataStoreServiceInstaller()
            };

            this.Installers.AddRange(installers);
        }
    }
}
