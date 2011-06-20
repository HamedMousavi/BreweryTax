using System.Windows.Forms;
using System;


namespace TaxDataStore
{

    public partial class FrmPasswordEditor : Form
    {

        private Entities.User user;


        public FrmPasswordEditor()
        {
            InitializeComponent();
            SetupTexts();
        }


        public FrmPasswordEditor(Entities.User user)
            : this()
        {
            // TODO: Complete member initialization
            this.user = user;
        }


        private void SetupTexts()
        {
            this.Text = Resources.Texts.change_password;
            this.lblConfirmPass.Text = Resources.Texts.confirm_password;
            this.lblNewPass.Text = Resources.Texts.new_password;
            this.lblOldPass.Text = Resources.Texts.old_password;
            this.btnCancel.Text = Resources.Texts.cancel;
            this.btnSave.Text = Resources.Texts.save;
        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (SavePassword())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }


        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }


        private bool SavePassword()
        {
            bool res;

            if (DomainModel.Application.User.Password.Equals(
                    this.tbxOldPass.Text, StringComparison.InvariantCulture))
            {
                if (!string.IsNullOrEmpty(this.tbxNewPass.Text))
                {
                    if (this.tbxNewPass.Text.Equals(this.tbxConfirmPass.Text,
                        StringComparison.InvariantCulture))
                    {
                        this.user.Password = this.tbxNewPass.Text;
                        res = true;
                    }
                    else
                    {
                        res = false;
                        DomainModel.Application.Status.Update(
                            StatusController.Abstract.StatusTypes.Error,
                                "stat_err_password_confirm_no_match");
                    }
                }
                else
                {
                    res = false;
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                            "stat_err_password_left_empty");
                }
            }
            else
            {
                res = false;
                DomainModel.Application.Status.Update(
                    StatusController.Abstract.StatusTypes.Error,
                        "stat_err_password_incorrect");
            }

            return res;
        }
    }
}
