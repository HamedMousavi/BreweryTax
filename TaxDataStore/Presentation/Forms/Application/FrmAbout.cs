﻿using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


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


        Timer tmrUpdateState;


        public FrmAbout()
        {
            InitializeComponent();
            CreateControls();
            SetupTexts();

            this.tlpUpdates.Visible = false;

            this.tmrUpdateState = new Timer();
            this.tmrUpdateState.Interval = 1000;
            this.tmrUpdateState.Tick += new EventHandler(tmrUpdateState_Tick);
            this.tmrUpdateState.Start();
        }


        private void CreateControls()
        {
            this.lblAppName = new FormLabel(0, "lblAppName", false, "");
            this.lblRegistrationCaption = new FormLabel(0, "lblRegistrationCaption", false, "");
            this.lblCopyright = new FormLabel(0, "lblCopyright", false, "");
            this.lblSupportCaption = new FormLabel(0, "lblSupportCaption", false, "");
            this.lblUpdateStateCaption = new FormLabel(0, "lblUpdateStateCaption", false, "");
            this.lblVersionCaption = new FormLabel(0, "lblVersionCaption", false, "");
            this.lblLastUpdateCheckCaption = new FormLabel(0, "lblLastUpdateCheckCaption", false, "");

            this.tlpUpdates.Controls.Add(this.lblVersionCaption, 0, 1);
            this.tlpUpdates.Controls.Add(this.lblLastUpdateCheckCaption, 0, 3);
            this.tlpControls.Controls.Add(this.lblAppName, 0, 0);
            this.tlpUpdates.Controls.Add(this.lblUpdateStateCaption, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSupportCaption, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRegistrationCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCopyright, 2, 1);
        }


        void tmrUpdateState_Tick(object sender, EventArgs e)
        {
            try
            {
                this.tmrUpdateState.Stop();

                if (this.tlpUpdates.Visible == false)
                {
                    this.tlpUpdates.Visible = true;
                }

                UpdateData();
                this.tmrUpdateState.Start();
            }
            catch (Exception ex)
            {
                // UNDONE: Report error
            }
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


        private void UpdateData()
        {
            //if (TaxDataStoreUpdater.ServiceInterface.ServiceExists)
            //{
            this.tlpUpdates.Controls.Remove(this.btnInstallService);
            this.tlpUpdates.Controls.Add(this.btnUnInstallService, 2, 2);

            bool updaterIsRunning = true;
            if (updaterIsRunning)
            {
                this.btnCheckNow.Visible = true;

                UpdaterService.UpdaterIpcServiceClient sc = new
                    UpdaterService.UpdaterIpcServiceClient();

                DateTime? time = sc.GetLastCheckTimestamp();
                bool updateExists = sc.UpdateExists();
                bool downloadIsComplete = sc.IsDownloadComplete();
                string details = sc.GetNewVersionDetails();
                sc.Close();

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

        }

        /*
        private void btnInstallService_Click(object sender, EventArgs e)
        {
            if (TaxDataStoreUpdater.ServiceInterface.ServiceExists)
            {
                return;
            }

            TaxDataStoreUpdater.ServiceInterface.Install();

            if (TaxDataStoreUpdater.ServiceInterface.ServiceExists)
            {
                if (!TaxDataStoreUpdater.ServiceInterface.ServiceIsRunning)
                {
                    TaxDataStoreUpdater.ServiceInterface.Start();
                }
            }
        }


        private void btnUnInstallService_Click(object sender, EventArgs e)
        {
            if (!TaxDataStoreUpdater.ServiceInterface.ServiceExists)
            {
                return;
            }

            TaxDataStoreUpdater.ServiceInterface.UnInstall();
        }
        */

        private void btnCheckNow_Click(object sender, EventArgs e)
        {
            UpdaterService.UpdaterIpcServiceClient sc = new
                UpdaterService.UpdaterIpcServiceClient();

            sc.CheckForUpdates();

            sc.Close();
        }


        private void btnDownloadUpdate_Click(object sender, EventArgs e)
        {
            UpdaterService.UpdaterIpcServiceClient sc = new
                UpdaterService.UpdaterIpcServiceClient();

            sc.DownloadUpdates();

            sc.Close();
        }


        private void btnInstallUpdate_Click(object sender, EventArgs e)
        {
            if (Presentation.Controllers.MessageBox.ConfirmUpdate())
            {
                UpdaterService.UpdaterIpcServiceClient sc = new
                    UpdaterService.UpdaterIpcServiceClient();

                sc.ApplyUpdates();

                sc.Close();

                Application.Exit();
            }
        }
    }
}
