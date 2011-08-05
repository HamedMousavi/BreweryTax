

namespace TaxDataStore.Presentation.Controllers
{

    public class Desktop
    {

        private static FrmDesktop frmDesktop;


        public static void Workbench()
        {
            if (frmDesktop == null)
            {
                frmDesktop = new FrmDesktop();
            }

            View.MainWindow.ClientFormManager.DisplayClientForm(frmDesktop);
        }
    }
}
