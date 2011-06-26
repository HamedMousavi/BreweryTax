using System;


namespace TaxDataStore.Presentation.Models
{
    public class AppUpdateInfo : Entities.EntityBase
    {
        public AppUpdateInfo()
        {
            updateExists = false;
            downloadIsComplete = false;
        }


        protected DateTime? lastCheckTime;
        protected bool updateExists;
        protected bool downloadIsComplete;
        protected string details;


        public DateTime? LastCheckTime
        {
            get
            {
                return this.lastCheckTime;
            }

            set
            {
                if (this.lastCheckTime != value)
                {
                    this.lastCheckTime = value;
                    RaisePropertyChanged("LastCheckTime");
                }
            }
        }

        public bool UpdateExists
        {
            get
            {
                return this.updateExists;
            }

            set
            {
                if (this.updateExists != value)
                {
                    this.updateExists = value;
                    RaisePropertyChanged("UpdateExists");
                }
            }
        }

        public bool DownloadIsComplete
        {
            get
            {
                return this.downloadIsComplete;
            }

            set
            {
                if (this.downloadIsComplete != value)
                {
                    this.downloadIsComplete = value;
                    RaisePropertyChanged("DownloadIsComplete");
                }
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (this.details != value)
                {
                    this.details = value;
                    RaisePropertyChanged("Details");
                }
            }
        }
    }
}
