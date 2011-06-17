using System;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore
{

    public partial class FrmLogin : Form
    {

        protected User user { get; set; }


        public FrmLogin()
        {
            InitializeComponent();

            SetupControls();
            SetupBindings();
        }


        private void SetupControls()
        {
            this.Text = Resources.Texts.logon;
            this.btnExit.Text = Resources.Texts.exit;
            this.btnLogin.Text = Resources.Texts.login;
        }


        private void SetupBindings()
        {
            this.user = new User();

            this.cbxUserName.DataSource = DomainModel.Membership.Users.GetAll();
            this.cbxUserName.DisplayMember = "Name";

            this.cbxUserName.DataBindings.Add(new Binding("Text", this.user, "Name"));
            this.tbxPassword.DataBindings.Add(new Binding("Text", this.user, "Password"));
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = DomainModel.
                Membership.Users.Authenticate(this.user);
            
            if (authenticated)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // UNDONE: update status
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
