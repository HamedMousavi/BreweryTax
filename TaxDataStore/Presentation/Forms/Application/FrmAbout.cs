using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;
using System.ComponentModel;
using TaxDataStore.Presentation;


namespace TaxDataStore
{

    public partial class FrmAbout : BaseForm
    {

        private FormLabel lblAppName;
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
            this.lblAppName = new FormLabel(0, "lblAppName", false, "");
            this.lblRegistrationCaption = new FormLabel(1, "lblRegistrationCaption", false, "");
            this.lblCopyright = new FormLabel(2, "lblCopyright", false, "");
            this.lblSupportCaption = new FormLabel(3, "lblSupportCaption", false, "");
            this.lblUpdateStateCaption = new FormLabel(4, "lblUpdateStateCaption", false, "");
            this.lblVersionCaption = new FormLabel(5, "lblVersionCaption", false, "");
            this.lblLastUpdateCheckCaption = new FormLabel(6, "lblLastUpdateCheckCaption", false, "");

            this.tlpUpdates.Controls.Add(this.lblVersionCaption, 0, 1);
            this.tlpUpdates.Controls.Add(this.lblLastUpdateCheckCaption, 0, 3);
            this.tlpControls.Controls.Add(this.lblAppName, 0, 0);
            this.tlpUpdates.Controls.Add(this.lblUpdateStateCaption, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSupportCaption, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRegistrationCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCopyright, 2, 1);
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

            this.tbxVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            this.pbxAppIcon.Image = DomainModel.Application.ResourceManager.GetImage("beer");
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
                this.tbxLastUpdateCheck.Text = string.Empty;
            }
            else
            {
                this.tbxLastUpdateCheck.Text = time.Value.ToLocalTime().ToString("HH:mm");
            }

            if (updateExists)
            {
                this.tbxNewVersionState.Text = Resources.Texts.new_version_exists;
                this.tbxNewVersionDetails.Text = details;

                this.tlpUpdates.Controls.Remove(this.btnInstallUpdate);
                this.tlpUpdates.Controls.Add(this.btnDownloadUpdate, 2, 4);
            }
            else
            {
                this.tbxNewVersionState.Text = Resources.Texts.program_is_up_to_date;
                this.tbxNewVersionDetails.Text = string.Empty;
            }

            if (downloadIsComplete)
            {
                this.tbxNewVersionState.Text = Resources.Texts.new_version_is_ready_to_install;

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
