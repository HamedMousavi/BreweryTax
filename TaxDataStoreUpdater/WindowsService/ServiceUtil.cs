using System;


namespace TaxDataStoreUpdater
{

    public class ServiceUtil
    {

        public static string StartupPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }
}
