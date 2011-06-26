using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StatusController.Abstract;
using System.ComponentModel;


namespace TaxDataStore.Presentation.Controls
{

    public class Statusbar : StatusStrip, IStatusObserver
    {

        private ToolStripStatusLabel label;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblAppUpdate;

        private List<Image> images;
        private List<Color> colors;
        private System.Windows.Forms.Timer backColorTimer;
        private StatusTypes currentState;
        protected AsyncCalls asyncHelper;
        protected AsyncCalls appUpdAsyncHelper;


        public Statusbar(StatusController.Controller.StatusController controller)
        {
            this.RightToLeft = View.LayoutDirection;
            this.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            this.AutoSize = false;
            this.Dock = System.Windows.Forms.DockStyle.Bottom;
            
            this.asyncHelper = new AsyncCalls();
            this.currentState = StatusTypes.Info;

            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.ToolBarBackColor;
                this.ForeColor = Presentation.View.Theme.ToolBarForeColor;
                this.Font = Presentation.View.Theme.FormLabelFont;
            }
            else
            {
                this.ForeColor = Color.Black;
                this.Font = new Font("Tahoma", 9, FontStyle.Bold);
            }

            SetupLabel();

            LoadImages();
            LoadColors();
            SetupTimer();

            controller.RegisterForEvents(this);

            this.appUpdAsyncHelper = new AsyncCalls();
            AppUpdateController.UpdateInfo.PropertyChanged += new
                PropertyChangedEventHandler(UpdateInfo_PropertyChanged);
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
            if (!this.appUpdAsyncHelper.Execute(
                this, new RefreshAppUpdaterStatusDelegate(RefreshAppUpdaterStatus))) return;
            if (this.InvokeRequired) return;
            if (!this.Visible) return;

            if (AppUpdateController.UpdateInfo.DownloadIsComplete)
            {
                this.lblAppUpdate.Image = DomainModel.Application.ResourceManager.GetImage("flag_red");
                this.lblAppUpdate.ToolTipText = Resources.Texts.stat_upd_ready_to_install;
            }
            else if (AppUpdateController.UpdateInfo.UpdateExists)
            {
                this.lblAppUpdate.Image = DomainModel.Application.ResourceManager.GetImage("flag_red");
                this.lblAppUpdate.ToolTipText = Resources.Texts.stat_upd_exists;
            }

            else
            {
                this.lblAppUpdate.Image = DomainModel.Application.ResourceManager.GetImage("flag_green");
                this.lblAppUpdate.ToolTipText = Resources.Texts.stat_upd_up_to_date;
            }
        }

        private void SetupTimer()
        {
            this.backColorTimer = new Timer();
            this.backColorTimer.Interval = 700;
            this.backColorTimer.Tick += new EventHandler(backColorTimer_Tick);
        }


        void backColorTimer_Tick(object sender, EventArgs e)
        {

            if (this.BackColor != this.colors[(int)StatusTypes.Info])
            {
                lock (this)
                {
                    this.BackColor = this.colors[(int)StatusTypes.Info];
                }
            }
            
            if (this.label.ForeColor != this.ForeColor)
            {
                lock (this)
                {
                    this.label.ForeColor = this.ForeColor;
                }
            }
            
        }


