using System;
using System.Diagnostics;


namespace TaxDataStoreUpdater
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
    }
}
