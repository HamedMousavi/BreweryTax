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
            this.ctrlGeneralSettings = new GeneralAppSettings();
            this.ctrlRoles = new RoleManager();
            this.ctrlUsers = new UsersManager();

            this.tabUsers.ImageList = new ImageList();
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("clipboard_task"));
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("manage_users"));

            this.tbpGeneral.Controls.Add(this.ctrlGeneralSettings);
            this.tbpRoles.Controls.Add(this.ctrlRoles);
            this.tbpRoles.ImageIndex = 0;
            
            this.tbpUsers.Controls.Add(this.ctrlUsers);
            this.tbpUsers.ImageIndex = 1;
        }
    }
}
