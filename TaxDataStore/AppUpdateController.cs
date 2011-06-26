using System;
using System.Diagnostics;
using TaxDataStore.Presentation.Models;


namespace TaxDataStore
{

    public class AppUpdateController
    {

        private static string UpdaterProcessName = "SettlementUpdater.exe";

        private static AppUpdateInfo updateInfo;
        private static System.Timers.Timer timer;


        public static AppUpdateInfo UpdateInfo
        {
            get
            {
                return updateInfo;
            }
        }


        public static bool StartUpdater()
        {
            bool res;

            try
            {
                updateInfo = new AppUpdateInfo();

                System.Diagnostics.Process.Start(
                    System.Windows.Forms.Application.StartupPath +
                    System.IO.Path.DirectorySeparatorChar +
                    UpdaterProcessName);
                
                timer = new System.Timers.Timer(10000);
                timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
                timer.Start();

                res = true;
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }

                res = false;
            }

            return res;
        }


        static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (IsRunning)
                {
                    using (UpdaterService.UpdaterIpcServiceClient sc = new
                        UpdaterService.UpdaterIpcServiceClient())
                    {
                        updateInfo.LastCheckTime = sc.GetLastCheckTimestamp();
                        updateInfo.Details = sc.GetNewVersionDetails();
                        updateInfo.UpdateExists = sc.UpdateExists();
                        updateInfo.DownloadIsComplete = sc.IsDownloadComplete();

                        sc.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }
        }


        public static bool IsRunning
        {
            get
            {
                bool res = false;
                try
                {
                    Process[] processes = Process.GetProcessesByName(UpdaterProcessName.Replace(".exe", ""));
                    if (processes.Length > 0)
                    {
                        res = true;
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        DomainModel.Application.Status.Update(
                            StatusController.Abstract.StatusTypes.Error,
                            "",
                            ex.Message);
                    }
                    catch { }
                }

                return res;
            }
        }


        internal static void CheckForUpdates()
        {
            try
            {
                using (UpdaterService.UpdaterIpcServiceClient sc = new
                    UpdaterService.UpdaterIpcServiceClient())
                {
                    sc.CheckForUpdates();
                    sc.Close();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }
        }


        internal static void DownloadUpdates()
        {
            try
            {
                using (UpdaterService.UpdaterIpcServiceClient sc = new
                    UpdaterService.UpdaterIpcServiceClient())
                {
                    sc.DownloadUpdates();
                    sc.Close();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }
        }


        internal static void ApplyUpdates()
        {
            try
            {
                using (UpdaterService.UpdaterIpcServiceClient sc = new
                    UpdaterService.UpdaterIpcServiceClient())
                {
                    sc.ApplyUpdates();
                    sc.Close();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }
        }
    }
}
