using System;
using System.Threading;


namespace ApplicationUpdater
{

    public class Updater : IDisposable
    {

        protected enum UpdaterStatus
        {
            Idle = 0,
            DownloadingManifest = 1,
            DownloadingPackage = 2,
            ApplyingUpdates = 3,
            CheckingVersion = 4,
            ManifestDownloadCompleted = 5,
            PackageDownloadCompleted = 6
        }


        protected Thread updaterThread;
        protected const int ShutdownHandle = 0;
        protected const int ManualCheckHandle = 1;
        protected const int DownloadUpdateHandle = 2;
        protected const int ApplyUpdateHandle = 3;
        protected WaitHandle[] handles;

        protected StateHandler state;

        protected Downloader downloader;


        public Updater()
        {
            InitState();
            SetupThread();
        }


        private void InitState()
        {
            this.LastPollingTimestamp = null;
            this.NewVersionDetails = string.Empty;
            this.IsNewVersionAvailable = false;
            this.IsDownloadComplete = false;

            this.state = new StateHandler(UpdaterStatus.Idle);
        }


        private void SetupDownloader()
        {
            try
            {
                this.downloader = new Downloader();
                this.downloader.DownloadCompleted += new
                    ApplicationUpdater.Downloader.
                        DownloadCompleteEventHandler(OnDownloadCompleted);
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        private void SetupThread()
        {
            try
            {
                this.handles = new WaitHandle[4];
                this.handles[ShutdownHandle] = new AutoResetEvent(false);
                this.handles[ManualCheckHandle] = new AutoResetEvent(false);
                this.handles[DownloadUpdateHandle] = new AutoResetEvent(false);
                this.handles[ApplyUpdateHandle] = new AutoResetEvent(false);

                this.updaterThread = new Thread(new ThreadStart(UpdaterThread));
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        public void Start()
        {
            try
            {
                ServiceIo.LoadSettings();

                SetupDownloader();
                if (this.updaterThread == null)
                {
                    SetupThread();
                }

                if (!this.updaterThread.IsAlive) this.updaterThread.Start();
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        public void Stop()
        {
            StopThread();
            CloseDownloader();
            InitState();
        }


        private void CloseDownloader()
        {
            try
            {
                this.downloader.DownloadCompleted -= new
                        ApplicationUpdater.Downloader.
                            DownloadCompleteEventHandler(OnDownloadCompleted);
                this.downloader.Dispose();
                this.downloader = null;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        private void StopThread()
        {
            try
            {
                if (this.updaterThread != null &&
                    this.updaterThread.IsAlive &&
                    this.handles != null)
                {
                    ((AutoResetEvent)this.handles[ShutdownHandle]).Set();

                    this.updaterThread = null;
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        public void CheckNow()
        {
            try
            {
                if ((this.updaterThread != null) && (this.updaterThread.IsAlive) && this.handles != null)
                {
                    ((AutoResetEvent)this.handles[ManualCheckHandle]).Set();
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        public void DownloadUpdate()
        {
            try
            {
                if ((this.updaterThread != null) && (this.updaterThread.IsAlive) && this.handles != null)
                {
                    ((AutoResetEvent)this.handles[DownloadUpdateHandle]).Set();
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        public void ApplyUpdate()
        {
            try
            {
                if ((this.updaterThread != null) && (this.updaterThread.IsAlive) && this.handles != null)
                {
                    ((AutoResetEvent)this.handles[ApplyUpdateHandle]).Set();
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
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
            try
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
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        private void OnManifestDownloadComplete(DownloadInfo downloadInfo)
        {
            this.state.Current = UpdaterStatus.ManifestDownloadCompleted;
            DownloadNewVersion(true);
        }


        private void OnPackageDownloadComplete(DownloadInfo downloadInfo)
        {
            try
            {
                if (ServiceIo.ExtractDownloadedPackage(downloadInfo.Manifest))
                {
                    ServiceIo.Cleanup(downloadInfo.Manifest);
                    this.state.Current = UpdaterStatus.PackageDownloadCompleted;

                    this.IsDownloadComplete = true;
                    RaiseNewVersionDownloaded(downloadInfo);
                    return;
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }

            this.state.Current = UpdaterStatus.Idle;
        }


        private bool CheckForUpdates()
        {
            // There's already a new version ready to set up
            if (IsDownloadComplete) return false;

            // If an operation is being done, do not interfere
            if ((UpdaterStatus)this.state.Current != UpdaterStatus.Idle) return false;
            this.state.Current = UpdaterStatus.DownloadingManifest;

            this.LastPollingTimestamp = DateTime.UtcNow;
            return this.downloader.BeginDownloadManifest();
        }


        // download latest updates
        private bool DownloadNewVersion(bool checkAutoDownloadFlag = false)
        {
            bool res = false;
            try
            {
                // There's already a new version ready to set up
                if (this.IsDownloadComplete) return res;

                // If an operation is being done, do not interfere
                UpdaterStatus state = (UpdaterStatus)this.state.Current;
                if ((state == UpdaterStatus.ManifestDownloadCompleted ||
                    state == UpdaterStatus.Idle))
                {
                    res = true;
                    UpdateManifestInfo info = GetNewVersionInfo();
                    if (info != null)
                    {
                        this.NewVersionDetails = info.ChangeLog;

                        if ((checkAutoDownloadFlag && Settings.Instance.AutoDownloadUpdate) ||
                            !checkAutoDownloadFlag)
                        {
                            EventLogger.Instance.Add("Found new version.");

                            this.state.Current = UpdaterStatus.DownloadingPackage;
                            res = this.downloader.BeginDownloadPackage(info);
                        }
                        else
                        {
                            EventLogger.Instance.Add("Found new version auto download is off. It'll not be downloaded.");
                        }
                    }

                    if ((UpdaterStatus)this.state.Current != UpdaterStatus.DownloadingPackage)
                    {
                        this.state.Current = UpdaterStatus.Idle;
                    }
                }
            }
            catch (Exception ex)
            {
                this.state.Current = UpdaterStatus.Idle;
                EventLogger.Instance.Add(ex.Message);
                res = false;
            }

            return res;
        }


        private UpdateManifestInfo GetNewVersionInfo()
        {
            try
            {
                object tmpCurr = this.state.Current;
                this.state.Current = UpdaterStatus.CheckingVersion;

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
                this.state.Current = tmpCurr;
            }
            catch (Exception ex)
            {
                //this.state.Current = UpdaterStatus.Idle;
                EventLogger.Instance.Add(ex.Message);
            }

            return null;
        }


        // closes app, overwrites downloaded files and returns
        private bool ApplyDownloadedUpdate()
        {
            try
            {
                if (!this.IsNewVersionAvailable) return false;
                this.state.Current = UpdaterStatus.ApplyingUpdates;

                string processName = ServiceIo.GetUpdateAppProcessName();
                EventLogger.Instance.Add("Closing process: " + processName);

                // Ensure app is closed
                if (WindowsProcessController.IsProcessAlive(processName))
                {
                    System.Threading.Thread.Sleep(1000);

                    if (WindowsProcessController.IsProcessAlive(processName))
                    {
                        WindowsProcessController.KillProcess(processName);
                        System.Threading.Thread.Sleep(1000);
                    }
                }

                if (WindowsProcessController.IsProcessAlive(processName))
                {
                    EventLogger.Instance.Add("Failed to stop process. Updates weren't applied");
                    return false;
                }

                // Backup before overwriting files
                EventLogger.Instance.Add("Backing up files." );
                if (!ServiceIo.BackupStartupDirectory())
                {
                    return false;
                }

                // Restore backup if overwrite failed
                EventLogger.Instance.Add("Copying new files");
                if (!ServiceIo.OverwriteDownloadedFiles())
                {
                    EventLogger.Instance.Add("Overwrite failed, restoring backup");
                    ServiceIo.RestoreStartupDirectory();
                }

                // Clean up
                EventLogger.Instance.Add("Cleaning up.");
                ServiceIo.CleanupBackups();

                // Update state
                this.IsDownloadComplete = false;
                this.IsNewVersionAvailable = false;
                this.state.Current = UpdaterStatus.Idle;

                // Restarting app
                WindowsProcessController.Execute(ServiceIo.GetUpdateAppPath());

                return true;
            }
            catch (Exception ex)
            {
                this.state.Current = UpdaterStatus.Idle;
                EventLogger.Instance.Add(ex.Message);
            }

            return false;
        }


        // Loads downloaded manifest file
        private UpdateManifestInfo GetManifestInfo()
        {
            return ServiceIo.LoadManifestFile();
        }


        public bool IsNewVersionAvailable { get; set; }
        public bool IsDownloadComplete { get; set; }
        public string NewVersionDetails { get; set; }
        public DateTime? LastPollingTimestamp { get; set; }


        public int Status 
        {
            get
            {
                return (Int32)(UpdaterStatus) this.state.Current;
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
