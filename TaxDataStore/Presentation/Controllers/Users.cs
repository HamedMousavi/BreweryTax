using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controllers
{

    public class Users
    {

        private static FrmLogin frmLogin;
        private static ProgramContext program;
        private static FrmStaffTimeRecorder frmStaffTimeRecorder;


        internal static void DisplayLoginWindow(ProgramContext programContext)
        {
            program = programContext;

            if (frmLogin == null)
            {
                frmLogin = new FrmLogin();
                frmLogin.FormClosed += new FormClosedEventHandler(OnLoginFormClosed);
            }

            frmLogin.Show();
        }


        static void OnLoginFormClosed(object sender, FormClosedEventArgs e)
        {
            program.EndAuthenticate(frmLogin.DialogResult == DialogResult.OK);
        }


        public static void Settings()
        {
            using (FrmUserSettings frm = new FrmUserSettings())
            {
                frm.ShowDialog();
            }
        }


        public static void Presence()
        {
            if (frmStaffTimeRecorder == null)
            {
                frmStaffTimeRecorder = new FrmStaffTimeRecorder();
            }

            View.MainWindow.ClientFormManager.DisplayClientForm(frmStaffTimeRecorder);
        }


        internal static void Edit(Entities.User user)
        {
            using (FrmUserEditor frm = new FrmUserEditor(user))
            {
                frm.ShowDialog();
            }
        }


        internal static void Delete(Entities.User user)
        {
            DomainModel.Membership.Users.Delete(user);
        }


        internal static void ToggleEnabled(Entities.User user)
        {
            user.IsEnabled = !user.IsEnabled;
            DomainModel.Membership.Users.Save(user);
        }


        internal static bool AddNew()
        {
            using (FrmUserEditor frm = new FrmUserEditor())
            {
                return (frm.ShowDialog() == DialogResult.OK);
            }
        }


        internal static void ChangePassword(Entities.User user)
        {
            using (FrmPasswordEditor frm = new FrmPasswordEditor(user))
            {
                frm.ShowDialog();
            }
        }
    }
}
