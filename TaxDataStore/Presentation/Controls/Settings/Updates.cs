using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls.Settings
{

    public partial class Updates : UserControl
    {

        protected Entities.UpdaterSettings updaterSettings;

        
        public Updates()
        {
            InitializeComponent();

            this.btnSave.Click += new 
                EventHandler(btnSave_Click);

            this.Dock = DockStyle.Fill;
            SetupTexts();
            LoadData();
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
