using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmUserEditor : BaseForm
    {

        private FormLabel lblName;
        private FormLabel lblLanguage;
        private FormLabel lblPassword;
        private FormLabel lblRole;

        protected Entities.User user;
        protected Entities.User editUser;


        public FrmUserEditor(Entities.User user = null)
        {
            InitializeComponent();

            this.lblName = new FormLabel(0, "lblName", false, "username");
            this.lblLanguage = new FormLabel(1, "lblLanguage", false, "language");
            this.lblPassword = new FormLabel(2, "lblPassword", false, "password");
            this.lblRole = new FormLabel(3, "lblRole", false, "role_name");

            this.tlpMain.Controls.Add(this.lblName, 0, 1);
            this.tlpMain.Controls.Add(this.lblLanguage, 0, 3);
            this.tlpMain.Controls.Add(this.lblRole, 0, 4);
            this.tlpMain.Controls.Add(this.lblPassword, 0, 2);

            if (user == null)
            {
                this.user = new Entities.User();
            }
            else
            {
                this.editUser = user;
                this.user = user.Clone();
            }

            this.Load += new EventHandler(FrmUserEditor_Load);
        }


        void FrmUserEditor_Load(object sender, EventArgs e)
        {
            this.Text = Resources.Texts.edit_user;
            this.chbxIsEnabled.Text = Resources.Texts.enable;

            this.btnSave.Text = Resources.Texts.save;
            this.btnCancel.Text = Resources.Texts.cancel;

            BindControlsData();
        }


        private void BindControlsData()
        {
            this.cbxLanguage.DataSource = DomainModel.Cultures.GetAll();
            this.cbxLanguage.DisplayMember = "LanguageName";
            this.cbxLanguage.DataBindings.Add(
                new Binding(
                    "SelectedItem",
                    this.user,
                    "Culture",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    null,
                    string.Empty,
                    null));
            
            this.cbxRole.DataSource = DomainModel.Membership.Roles.GetAll();
            this.cbxRole.DisplayMember = "Name";
            this.cbxRole.DataBindings.Add(
                new Binding(
                    "SelectedItem",
                    this.user,
                    "Role",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    null,
                    string.Empty,
                    null));

            this.tbxName.DataBindings.Add(
                new Binding(
                    "Text",
                    this.user,
                    "Name",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.tbxPassword.DataBindings.Add(
                new Binding(
                    "Text",
                    this.user,
                    "Password",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.chbxIsEnabled.DataBindings.Add(
                new Binding(
                    "Checked",
                    this.user,
                    "IsEnabled",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    false,
                    string.Empty,
                    null));
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user.Culture == null)
            {
                user.Culture = (Entities.Culture)this.cbxLanguage.SelectedItem;
            }

            if (user.Role == null)
            {
                user.Role = (Entities.Role)this.cbxRole.SelectedItem;
            }

            if (this.editUser != null)
            {
                // Update edit user and database
                this.editUser.Copy(this.user);
            }

            if (DomainModel.Membership.Users.Save(this.user))
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
