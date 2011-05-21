using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaxDataStore
{
    public partial class FrmUserEditor : Form
    {

        protected Entities.User user;
        protected Entities.User editUser;

        public FrmUserEditor(Entities.User user = null)
        {
            InitializeComponent();

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

            this.lblLanguage.Text = Resources.Texts.language;
            this.lblPassword.Text = Resources.Texts.password;
            this.lblName.Text = Resources.Texts.username;
            this.btnSave.Text = Resources.Texts.save;
            this.btnCancel.Text = Resources.Texts.cancel;
            this.lblRole.Text = Resources.Texts.role_name;

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
