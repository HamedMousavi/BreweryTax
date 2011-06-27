using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls.Settings
{

    public partial class Updates : UserControl
    {

        private FormLabel lblUpdateSeconds;
        private FormLabel lblUpdateEvery;
        private FormLabel lblUpdateUrl;

        protected Entities.UpdaterSettings updaterSettings;

        
        public Updates()
        {
            InitializeComponent();

            CreateControls();

            this.btnSave.Click += new 
                EventHandler(btnSave_Click);

            this.Dock = DockStyle.Fill;
            SetupTexts();
            LoadData();
        }


        private void CreateControls()
        {
            this.lblUpdateSeconds = new FormLabel(0, "lblUpdateSeconds", true, "lbl_upd_sseconds");
            this.lblUpdateEvery = new FormLabel(1, "lblUpdateEvery", true, "lbl_upd_interval");
            this.lblUpdateUrl = new FormLabel(2, "lblUpdateUrl", true, "lbl_upd_url");

            this.tlpMain.Controls.Add(this.lblUpdateEvery, 0, 2);
            this.tlpMain.Controls.Add(this.lblUpdateSeconds, 2, 2);
            this.tlpMain.Controls.Add(this.lblUpdateUrl, 0, 1);
        }


        void btnSave_Click(object sender, EventArgs e)
        {
            SaveUpdaterSettings();
        }


        private void SetupTexts()
        {

            this.chbxUpdateAutoDownload.Text = Resources.Texts.lbl_upd_auto_download;
            this.chbxToggleAutoUpdate.Text = Resources.Texts.lbl_upd_auto_check;

            this.btnSave.Text = Resources.Texts.save;
        }


        private void LoadData()
        {
            this.updaterSettings = DomainModel.ApplicationUpdater.LoadSettings();
            if (this.updaterSettings != null)
            {
                this.chbxToggleAutoUpdate.Checked = this.updaterSettings.AutoCheckForUpdates;
                this.tbxUpdateUrl.Text = this.updaterSettings.UpdateUri;

                this.tbxUpdateCheckInterval.Text = Convert.ToString(this.updaterSettings.AutoUpdateCheckInterval);
                this.chbxUpdateAutoDownload.Checked = this.updaterSettings.AutoDownloadUpdate;
            }
        }


        private void SaveUpdaterSettings()
        {
            if (this.updaterSettings != null)
            {
                this.updaterSettings.AutoCheckForUpdates = this.chbxToggleAutoUpdate.Checked;
                this.updaterSettings.UpdateUri = this.tbxUpdateUrl.Text;

                this.updaterSettings.AutoUpdateCheckInterval = Convert.ToInt32(this.tbxUpdateCheckInterval.Text);
                this.updaterSettings.AutoDownloadUpdate = this.chbxUpdateAutoDownload.Checked;

                DomainModel.ApplicationUpdater.SaveSettings(this.updaterSettings);

                using (UpdaterService.UpdaterIpcServiceClient sc = new
                    UpdaterService.UpdaterIpcServiceClient())
                {

                    sc.ReloadSettings();

                    sc.Close();
                }
            }
        }

    }
}
