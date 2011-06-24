using System.Windows.Forms;
using Entities;


namespace TaxDataStore
{

    public partial class FrmRoleEditor : BaseForm
    {

        protected Role role;
        protected Role editRole;


        public FrmRoleEditor(Entities.Role role = null)
        {
            InitializeComponent();

            this.role = new Role();

            if (role != null)
            {
                this.role.Copy(role);
                this.editRole = role;
            }

            SetupControls();
            BindControls();
        }

        private void SetupControls()
        {
            this.Text = Resources.Texts.edit_role;

            this.btnSave.Text = Resources.Texts.save;
            this.btnCancel.Text = Resources.Texts.cancel;
        }


        private void BindControls()
        {
            this.tbxRoleName.DataBindings.Clear();
            this.tbxRoleName.DataBindings.Add(new Binding(
                "Text",
                this.role,
                "Name",
                false,
                DataSourceUpdateMode.OnPropertyChanged,
                string.Empty,
                string.Empty,
                null));
        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (this.editRole != null)
            {
                // Update edit user and database
                this.editRole.Copy(this.role);
            }

            if (DomainModel.Membership.Roles.Save(this.role))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }


        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
