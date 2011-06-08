using System;
using System.Threading;


namespace TaxDataStoreUpdater
{

    public class Updater : IDisposable
    {

        protected enum UpdaterStatus
        {
            Idle = 0,
            DownloadingManifest = 1,
            DownloadingPackage = 2,
            ApplyingUpdates = 3,
            CheckingVersion = 4
        }

        protected Thread updaterHandler;
        protected const int ShutdownHandle = 0;
        protected const int ManualCheckHandle = 1;
        protected const int DownloadUpdateHandle = 2;
        protected const int ApplyUpdateHandle = 3;
        protected WaitHandle[] handles;

        protected bool isChecking;
        protected UpdaterStatus status;

        protected Downloader downloader;


        public Updater()
        {
            this.IsNewVersionAvailable = false;
            this.IsDownloadComplete = false;
            this.status = UpdaterStatus.Idle;

            SetupDownloader();
            SetupThread();
        }


        private void SetupDownloader()
        {
            this.downloader = new Downloader();
            this.downloader.DownloadCompleted += new
                TaxDataStoreUpdater.Downloader.
                    DownloadCompleteEventHandler(OnDownloadCompleted);
        }


        private void SetupThread()
        {
            this.isChecking = false;

            this.handles = new WaitHandle[4];
            this.handles[ShutdownHandle] = new AutoResetEvent(false);
            this.handles[ManualCheckHandle] = new AutoResetEvent(false);
            this.handles[DownloadUpdateHandle] = new AutoResetEvent(false);
            this.handles[ApplyUpdateHandle] = new AutoResetEvent(false);

            this.updaterHandler = new Thread(new ThreadStart(UpdaterThread));
        }


        public void Start()
        {
            if (this.updaterHandler == null)
            {
                SetupThread();
            }
            
            if (!this.updaterHandler.IsAlive) this.updaterHandler.Start();
        }


        public void Stop()
        {
            if ((this.updaterHandler != null) && (this.updaterHandler.IsAlive) && this.handles != null)
            {
                ((AutoResetEvent)this.handles[ShutdownHandle]).Set();

                this.updaterHandler = null;
            }
        }


        public void CheckNow()
        {
            if ((this.updaterHandler != null) && (this.updaterHandler.IsAlive) && this.handles != null)
            {
                ((AutoResetEvent)this.handles[ManualCheckHandle]).Set();
            }
        }


        public void DownloadUpdate()
        {
            if ((this.updaterHandler != null) && (this.updaterHandler.IsAlive) && this.handles != null)
            {
                ((AutoResetEvent)this.handles[DownloadUpdateHandle]).Set();
            }
        }


        public void ApplyUpdate()
        {
            if ((this.updaterHandler != null) && (this.updaterHandler.IsAlive) && this.handles != null)
            {
                ((AutoResetEvent)this.handles[ApplyUpdateHandle]).Set();
            }
        }


