using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controllers
{

    public class Roles
    {

        internal static bool AddNew()
        {
            using (FrmRoleEditor frm = new FrmRoleEditor())
            {
                return (frm.ShowDialog() == DialogResult.OK);
            }
        }


        internal static void Edit(Entities.Role role)
        {
            using (FrmRoleEditor frm = new FrmRoleEditor(role))
            {
                frm.ShowDialog();
            }
        }


        internal static void Delete(Entities.Role role)
        {
            DomainModel.Membership.Roles.Delete(role);
        }
    }
}
