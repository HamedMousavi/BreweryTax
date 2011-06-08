using System;
using System.Diagnostics;
using System.Reflection;
using System.ServiceProcess;


namespace TaxDataStoreUpdater
{

    public class ServiceInterface
    {

        public static bool Install()
        {
            return RunServiceAsAdmin("-i");
        }


        public static bool UnInstall()
        {
            return RunServiceAsAdmin("-u");
        }


        public static bool ServiceExists
        {
            get
            {
                try
                {
                    ServiceController controller = FindService();
                    return controller != null;
                }
                catch (Exception ex)
                {
                    EventLogger.Instance.Add(ex.Message);
                }

                return false;
            }
        }


        public static bool ServiceIsRunning
        {
            get
            {
                try
                {
                    ServiceController controller = FindService();

                    if (controller != null)
                    {
                        controller.Refresh();

                        switch (controller.Status)
                        {
                            case ServiceControllerStatus.Running:
                            case ServiceControllerStatus.ContinuePending:
                            case ServiceControllerStatus.StartPending:
                                return true;

                            default:
                                break;
                        }

                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Instance.Add(ex.Message);
                }

                return false;
            }
        }


        public static void Start()
        {
            RunServiceAsAdmin("-s");
        }


        public static ServiceController FindService()
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController controller in services)
            {
                if (string.Equals(controller.ServiceName, Settings.Instance.ServiceName, StringComparison.InvariantCulture))
                {
                    return controller;
                }
            }

            return null;
        }
 

        private static bool RunServiceAsAdmin(string arg)
        {
            bool res = false;

            try
            {
                string exePath = Assembly.GetEntryAssembly().Location;
                string exeDir = System.IO.Path.GetDirectoryName(exePath);
                string srvPath = exeDir + System.IO.Path.DirectorySeparatorChar + Settings.Instance.ServiceFileName;

                var info = new ProcessStartInfo(srvPath, arg)
                {
                    UseShellExecute = true,
                    Verb = "runas", // eleavate privileges
                };

                var process = new Process
                {
                    EnableRaisingEvents = true, // enable WaitForExit()
                    StartInfo = info
                };

                process.Start();
                process.WaitForExit();

                res = true;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }

            return res;
        }
   }
}
