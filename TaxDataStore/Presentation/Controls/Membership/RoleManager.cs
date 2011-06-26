using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;
using System;


namespace TaxDataStore
{

    public partial class RoleManager : UserControl
    {
        private FormLabel lblComment;

        protected RolesListView lsvRoles;
        protected Presentation.Controls.TasksCheckedListBox chlbxTasks;


        public RoleManager()
        {
            InitializeComponent();

            CreateControls();
            SetupControls();
        }

        private void CreateControls()
        {
            this.lblComment = new FormLabel(0, "lblComment", false, "select_role");
            this.panelTasks.Controls.Add(this.lblComment);
       }

        
        private void SetupControls()
        {
            this.Dock = DockStyle.Fill;

            this.chlbxTasks = new TasksCheckedListBox();
            this.chlbxTasks.Dock = DockStyle.Fill;
            this.panelTasks.Controls.Add(this.chlbxTasks);

            this.lblRoles.Text = Resources.Texts.roles;
            this.lblTasks.Text = Resources.Texts.tasks;

            this.btnAddRole.Text = Resources.Texts.add;
            this.btnDeleteRole.Text = Resources.Texts.delete;
            this.btnEditRole.Text = Resources.Texts.edit;

            this.btnAddRole.Image = DomainModel.Application.ResourceManager.GetImage("clipboard__plus");
            this.btnDeleteRole.Image = DomainModel.Application.ResourceManager.GetImage("clipboard__minus");
            this.btnEditRole.Image = DomainModel.Application.ResourceManager.GetImage("clipboard__pencil");

            this.mnuRoles.Items[0].Text = Resources.Texts.edit;
            this.mnuRoles.Items[1].Text = Resources.Texts.delete;
            this.mnuRoles.Items[0].Image = DomainModel.Application.ResourceManager.GetImage("clipboard__pencil");
            this.mnuRoles.Items[1].Image = DomainModel.Application.ResourceManager.GetImage("clipboard__minus");

            EnableButtons(false);

            this.lsvRoles = new RolesListView();
            this.lsvRoles.ContextMenuStrip = this.mnuRoles;
            this.tlpMain.Controls.Add(this.lsvRoles, 0, 1);

            this.lsvRoles.MouseUp += new MouseEventHandler(lsvRoles_MouseUp);
            this.lsvRoles.SelectedIndexChanged += new EventHandler(lsvRoles_SelectedIndexChanged);
        }


        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AddNewRole();
        }


        private void btnEditRole_Click(object sender, EventArgs e)
        {
            EditSelectedRole();
        }


        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            DeleteSelectedRole();
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedRole();
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedRole();
        }
        

        void lsvRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvRoles.SelectedItems.Count != 0)
            {
                Entities.Role role = lsvRoles.SelectedRole;
                if (role == null)
                {
                    EnableButtons(false);
                }
                else
                {
                    EnableButtons(true);

                    this.chlbxTasks.Role = role;
                    this.chlbxTasks.UpdateBinding();
                }
            }
        }


        void lsvRoles_MouseUp(object sender, MouseEventArgs e)
        {
            Entities.Role role = lsvRoles.SelectedRole;
            if (role == null)
            {
                EnableButtons(false);
            }
            else
            {
                if ((e.Button == MouseButtons.Left) && (e.Clicks == 1))
                {
                    //ListViewHitTestInfo htInfo = lsvUsers.HitTest(e.X, e.Y);
                    EditSelectedRole();
                }
            }
        }


        private void EnableButtons(bool enable)
        {
            if (this.btnEditRole.Enabled != enable)
            {
                this.btnEditRole.Enabled = enable;
                this.btnDeleteRole.Enabled = enable;

                this.chlbxTasks.Visible = enable;
                this.lblComment.Visible = !enable;
            }
        }


        private void AddNewRole()
        {
            Presentation.Controllers.Roles.AddNew();

            this.lsvRoles.SelectLastItem();
        }


        private void EditSelectedRole()
        {
            Entities.Role role = lsvRoles.SelectedRole;
            if (role != null)
            {
                this.lsvRoles.StoreSelectedIndex();

                Presentation.Controllers.Roles.Edit(role);
                this.lsvRoles.UpdateView();

                this.lsvRoles.RestoreSelectedIndex();
            }
            else
            {
                DomainModel.Application.Status.Update(
                    StatusController.Abstract.StatusTypes.Warning,
                    "status_select_user");
            }
        }


        private void DeleteSelectedRole()
        {
            Entities.Role role = lsvRoles.SelectedRole;
            if (role != null)
            {
                this.lsvRoles.StoreSelectedIndex();

                Presentation.Controllers.Roles.Delete(role);
                lsvRoles_SelectedIndexChanged(this.lsvRoles, null);

                this.lsvRoles.RestoreSelectedIndex();
            }
            else
            {
                DomainModel.Application.Status.Update(
                    StatusController.Abstract.StatusTypes.Warning,
                    "status_select_user");
            }
        }
    }
}
