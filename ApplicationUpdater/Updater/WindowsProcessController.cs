using System;
using System.Diagnostics;


namespace ApplicationUpdater
{

    public class WindowsProcessController
    {

        public static bool IsProcessAlive(string name)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(name);
                if (processes.Length > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: IsProcessAlive " + ex.Message);
            }

            EventLogger.Instance.Add("Process not found: " + name);
            return false;
        }


        public static bool KillProcess(string name)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(name);
                foreach (Process process in processes)
                {
                    process.Kill();
                }

                return true;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: KillProcess " + ex.Message);
            }

            return false;
        }


        public static bool Execute(string appPath)
        {
            try
            {
                var info = new ProcessStartInfo(appPath, string.Empty)
                {
                    UseShellExecute = true
                };

                var process = new Process
                {
                    EnableRaisingEvents = false, // enable WaitForExit()
                    StartInfo = info
                };

                process.Start();
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add(ex.Message);
            }

            return false;
        }
    }
}
