using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmAppSettings : Form
    {

        protected UsersManager ctrlUsers;
        protected RoleManager ctrlRoles;
        protected GeneralAppSettings ctrlGeneralSettings;
        protected TourPaymentSettings ctrlTourPaymentSettings;


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
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("money_coin"));

            this.tbpRoles.ImageIndex = 0;
            this.tbpUsers.ImageIndex = 1;
            this.tbpTourPayment.ImageIndex = 2;

            if (DomainModel.Membership.Users.Authorise("User management"))
            {
                this.ctrlUsers = new UsersManager();
                this.tbpUsers.Controls.Add(this.ctrlUsers);
            }
            else
            {
                this.tabUsers.Controls.Remove(this.tbpUsers);
            }


            if (DomainModel.Membership.Users.Authorise("Role management"))
            {
                this.ctrlRoles = new RoleManager();
                this.tbpRoles.Controls.Add(this.ctrlRoles);
            }
            else
            {
                this.tabUsers.Controls.Remove(this.tbpRoles);
            }


            this.ctrlGeneralSettings = new GeneralAppSettings();
                this.tbpGeneral.Controls.Add(this.ctrlGeneralSettings);
            
            
            this.ctrlTourPaymentSettings = new TourPaymentSettings();
            this.tbpTourPayment.Controls.Add(this.ctrlTourPaymentSettings);
        }
    }
}