        private void SetupLabel()
        {
            this.label = new ToolStripStatusLabel();
            this.label.Name = "status_caption";
            this.label.RightToLeft = View.LayoutDirection;
            this.label.Spring = true;
            this.label.TextAlign = ContentAlignment.MiddleLeft;
            this.label.Anchor = AnchorStyles.Left;
            this.label.BorderSides = ToolStripStatusLabelBorderSides.None;
            this.label.ImageAlign = ContentAlignment.MiddleLeft;
            this.Items.Add(this.label);

            this.lblUser = new ToolStripStatusLabel();
            this.lblUser.Name = "status_user";
            this.lblUser.RightToLeft = View.LayoutDirection;
            this.lblUser.Text = DomainModel.Application.User.Name;
            this.lblUser.Image = DomainModel.Application.ResourceManager.GetImage("user_black_female");
            this.Items.Add(this.lblUser);

            this.lblAppUpdate = new ToolStripStatusLabel();
            this.lblAppUpdate.Name = "status_app_update";
            this.lblAppUpdate.RightToLeft = View.LayoutDirection;
            this.lblAppUpdate.Image = DomainModel.Application.ResourceManager.GetImage("flag_green");
            this.lblAppUpdate.ToolTipText = Resources.Texts.stat_upd_up_to_date;
            this.lblAppUpdate.AutoToolTip = false;
            this.lblAppUpdate.Click += new EventHandler(lblAppUpdate_Click);
            this.Items.Add(this.lblAppUpdate);

            this.label.ForeColor = this.ForeColor;
            this.lblUser.ForeColor = this.ForeColor;
            this.label.Font = this.Font;
            this.lblUser.Font = this.Font;
            this.ShowItemToolTips = true;
        }


        void lblAppUpdate_Click(object sender, EventArgs e)
        {
            if (AppUpdateController.UpdateInfo.DownloadIsComplete)
            {
                // UNDONE
                //DomainModel.Application.Status.Update(StatusTypes.Warning, "stat_upd_exists");
            }
            else if (AppUpdateController.UpdateInfo.UpdateExists)
            {
                this.lblAppUpdate.Image = DomainModel.Application.ResourceManager.GetImage("flag_green");
                this.lblAppUpdate.ToolTipText = Resources.Texts.stat_upd_downloading;
                AppUpdateController.DownloadUpdates();
                //DomainModel.Application.Status.Update(StatusTypes.Warning, "stat_upd_ready_to_install");
            }
            else
            {
                DomainModel.Application.Status.Update(StatusTypes.Success, "stat_upd_up_to_date");
            }
        }


        private void LoadImages()
        {
            this.images = new List<Image>();

            this.images.Add(DomainModel.Application.ResourceManager.GetImage(
                StatusTypes.Error.ToString()));

            this.images.Add(DomainModel.Application.ResourceManager.GetImage(
                StatusTypes.Success.ToString()));

            this.images.Add(DomainModel.Application.ResourceManager.GetImage(
                StatusTypes.Warning.ToString()));

            this.images.Add(DomainModel.Application.ResourceManager.GetImage(
                StatusTypes.Info.ToString()));
        }


        private void LoadColors()
        {
            this.colors = new List<Color>();

            this.colors.Add(Color.Red);
            this.colors.Add(Color.Green);
            this.colors.Add(Color.Orange);
            this.colors.Add(this.BackColor);
        }


        private delegate void SetStatusDelegate(IStatus status);
        private void SetStatus(IStatus status)
        {
            this.backColorTimer.Stop();

            // Delay important messages
            if ((this.currentState == StatusTypes.Error ||
                this.currentState == StatusTypes.Warning) &&
                (status.Type == StatusTypes.Info ||
                status.Type == StatusTypes.Success))
            {
                System.Threading.Thread.Sleep(1000);
            }

            // Ensure inside UI thread
            if (!this.asyncHelper.Execute(
                this, new SetStatusDelegate(SetStatus), status)) return;

            if (this.InvokeRequired) return;

            lock (this)
            {
                this.currentState = status.Type;

                int imageIndex = (int)status.Type;

                if (this.images.Count > imageIndex)
                {
                    this.label.Image = this.images[imageIndex];
                }
                else
                {
                    this.label.Image = null;
                }

                if (this.colors.Count > imageIndex)
                {
                    this.BackColor = this.colors[imageIndex];
                }

                this.label.Text = status.Message;

                if (status.Type == StatusTypes.Info ||
                    status.Type == StatusTypes.Warning)
                {
                    this.label.ForeColor = this.ForeColor;
                }
                else
                {
                    this.label.ForeColor = Color.White;
                }
            }

            this.backColorTimer.Start();
        }


        #region IStatusObserver Members

        public void OnStatusChanged(IStatus newState)
        {
            SetStatus(newState);
        }

        #endregion


    }
}
