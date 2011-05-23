using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class FrmAppSettings : Form
    {

        protected UsersManager ctrlUsers;
        protected RoleManager ctrlRoles;
        protected GeneralAppSettings ctrlGeneralSettings;


        public FrmAppSettings()
        {
            InitializeComponent();

            SetupControls();
        }


        private void SetupControls()
        {
            this.tabUsers.ImageList = new ImageList();
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("clipboard_task"));
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("manage_users"));


            if (DomainModel.Membership.Users.Authorise("User management"))
            {
                this.ctrlUsers = new UsersManager();
                this.tbpUsers.Controls.Add(this.ctrlUsers);
                this.tbpUsers.ImageIndex = 1;
            }
            else
            {
                this.tabUsers.Controls.Remove(this.tbpUsers);
            }


            if (DomainModel.Membership.Users.Authorise("Role management"))
            {
                this.ctrlRoles = new RoleManager();
                this.tbpGeneral.Controls.Add(this.ctrlGeneralSettings);
                this.tbpRoles.Controls.Add(this.ctrlRoles);
                this.tbpRoles.ImageIndex = 0;
            }
            else
            {
                this.tabUsers.Controls.Remove(this.tbpRoles);
            }


            this.ctrlGeneralSettings = new GeneralAppSettings();
        }
    }
}
