using System;
using System.Collections;
using System.Configuration.Install;
using System.ServiceProcess;


namespace TaxDataStoreUpdater
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                switch (arg)
                {
                    case "-i":
                        Install();
                        return;

                    case "-u":
                        ServiceIo.LoadSettings();
                        UnInstall();
                        return;

                    case "-s":
                        ServiceIo.LoadSettings();
                        StartWinService();
                        return;

                    default:
                        ServiceIo.LoadSettings();
                        break;
                }
            }

            RunServices();
        }


        private static void StartWinService()
        {
            ServiceController controller = ServiceInterface.FindService();

            try
            {
                if (controller != null)
                {
                    controller.Start();
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }
        }


        private static void RunServices()
        {
            EventLogger.Instance.Add("Starting TaxDataStoreWindows Services...");
            
            ServiceBase[] ServicesToRun;
            bool bClearToExit = false;

            while (!bClearToExit)
            {
                try
                {
                    bClearToExit = true;
                    ServicesToRun = new ServiceBase[] 
			        { 
				        new TaxDataStoreService() 
			        };

                    ServiceBase.Run(ServicesToRun);
                }
                catch (Exception e)
                {
                    bClearToExit = false;
                }
            }

            EventLogger.Instance.Add("Exiting TaxDataStoreWindows Services...");
        }


        private static void Install()
        {
            EventLogger.Instance.Add("Installing TaxDataStoreWindows Services...");

            using (AssemblyInstaller inst = new AssemblyInstaller(typeof(Program).Assembly, new string[] { }))
            {
                IDictionary state = new Hashtable();
                inst.UseNewContext = true;
                try
                {
                    // install service
                    inst.Install(state);
                    inst.Commit(state);

                    // Create settings file
                    ServiceIo.SaveSettings();

                    EventLogger.Instance.Add("Installation completed successfully.");
                }
                catch (Exception ex)
                {
                    try
                    {
                        EventLogger.Instance.Add(
                            string.Format("Failed to install: {0}", ex.Message));

                        inst.Rollback(state);
                    }
                    catch { }
                }
            }
        }


        private static void UnInstall()
        {
            EventLogger.Instance.Add("Removing TaxDataStoreWindows Services...");

            using (AssemblyInstaller inst = new AssemblyInstaller(typeof(Program).Assembly, new string[] { }))
            {
                IDictionary state = new Hashtable();
                inst.UseNewContext = true;
                try
                {
                    inst.Uninstall(state);
                    EventLogger.Instance.Add("Uninstall completed successfully.");
                }
                catch(Exception ex)
                {
                    try
                    {
                        EventLogger.Instance.Add(
                            string.Format("Uninstall failed: {0}", ex.Message));
                        
                        //inst.Rollback(state);
                    }
                    catch { }
                }
            }
        }
    }
}
