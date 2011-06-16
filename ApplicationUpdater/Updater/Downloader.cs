using System;
using System.ComponentModel;
using System.Net;


namespace ApplicationUpdater
{

    public class Downloader : IDisposable
    {

        public enum Downloadables
        {
            UpdateManifest = 0,
            UpdatePackage = 1
        }


        public enum DownloaderState
        {
            Idle,
            DownloadingManifest,
            DownloadingPackage,
            DownloadCompleted
        }


        protected WebClient webClient;
        protected Uri updateManifestUri;
        protected StateHandler downloadState;


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
            this.downloadState = new StateHandler(DownloaderState.Idle);

            this.updateManifestUri = new Uri(Settings.Instance.UpdateUri);

            this.webClient = new WebClient();
            this.webClient.DownloadFileCompleted += new
                AsyncCompletedEventHandler(OnDownloadFileCompleted);
        }


        internal bool BeginDownloadManifest()
        {
            try
            {
                if ((DownloaderState)this.downloadState.Current != DownloaderState.Idle)
                {
                    EventLogger.Instance.Add("Cannot download manifest. Downloader state isn't idle.");
                    return false;
                }
                this.downloadState.Current = DownloaderState.DownloadingManifest;
                EventLogger.Instance.Add("Downloading manifest...");

                ServiceIo.CleanDownloadFolder();

                DownloadInfo inf = new DownloadInfo();
                inf.Manifest = null;
                inf.DownloadId = (Int32)Downloadables.UpdateManifest;

                this.webClient.DownloadFileAsync(
                    this.updateManifestUri,
                    ServiceIo.GetManifestFilePath(),
                    inf);

                return true;
            }
            catch (Exception ex)
            {
                this.downloadState.Current = DownloaderState.Idle;
                EventLogger.Instance.Add(ex.Message);
            }

            return false;
        }


        internal bool BeginDownloadPackage(UpdateManifestInfo manifest)
        {
            try
            {
                if ((DownloaderState)this.downloadState.Current == DownloaderState.DownloadingManifest ||
                    (DownloaderState)this.downloadState.Current == DownloaderState.DownloadingPackage)
                {
                    EventLogger.Instance.Add("Cannot download package. Downloader is already downloading.");
                    return false;
                }

                if (manifest == null) return false;
                EventLogger.Instance.Add("Downloading package...");

                this.downloadState.Current = DownloaderState.DownloadingPackage;

                DownloadInfo inf = new DownloadInfo();
                inf.Manifest = manifest;
                inf.DownloadId = (Int32)Downloadables.UpdatePackage;

                this.webClient.DownloadFileAsync(
                    new Uri(manifest.UpdatePackageUri),
                    ServiceIo.GetPackageFilePath(inf.Manifest),
                    inf);

                return true;
            }
            catch (Exception ex)
            {
                this.downloadState.Current = DownloaderState.Idle;
                EventLogger.Instance.Add(ex.Message);
            }

            return false;
        }


        void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                this.downloadState.Current = DownloaderState.DownloadCompleted;

                DownloadInfo inf = (DownloadInfo)e.UserState;
                inf.Cancelled = e.Cancelled;
                inf.Error = e.Error;

                RaiseDownloadCompleted(inf);

                this.downloadState.Current = DownloaderState.Idle;
                EventLogger.Instance.Add("Download completed.");
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }

        }


        #region Events

        public delegate void DownloadCompleteEventHandler(object sender, DownloadCompleteEventArgs e);
        public event DownloadCompleteEventHandler DownloadCompleted;

        private void RaiseDownloadCompleted(DownloadInfo inf)
        {
            if (DownloadCompleted != null)
            {
                DownloadCompleted(this, new DownloadCompleteEventArgs(inf));
            }
        }

        #endregion Events


        public void Dispose()
        {
            this.webClient.DownloadFileCompleted -= new
                AsyncCompletedEventHandler(OnDownloadFileCompleted);
            this.webClient.Dispose();
            this.downloadState.Current = DownloaderState.Idle;
        }
    }
}
