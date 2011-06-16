

namespace TaxDataStore.Presentation.Controllers
{

    public class Help
    {

        internal static void About()
        {
            using (FrmAbout frm = new FrmAbout())
            {
                frm.ShowDialog();
            }
        }
    }
}