        public void UpdaterThread()
        {
            try
            {
                while (true)
                {
                    int res = WaitHandle.WaitAny(
                        this.handles,
                        Settings.Instance.AutoUpdateCheckInterval * 1000,
                        false);

                    switch (res)
                    {
                        case ShutdownHandle:
                            this.handles = null;
                            return;

                        case ManualCheckHandle:
                            CheckForUpdates();
                            break;

                        case DownloadUpdateHandle:
                            DownloadNewVersion();
                            break;

                        case ApplyUpdateHandle:
                            ApplyDownloadedUpdate();
                            break;

                        default:
                            // Probably timeout
                            if (Settings.Instance.AutoCheckForUpdates)
                            {
                                CheckForUpdates();
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                try
                {
                    EventLogger.Instance.Add("Error in updater core: " + ex.Message);
                }
                catch { }
            }
        }


        void OnDownloadCompleted(object sender, DownloadCompleteEventArgs e)
        {
            if (e.DownloadInfo.Cancelled || e.DownloadInfo.Error != null)
            {
                EventLogger.Instance.Add("Async download cancelled or failed:");
                if (e.DownloadInfo.Error != null)
                {
                    EventLogger.Instance.Add(e.DownloadInfo.Error.Message);
                }

                return;
            }

            if (e.DownloadInfo.DownloadId == (Int32)Downloader.Downloadables.UpdateManifest)
            {
                OnManifestDownloadComplete(e.DownloadInfo);
            }
            else if (e.DownloadInfo.DownloadId == (Int32)Downloader.Downloadables.UpdatePackage)
            {
                OnPackageDownloadComplete(e.DownloadInfo);
            }
        }


        private void OnManifestDownloadComplete(DownloadInfo downloadInfo)
        {
            DownloadNewVersion(true);
        }


        private void OnPackageDownloadComplete(DownloadInfo downloadInfo)
        {
            if (ServiceIo.ExtractDownloadedPackage(downloadInfo.Manifest))
            {
                this.IsDownloadComplete = true;
                RaiseNewVersionDownloaded(downloadInfo);
            }
        }


        private void CheckForUpdates()
        {
            if (this.isChecking) return;
            this.isChecking = true;

            this.status = UpdaterStatus.DownloadingManifest;
            this.downloader.BeginDownloadManifest();

            this.isChecking = false;
        }


        // download latest updates
        private void DownloadNewVersion(bool checkAutoDownloadFlag = false)
        {
            UpdateManifestInfo info = GetNewVersionInfo();
            if (info != null)
            {
                if ((checkAutoDownloadFlag && Settings.Instance.AutoDownloadUpdate) ||
                    !checkAutoDownloadFlag)
                {
                    this.status = UpdaterStatus.DownloadingPackage;
                    this.downloader.BeginDownloadPackage(info);
                }
            }

            if (this.status != UpdaterStatus.DownloadingPackage)
            {
                this.status = UpdaterStatus.Idle;
            }
        }


        private UpdateManifestInfo GetNewVersionInfo()
        {
            this.status = UpdaterStatus.CheckingVersion;

            UpdateManifestInfo info = GetManifestInfo();
            if (info == null)
            {
                EventLogger.Instance.Add("Cannot get manifest file info. Version comparison failed.");
            }
            else
            {
                System.Reflection.AssemblyName asm = ServiceIo.GetUpdateAssembly();

                if (asm == null)
                {
                    EventLogger.Instance.Add("Cannot get update application assembly. Version comparison failed.");
                }
                else
                {
                    Version currentVersion = asm.Version;
                    Version latestVersion = new Version(info.UpdateVersion);

                    if (latestVersion > currentVersion)
                    {
                        this.IsNewVersionAvailable = true;
                        RaiseNewVersionExists(info);
                        return info;
                    }
                    else
                    {
                        this.IsNewVersionAvailable = false;
                    }
                }
            }

            return null;
        }


        // closes app, overwrites downloaded files and returns
        private void ApplyDownloadedUpdate()
        {
            if (!this.IsNewVersionAvailable) return;
            this.status = UpdaterStatus.ApplyingUpdates;

            // UNDONE: Ensure app is closed
            ServiceIo.OverwriteDownloadedFiles();

            this.IsDownloadComplete = false;
            this.IsNewVersionAvailable = false;
            this.status = UpdaterStatus.Idle;
        }


        // Loads downloaded manifest file
        private UpdateManifestInfo GetManifestInfo()
        {
            return ServiceIo.LoadManifestFile();
        }


        public bool IsNewVersionAvailable { get; set; }


        public bool IsDownloadComplete { get; set; }


        public int Status 
        {
            get
            {
                return (Int32) this.status;
            }
        }

        
        #region Events

        private void RaiseNewVersionExists(UpdateManifestInfo info)
        {
            if (NewVersionFound != null)
            {
                NewVersionFound(this, new UpdateEventArgs(info));
            }
        }


        private void RaiseNewVersionDownloaded(DownloadInfo info)
        {
            if (NewVersionDownloadCompleted != null)
            {
                NewVersionDownloadCompleted(this, new UpdateEventArgs(info.Manifest));
            }
        }


        public delegate void NewVersionDownloadedEventHandler(object sender, UpdateEventArgs e);
        public delegate void NewVersionFoundEventHandler(object sender, UpdateEventArgs e);

        public event NewVersionFoundEventHandler NewVersionFound;
        public event NewVersionDownloadedEventHandler NewVersionDownloadCompleted;

        #endregion Events


        public void Dispose()
        {
            Stop();
        }
    }
}
