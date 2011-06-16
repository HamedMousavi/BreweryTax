using System;
using System.IO;
using System.Windows.Forms;


namespace ApplicationUpdater
{

    public class EventLogger
    {

        #region singleton

        protected static EventLogger instance;
        protected static object instLock = new object();
        public static EventLogger Instance
        {
            get
            {
                lock (instLock)
                {
                    if (instance == null)
                    {
                        instance = new EventLogger();
                    }
                }

                return instance;
            }
        }

        #endregion


        internal void Add(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
            StreamWriter sw = null;

            try
            {
                String strPath =
                    string.Format("{0}\\Logs\\Updater-{1}.{2}.{3}.log",
                    Application.StartupPath,
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day);

                sw = new StreamWriter(
                    strPath,
                    true,
                    System.Text.Encoding.ASCII);

                sw.WriteLine(string.Format(
                    "Datetime: {0} {1} ",
                    DateTime.Now,
                    message));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("-> Error: " + e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
