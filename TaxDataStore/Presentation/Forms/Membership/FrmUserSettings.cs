using System;
using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class FrmUserSettings : Form
    {

        protected Entities.User user;

        
        public FrmUserSettings()
        {
            InitializeComponent();

            this.user = new Entities.User();

            BindControls();

            this.Load += new EventHandler(FrmUserSettings_Load);
            this.btnChangePassword.Click += new EventHandler(btnChangePassword_Click);
        }


        void btnChangePassword_Click(object sender, EventArgs e)
        {
            Presentation.Controllers.Users.ChangePassword(this.user);
        }


        void FrmUserSettings_Load(object sender, EventArgs e)
        {
            this.user.Copy(DomainModel.Application.User);
            if (user.Culture != null)
            {
                this.cbxLanguages.SelectedItem = this.user.Culture;
            }
        }


        private void BindControls()
        {
            this.cbxLanguages.DataSource = DomainModel.Cultures.GetAll();
            this.cbxLanguages.DisplayMember = "LanguageName";
            this.cbxLanguages.DataBindings.Add(
                new Binding(
                    "SelectedItem",
                    this.user,
                    "Culture",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    null,
                    string.Empty,
                    null));
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user.Culture == null)
            {
                user.Culture = (Entities.Culture)this.cbxLanguages.SelectedItem;
            }

            DomainModel.Application.User.Copy(this.user);
            if (DomainModel.Membership.Users.Save(DomainModel.Application.User))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
