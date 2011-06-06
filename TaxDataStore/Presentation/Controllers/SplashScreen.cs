

namespace TaxDataStore.Presentation.Controllers
{

    class SplashScreen
    {

        private static FrmSplashScreen frmSplash;


        internal static void Show()
        {
            if (frmSplash == null)
            {
                frmSplash = new FrmSplashScreen();
            }

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
