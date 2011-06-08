using System;
using System.ComponentModel;


namespace TaxDataStoreUpdater
{

    [Serializable]
    public class Settings
    {

        #region singleton

        [NonSerialized]
        protected static Settings instance;
        [NonSerialized]
        protected static object instLock = new object();

        public static Settings Instance
        {
            get
            {
                lock (instLock)
                {
                    if (instance == null)
                    {
                        instance = new Settings();
                    }
                }

                return instance;
            }
        }

        #endregion


        protected string directoryName;
        protected string updateUri;
        protected string appName;
        protected bool newVersionAutoCheck;
        protected int newVersionAutoCheckInterval;
        protected bool newVersionAutoDownload;


        public Settings()
        {
            // Set default directory of updater files
            this.directoryName = 
                System.IO.Path.DirectorySeparatorChar + 
                "Updater";
        }


        public string ServiceName
        {
            get
            {
                return "SettlementUpdater";
            }
        }


        public string ServiceFileName
        {
            get
            {
                return "TaxDataStoreUpdater.exe";
            }
        }


        public string ServiceDescription
        {
            get
            {
                return "Looks for new versions of Settlement application, downloads, notifies and updates application as needed.";
            }
        }


        public string SettingsFileName
        {
            get
            {
                return "UpdaterSettings.xml";
            }
        }


        public string DownloadDirectoryName
        {
            get { return System.IO.Path.DirectorySeparatorChar + "Downloads"; }
        }


        public string DirectoryName
        {
            get { return this.directoryName; }
            set { this.directoryName = value; }
        }


        [DefaultValue("www.mywebsite.com/update_dir/manifest.xml")]
        public string UpdateUri
        {
            get { return this.updateUri; }
            set { this.updateUri = value; }
        }


        [DefaultValue(true)]
        public bool AutoCheckForUpdates
        {
            get
            {
                return newVersionAutoCheck;
            }
            
            set
            {
                this.newVersionAutoCheck = value;
            }
        }


        // Seconds
        [DefaultValue(60)]
        public int AutoUpdateCheckInterval
        {
            get
            {
                return newVersionAutoCheckInterval;
            }
            
            set
            {
                this.newVersionAutoCheckInterval = value;
            }
        }


        [DefaultValue(false)]
        public bool AutoDownloadUpdate
        {
            get
            {
                return newVersionAutoDownload;
            }
            
            set
            {
                this.newVersionAutoDownload = value;
            }
        }


        [DefaultValue("settlement.exe")]
        public string UpdateApplicationName
        {
            get
            {
                return this.appName;
            }
            
            set
            {
                this.appName = value;
            }
        }


        internal void CopyTo(Settings settings)
        {
            settings.UpdateUri = this.updateUri;
            settings.DirectoryName = this.directoryName;
            settings.AutoCheckForUpdates = this.newVersionAutoCheck;
            settings.AutoUpdateCheckInterval = this.newVersionAutoCheckInterval;
            settings.AutoDownloadUpdate = this.newVersionAutoDownload;
            settings.UpdateApplicationName = this.appName;
        }
    }
}
