

namespace TaxDataStore.Presentation.Controllers
{

    public class Mails
    {

        private static FrmMailBox frmMailbox;


        internal static void Today()
        {
            if (frmMailbox == null)
            {
                frmMailbox = new FrmMailBox();
            }

            View.MainWindow.ClientFormManager.DisplayClientForm(frmMailbox);
        }


        internal static void Compose()
        {
            using (FrmMailComposer frm = new FrmMailComposer())
            {
                frm.ShowDialog();
            }
        }
    }
}
