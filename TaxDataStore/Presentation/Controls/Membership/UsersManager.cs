using System;
using System.Windows.Forms;
using System.Drawing;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class UsersManager : UserControl
    {

        protected UsersListView lsvUsers;


        public UsersManager()
        {
            InitializeComponent();

            SetupControls();
            this.Dock = DockStyle.Fill;
        }


        private void SetupControls()
        {
            this.lblDetails.Text = Resources.Texts.details;
            this.lblUsers.Text = Resources.Texts.users;

            this.lblIsEnabled.ForeColor = Color.Red;
            this.lblIsEnabled.Text = Resources.Texts.select_user;
            this.lblLanguage.Text = Resources.Texts.language;
            this.lblName.Text = Resources.Texts.name;
            this.lblRoleName.Text = Resources.Texts.role_name;

            this.btnAddUser.Text = Resources.Texts.add;
            this.btnDeleteUser.Text = Resources.Texts.delete;
            this.btnEditUser.Text = Resources.Texts.edit;
            this.btnEnableUser.Text = Resources.Texts.disable;

            this.btnAddUser.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnDeleteUser.Image = DomainModel.Application.ResourceManager.GetImage("delete");
            this.btnEditUser.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            this.btnEnableUser.Image = DomainModel.Application.ResourceManager.GetImage("closed_lock");

            this.mnuUsers.Items[0].Text = Resources.Texts.edit;
            this.mnuUsers.Items[1].Text = Resources.Texts.delete;
            this.mnuUsers.Items[2].Text = Resources.Texts.disable;
            this.mnuUsers.Items[0].Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            this.mnuUsers.Items[1].Image = DomainModel.Application.ResourceManager.GetImage("delete");
            this.mnuUsers.Items[2].Image = DomainModel.Application.ResourceManager.GetImage("closed_lock");

            EnableButtons(false);

            this.lsvUsers = new UsersListView();
            this.lsvUsers.ContextMenuStrip = this.mnuUsers;
            this.tlpMain.Controls.Add(this.lsvUsers, 0, 1);
            this.lsvUsers.MouseUp += new MouseEventHandler(lsvUsers_MouseUp);
            this.lsvUsers.SelectedIndexChanged += new EventHandler(lsvUsers_SelectedIndexChanged);
        }


        void lsvUsers_MouseUp(object sender, MouseEventArgs e)
        {
            Entities.User user = lsvUsers.SelectedUser;
            if (user == null)
            {
                EnableButtons(false);
            }
            else
            {
                if ((e.Button == MouseButtons.Left) && (e.Clicks == 1))
                {
                    //ListViewHitTestInfo htInfo = lsvUsers.HitTest(e.X, e.Y);
                    EditSelectedUser();
                }
            }
        }


        void lsvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvUsers.SelectedItems.Count != 0)
            {
                Entities.User user = lsvUsers.SelectedUser;
                if (user == null)
                {
                    EnableButtons(false);
                }
                else
                {
                    EnableButtons(true);

                    this.lblLanguageValue.Text = user.Culture.LanguageName;
                    this.lblNameValue.Text = user.Name;
                    this.lblRoleNameValue.Text = user.Role.Name;

                    this.lblIsEnabled.Text = user.IsEnabled ?
                        Resources.Texts.user_is_enabled :
                        Resources.Texts.user_is_disabled;

                    this.lblIsEnabled.ForeColor = user.IsEnabled ?
                        Color.ForestGreen :
                        Color.Red;

                    this.btnEnableUser.Text = user.IsEnabled ?
                        Resources.Texts.disable :
                        Resources.Texts.enable;

                    this.mnuUsers.Items[2].Text = 
                        this.btnEnableUser.Text;

                    this.btnEnableUser.Image = user.IsEnabled ?
                        DomainModel.Application.ResourceManager.GetImage("closed_lock") :
                        DomainModel.Application.ResourceManager.GetImage("lock_unlock");

                    this.mnuUsers.Items[2].Image =
                        this.btnEnableUser.Image;
                }
            }
        }


        private void EnableButtons(bool enable)
        {
            if (!enable)
            {
                this.lblIsEnabled.Text = Resources.Texts.select_user;
                this.lblIsEnabled.ForeColor = Color.Red;
            }

            if (this.lblLanguage.Visible != enable)
            {
                this.btnEnableUser.Enabled = enable;
                this.btnEditUser.Enabled = enable;
                this.btnDeleteUser.Enabled = enable;

                this.lblLanguage.Visible = enable;
                this.lblName.Visible = enable;
                this.lblRoleName.Visible = enable;

                this.lblLanguageValue.Visible = enable;
                this.lblNameValue.Visible = enable;
                this.lblRoleNameValue.Visible = enable;
            }
        }


        #region GUI controls events

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedUser();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedUser();
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleSelectedUserEnableState();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditSelectedUser();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteSelectedUser();
        }

        private void btnEnableUser_Click(object sender, EventArgs e)
        {
            ToggleSelectedUserEnableState();
        }

        #endregion GUI controls events


        private Entities.User FindSelectedUser()
        {
            return this.lsvUsers.SelectedUser;
        }


        private void EditSelectedUser()
        {
            Entities.User user = FindSelectedUser();
            if (user != null)
            {
                this.lsvUsers.StoreSelectedIndex();

                Presentation.Controllers.Users.Edit(user);
                this.lsvUsers.UpdateView();

                this.lsvUsers.RestoreSelectedIndex();
            }
            else
            {
                DomainModel.Application.Status.Update(
                    StatusController.Abstract.StatusTypes.Warning, 
                    "status_select_user");
            }
        } 


        private void DeleteSelectedUser()
        {
            Entities.User user = FindSelectedUser();
            if (user != null)
            {
                this.lsvUsers.StoreSelectedIndex();

                Presentation.Controllers.Users.Delete(user);

                this.lsvUsers.RestoreSelectedIndex();
            }
            else
            {
                DomainModel.Application.Status.Update(
                    StatusController.Abstract.StatusTypes.Warning,
                    "status_select_user");
            }
        }


        private void ToggleSelectedUserEnableState()
        {
            Entities.User user = FindSelectedUser();
            if (user != null)
            {
                Presentation.Controllers.Users.ToggleEnabled(user);
                lsvUsers_SelectedIndexChanged(this.lsvUsers, null);
            }
            else
            {
                DomainModel.Application.Status.Update(
                    StatusController.Abstract.StatusTypes.Warning,
                    "status_select_user");
            }
        }


        private void AddNewUser()
        {
            Presentation.Controllers.Users.AddNew();

            this.lsvUsers.SelectLastItem();
        }
    }
}
