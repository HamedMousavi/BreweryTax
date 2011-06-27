using System;
using System.Drawing;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class UsersManager : UserControl
    {

        private FormLabel lblRoleName;
        private FormLabel lblLanguage;
        private FormLabel lblName;
        private FormLabel lblIsEnabled;
        private ToolbarLabel lblUsers;
        private ToolbarLabel lblDetails;

        protected UsersListView lsvUsers;


        public UsersManager()
        {
            InitializeComponent();
            CreateControls();
            SetupControls();

            this.Dock = DockStyle.Fill;
        }


        private void CreateControls()
        {
            this.lblRoleName = new FormLabel(0, "lblRoleName", true, "role_name");
            this.lblLanguage = new FormLabel(1, "lblLanguage", true, "language");
            this.lblName = new FormLabel(2, "lblName", true, "name");
            this.lblIsEnabled = new FormLabel(3, "lblIsEnabled", true, "select_user");

            this.lblUsers = new ToolbarLabel(4, "lblUsers", "users");
            this.lblDetails = new ToolbarLabel(5, "lblDetails", "details");

            this.tlpDetails.Controls.Add(this.lblRoleName, 0, 3);
            this.tlpDetails.Controls.Add(this.lblLanguage, 0, 2);
            this.tlpDetails.Controls.Add(this.lblName, 0, 1);
            this.tlpDetails.Controls.Add(this.lblIsEnabled, 0, 0);

            this.tlpButtons.Controls.Add(this.lblUsers, 0, 0);
            this.tlpMain.Controls.Add(this.lblDetails, 1, 0);


            this.lblIsEnabled.ForeColor = Color.Red;
        }


        private void SetupControls()
        {

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
