using System;
using System.ComponentModel;
using System.Windows.Forms;
using StatusController.Abstract;
using System.Drawing;


namespace TaxDataStore.Presentation.Controls
{

    public class StatusLabelAppUpdate : ToolStripStatusLabel
    {

        protected ContextMenuStrip menu;
        protected AsyncCalls asyncHelper;


        public StatusLabelAppUpdate()
        {
            this.asyncHelper = new AsyncCalls();

            this.Name = "status_app_update";
            this.RightToLeft = View.LayoutDirection;
            this.Image = DomainModel.Application.ResourceManager.GetImage("flag_green");
            this.ToolTipText = Resources.Texts.stat_upd_up_to_date;
            this.AutoToolTip = false;

            this.menu = new ContextMenuStrip();
            this.menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);

            //this.menu.

            AppUpdateController.UpdateInfo.PropertyChanged += new
                PropertyChangedEventHandler(UpdateInfo_PropertyChanged);

            this.MouseUp += new MouseEventHandler(StatusLabelAppUpdate_MouseUp);
        }


        void UpdateInfo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, "UpdateExists", StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "DownloadIsComplete", StringComparison.InvariantCulture))
            {
                RefreshAppUpdaterStatus();
            }
        }


        private delegate void RefreshAppUpdaterStatusDelegate();
        private void RefreshAppUpdaterStatus()
        {
            // Ensure inside UI thread
            if (!this.asyncHelper.Execute(
                this.Owner, new RefreshAppUpdaterStatusDelegate(RefreshAppUpdaterStatus))) return;
            if (this.Owner.InvokeRequired) return;

            if (!this.Visible) return;

            if (AppUpdateController.UpdateInfo.DownloadIsComplete)
            {
                this.Image = DomainModel.Application.ResourceManager.GetImage("flag_red");
                this.ToolTipText = Resources.Texts.stat_upd_ready_to_install;
            }
            else if (AppUpdateController.UpdateInfo.UpdateExists)
            {
                this.Image = DomainModel.Application.ResourceManager.GetImage("flag_red");
                this.ToolTipText = Resources.Texts.stat_upd_exists;
            }

            else
            {
                this.Image = DomainModel.Application.ResourceManager.GetImage("flag_green");
                this.ToolTipText = Resources.Texts.stat_upd_up_to_date;
            }
        }


        void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.menu.Hide();
            this.Image = DomainModel.Application.ResourceManager.GetImage("flag_yellow");

            if (AppUpdateController.UpdateInfo.DownloadIsComplete)
            {
                if (Presentation.Controllers.MessageBox.ConfirmRestart())
                {
                this.ToolTipText = Resources.Texts.stat_upd_applying;
                    AppUpdateController.ApplyUpdates();
                    Application.Exit();
                }
            }
            else if (AppUpdateController.UpdateInfo.UpdateExists)
            {
                this.ToolTipText = Resources.Texts.stat_upd_downloading;
                AppUpdateController.DownloadUpdates();
            }
            else
            {
                this.ToolTipText = Resources.Texts.stat_upd_checking;
                AppUpdateController.CheckForUpdates();
            }
        }


        void StatusLabelAppUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            this.menu.Hide();
            this.menu.Items.Clear();

            if (AppUpdateController.UpdateInfo.DownloadIsComplete)
            {
                this.menu.Items.Add(Resources.Texts.mnu_upd_install);
            }
            else if (AppUpdateController.UpdateInfo.UpdateExists)
            {
                this.menu.Items.Add(Resources.Texts.mnu_upd_update);
            }
            else
            {
                this.menu.Items.Add(Resources.Texts.mnu_upd_check_now);
            }

            Point pt = e.Location; 
            pt.Offset(this.Bounds.Location);
            pt = this.Owner.PointToScreen(pt);

            this.menu.Show(pt, ToolStripDropDownDirection.AboveLeft);
        }
    }
}
