using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controllers
{

    public class Application
    {

        private static FrmMain frmMain;
        private static FrmAppSettings frmAppSettings;
        private static ProgramContext program;
        

        internal static void DisplayMainWindow(ProgramContext programContext)
        {
            program = programContext;

            frmMain = new FrmMain();
            frmMain.FormClosed += new FormClosedEventHandler(OnMainFormClosed);
            frmMain.Show();
        }


        static void OnMainFormClosed(object sender, FormClosedEventArgs e)
        {
            program.EndMainWindow();
        }


        public static void Exit()
        {
            program.EndMainWindow();
        }


        public static void Settings()
        {
            if (frmAppSettings == null)
            {
                frmAppSettings = new FrmAppSettings();
            }

            View.MainWindow.ClientFormManager.DisplayClientForm(frmAppSettings);
        }
    }
}
