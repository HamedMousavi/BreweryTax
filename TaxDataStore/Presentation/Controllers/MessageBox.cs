using System;


namespace TaxDataStore.Presentation.Controllers
{

    public class MessageBox
    {

        internal static bool ConfirmUpdate()
        {
            //throw new NotImplementedException();
            // UNDONE

            return true;
        }


        internal static bool ConfirmDelete()
        {
            return true;
        }

        internal static bool ConfirmRestart()
        {
            if (System.Windows.Forms.MessageBox.Show(
                "Installation will restart application. Restart now?",
                "Confirm restart",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
