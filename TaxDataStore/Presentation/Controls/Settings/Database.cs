using System.Data.SqlClient;
using System.Windows.Forms;
using System;



namespace TaxDataStore.Presentation.Controls.Settings
{

    public partial class Database : UserControl
    {

        public Database()
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
            SaveSettings();
        }


        private void SetupTexts()
        {
            this.lblDatabaseServerName.Text = Resources.Texts.lbl_db_server;
            this.lblDatabaseTcpPort.Text = Resources.Texts.lbl_db_port;
            this.lblDatabaseUserId.Text = Resources.Texts.lbl_db_srv_user;
            this.lblDatabasePassword.Text = Resources.Texts.lbl_db_password;
            this.lblDatabaseCatalog.Text = Resources.Texts.lbl_db_name;

            this.btnSave.Text = Resources.Texts.save;
        }


        private void LoadData()
        {
            SqlConnectionStringBuilder cnn = new SqlConnectionStringBuilder();
            cnn.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;

            this.tbxDatabaseCatalog.Text = cnn.InitialCatalog;
            this.tbxDatabasePassword.Text = cnn.Password;
            this.tbxDatabaseUserId.Text = cnn.UserID;

            if (!string.IsNullOrWhiteSpace(cnn.DataSource))
            {
                string[] chuncks = cnn.DataSource.Split(',');
                if (chuncks != null && chuncks.Length > 1)
                {
                    this.tbxDatabaseServerName.Text = chuncks[0].Trim();
                    this.tbxDatabaseTcpPort.Text = chuncks[1].Trim();
                }
                else
                {
                    this.tbxDatabaseServerName.Text = cnn.DataSource;
                }
            }
        }


        private void SaveSettings()
        {
            // Database
            SqlConnectionStringBuilder cnn = new SqlConnectionStringBuilder();

            cnn.InitialCatalog = this.tbxDatabaseCatalog.Text;
            cnn.Password = this.tbxDatabasePassword.Text;
            cnn.UserID = this.tbxDatabaseUserId.Text;
            if (!string.IsNullOrWhiteSpace(this.tbxDatabaseTcpPort.Text))
            {
                cnn.DataSource =
                    this.tbxDatabaseServerName.Text +
                    ", " +
                    this.tbxDatabaseTcpPort.Text;
            }
            else
            {
                cnn.DataSource = this.tbxDatabaseServerName.Text;
            }

            Properties.Settings.Default.DatabaseConnectionString = cnn.ConnectionString;

            Properties.Settings.Default.Save();

            DomainModel.Application.Settings.AppSettings =
                Properties.Settings.Default;
        }

    }
}
