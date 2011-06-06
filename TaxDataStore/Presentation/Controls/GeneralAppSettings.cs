using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TaxDataStore

{
    public partial class GeneralAppSettings : UserControl
    {

        public GeneralAppSettings()
        {
            InitializeComponent();

            LoadData();
        }


        private void LoadData()
        {
            SqlConnectionStringBuilder cnn = new SqlConnectionStringBuilder();
            cnn.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;

            this.tbxDatabaseCatalog.Text = cnn.InitialCatalog;
            this.tbxDatabasePassword.Text = cnn.Password;
            this.tbxDatabaseUserId.Text = cnn.UserID;
            if (!string.IsNullOrEmpty(cnn.DataSource))
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Database
            SqlConnectionStringBuilder cnn = new SqlConnectionStringBuilder();

            cnn.InitialCatalog = this.tbxDatabaseCatalog.Text;
            cnn.Password = this.tbxDatabasePassword.Text;
            cnn.UserID = this.tbxDatabaseUserId.Text;
            if (!string.IsNullOrEmpty(this.tbxDatabaseTcpPort.Text))
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
