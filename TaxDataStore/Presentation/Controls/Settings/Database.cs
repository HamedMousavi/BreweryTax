using System;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace TaxDataStore.Presentation.Controls.Settings
{

    public partial class Database : UserControl
    {
        private FormLabel lblDatabaseServerName;
        private FormLabel lblDatabaseTcpPort;
        private FormLabel lblDatabaseUserId;
        private FormLabel lblDatabasePassword;
        private FormLabel lblDatabaseCatalog;

        public Database()
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
            this.lblDatabaseServerName = new FormLabel(0, "lblDatabaseServerName", true, "lbl_db_server");
            this.lblDatabaseTcpPort = new FormLabel(1, "lblDatabaseTcpPort", true, "lbl_db_port");
            this.lblDatabaseUserId = new FormLabel(2, "lblDatabaseUserId", true, "lbl_db_srv_user");
            this.lblDatabasePassword = new FormLabel(3, "lblDatabasePassword", true, "lbl_db_password");
            this.lblDatabaseCatalog = new FormLabel(4, "lblDatabaseCatalog", true, "lbl_db_name");

            this.tlpMain.Controls.Add(this.lblDatabaseServerName, 0, 1);
            this.tlpMain.Controls.Add(this.lblDatabaseTcpPort, 0, 2);
            this.tlpMain.Controls.Add(this.lblDatabaseUserId, 0, 3);
            this.tlpMain.Controls.Add(this.lblDatabasePassword, 0, 4);
            this.tlpMain.Controls.Add(this.lblDatabaseCatalog, 0, 5);
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
