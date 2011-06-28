

namespace TaxDataStore.Presentation.Controllers
{

    class SplashScreen
    {

        private static FrmSplashScreen frmSplash;


        internal static void Show(Entities.JobProgress progress = null)
        {
            if (frmSplash == null)
            {
                frmSplash = new FrmSplashScreen();
            }

            frmSplash.Progress = progress;
            frmSplash.Show();

            System.Windows.Forms.Application.DoEvents();

        }


        internal static void Hide()
        {
            if (frmSplash != null)
            {
                frmSplash.Hide();
            }
        }
    }
}
