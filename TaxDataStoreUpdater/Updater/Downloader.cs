using System;
using System.ComponentModel;
using System.Net;


namespace TaxDataStoreUpdater
{

    public class Downloader
    {

        public enum Downloadables
        {
            UpdateManifest = 0,
            UpdatePackage = 1
        }


        protected WebClient webClient;
        protected Uri updateManifestUri;
        protected bool isDownloading;


        public event DownloadProgressChangedEventHandler DownloadProgressChanged
        {
            add
            {
                this.webClient.DownloadProgressChanged += value;
            }

            remove
            {
                this.webClient.DownloadProgressChanged -= value;
            }
        }


        public Downloader()
        {
            this.isDownloading = false;

            this.updateManifestUri = new Uri(Settings.Instance.UpdateUri);

            this.webClient = new WebClient();
            this.webClient.DownloadFileCompleted += new 
                AsyncCompletedEventHandler(OnDownloadFileCompleted);
        }


        void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DownloadInfo inf = (DownloadInfo)e.UserState;
            inf.Cancelled = e.Cancelled;
            inf.Error = e.Error;

            RaiseDownloadCompleted(inf);

            this.isDownloading = false;
        }


        internal bool BeginDownloadManifest()
        {
            if (this.isDownloading) return false;
            this.isDownloading = true;

            try
            {
                ServiceIo.CleanDownloadFolder();

                DownloadInfo inf = new DownloadInfo();
                inf.Manifest = null;
                inf.DownloadId = (Int32)Downloadables.UpdateManifest;

                this.webClient.DownloadFileAsync(
                    this.updateManifestUri,
                    ServiceIo.GetDownloadDirectoryPath(true),
                    inf);

                return true;
            }
            catch (Exception)
            {
            }

            return false;
        }


        internal bool BeginDownloadPackage(UpdateManifestInfo manifest)
        {
            if (this.isDownloading) return false;
            this.isDownloading = true;

            try
            {
                DownloadInfo inf = new DownloadInfo();
                inf.Manifest = manifest;
                inf.DownloadId = (Int32)Downloadables.UpdatePackage;

                this.webClient.DownloadFileAsync(
                    new Uri(manifest.UpdatePackageUri),
                    ServiceIo.GetDownloadDirectoryPath(true),
                    inf);

                return true;
            }
            catch (Exception)
            {
            }

            return false;
        }


        public delegate void DownloadCompleteEventHandler(object sender, DownloadCompleteEventArgs e);
        public event DownloadCompleteEventHandler DownloadCompleted;

        private void RaiseDownloadCompleted(DownloadInfo inf)
        {
            if (DownloadCompleted != null)
            {
                DownloadCompleted(this, new DownloadCompleteEventArgs(inf));
            }
        }
    }
}
