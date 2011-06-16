using System;
using System.Windows.Forms;
using System.Threading;


namespace ApplicationUpdater
{

    static class Program
    {
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (mutex.WaitOne(TimeSpan.Zero, true))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ProgramContext());

                    mutex.ReleaseMutex();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    // UNDONE: ERROR
                }
                catch { }
            }
        }
    }
}
