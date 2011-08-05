using System;
using System.ComponentModel;
using System.Windows.Forms;
using TaxDataStore.Presentation;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmAbout : BaseForm
    {

        private System.Windows.Forms.Label lblAppName;
        private FormLabel lblCopyright;
        private FormLabel lblRegistrationCaption;
        private FormLabel lblVersionCaption;
        private FormLabel lblUpdateStateCaption;
        private FormLabel lblLastUpdateCheckCaption;
        private FormLabel lblSupportCaption;

        protected AsyncCalls asyncHelper;


        public FrmAbout()
        {
            InitializeComponent();
            CreateControls();
            SetupTexts();

            this.tlpUpdates.Visible = false;

            this.asyncHelper = new AsyncCalls();

            AppUpdateController.UpdateInfo.PropertyChanged += new 
                PropertyChangedEventHandler(UpdateInfo_PropertyChanged);

            UpdateData();
        }


        void UpdateInfo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (this.Visible)
            {
                UpdateData();
            }
        }


        private void CreateControls()
        {
            // 
            // lblAppName
            // 
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(3, 216);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(194, 39);
            this.lblAppName.TabIndex = 4;
            this.lblAppName.Text = "Settlement";
            // 

            this.lblRegistrationCaption = new FormLabel(1, "lblRegistrationCaption", true, "");
            this.lblCopyright = new FormLabel(2, "lblCopyright", true, "");
            this.lblSupportCaption = new FormLabel(3, "lblSupportCaption", true, "");
            this.lblUpdateStateCaption = new FormLabel(4, "lblUpdateStateCaption", true, "");
            this.lblVersionCaption = new FormLabel(5, "lblVersionCaption", true, "");
            this.lblLastUpdateCheckCaption = new FormLabel(6, "lblLastUpdateCheckCaption", true, "");

            this.tlpUpdates.Controls.Add(this.lblVersionCaption, 0, 1);
            this.tlpUpdates.Controls.Add(this.lblLastUpdateCheckCaption, 0, 3);
            this.tlpControls.Controls.Add(this.lblAppName, 0, 0);
            this.tlpUpdates.Controls.Add(this.lblUpdateStateCaption, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSupportCaption, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRegistrationCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCopyright, 2, 1);

            this.tlpMain.BackColor = System.Drawing.Color.White;
        }


        private void SetupTexts()
        {
            this.lblAppName.Text = Resources.Texts.app_name;
            this.lblCopyright.Text = Resources.Texts.app_copyright;
            this.lblRegistrationCaption.Text = Resources.Texts.lbl_registered_to;
            this.lblSupportCaption.Text = Resources.Texts.lbl_produced_by;
            this.lblVersionCaption.Text = Resources.Texts.lbl_current_version;
            this.lblUpdateStateCaption.Text = Resources.Texts.lbl_update_state;
            this.lblLastUpdateCheckCaption.Text = Resources.Texts.lbl_last_update_check;

            this.gpxUpdates.Text = Resources.Texts.gpx_updates;

            this.btnCheckNow.Text = Resources.Texts.update_check_now;
            this.btnDownloadUpdate.Text = Resources.Texts.update_download_now;
            this.btnInstallUpdate.Text = Resources.Texts.update_install_now;
            this.btnUnInstallService.Text = Resources.Texts.update_remove_service;
            this.btnInstallService.Text = Resources.Texts.update_install_service;

            this.lblVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            this.pbxAppIcon.Image = DomainModel.Application.ResourceManager.GetImage("app_big");
        }


        private delegate void UpdateDataDelegate();
        private void UpdateData()
        {
            // Ensure inside UI thread
            if (!this.asyncHelper.Execute(
                this, new UpdateDataDelegate(UpdateData))) return;
            if (this.InvokeRequired) return;

            this.tlpUpdates.Controls.Remove(this.btnInstallService);
            this.tlpUpdates.Controls.Add(this.btnUnInstallService, 2, 2);
            
            if (this.tlpUpdates.Visible == false)
            {
                this.tlpUpdates.Visible = true;
            }

            this.btnCheckNow.Visible = true;

            DateTime? time = AppUpdateController.UpdateInfo.LastCheckTime;
            bool updateExists = AppUpdateController.UpdateInfo.UpdateExists;
            bool downloadIsComplete = AppUpdateController.UpdateInfo.DownloadIsComplete;
            string details = AppUpdateController.UpdateInfo.Details;

            this.btnDownloadUpdate.Visible = updateExists & !downloadIsComplete;
            this.btnInstallUpdate.Visible = downloadIsComplete;

            if (time == null || !time.HasValue)
            {
                this.lblLastUpdateCheck.Text = string.Empty;
            }
            else
            {
                this.lblLastUpdateCheck.Text = time.Value.ToLocalTime().ToString("HH:mm");
            }

            if (updateExists)
            {
                this.lblNewVersionState.Text = Resources.Texts.new_version_exists;
                this.lblNewVersionDetails.Text = details;

                this.tlpUpdates.Controls.Remove(this.btnInstallUpdate);
                this.tlpUpdates.Controls.Add(this.btnDownloadUpdate, 2, 4);
            }
            else
            {
                this.lblNewVersionState.Text = Resources.Texts.program_is_up_to_date;
                this.lblNewVersionDetails.Text = string.Empty;
            }

            if (downloadIsComplete)
            {
                this.lblNewVersionState.Text = Resources.Texts.new_version_is_ready_to_install;

                this.tlpUpdates.Controls.Remove(this.btnDownloadUpdate);
                this.tlpUpdates.Controls.Add(this.btnInstallUpdate, 2, 4);
            }
        }


        private void btnCheckNow_Click(object sender, EventArgs e)
        {
            AppUpdateController.CheckForUpdates();
        }


        private void btnDownloadUpdate_Click(object sender, EventArgs e)
        {
            AppUpdateController.DownloadUpdates();
        }


        private void btnInstallUpdate_Click(object sender, EventArgs e)
        {
            if (Presentation.Controllers.MessageBox.ConfirmUpdate())
            {
                AppUpdateController.ApplyUpdates();
                Application.Exit();
            }
        }
    }
}
