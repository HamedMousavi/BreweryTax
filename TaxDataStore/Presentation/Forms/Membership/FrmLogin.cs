using System;
using System.Windows.Forms;
using Entities;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmLogin : Form
    {
        private FormLabel lblUserName;
        private FormLabel lblPassword;
        private FormLabel lblLogonProcess;
        private System.Windows.Forms.ComboBox cbxUserName;
        private System.Windows.Forms.TextBox tbxPassword;
        private FlatButton btnExit;
        private FlatButton btnLogin;
        private System.Windows.Forms.PictureBox pbxAppIcon;
        private System.Windows.Forms.Label lblAppName;

        private HLayoutPanel tlpMain;
        private HLayoutPanel tlpButtons;

        protected User user { get; set; }


        public FrmLogin()
        {
            InitializeComponent();

            SetupControls();
            SetupBindings();
        }


        private void SetupControls()
        {
            this.lblUserName = new FormLabel("username");
            this.lblPassword = new FormLabel("password");
            this.lblLogonProcess = new FormLabel("logon_process");
            this.lblLogonProcess.Anchor |= AnchorStyles.Right;

            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.cbxUserName = new System.Windows.Forms.ComboBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new FlatButton();
            this.btnLogin = new FlatButton();

            this.pbxAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblAppName.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.UseSystemPasswordChar = true;

            this.lblAppName.AutoSize = true;
            this.tbxPassword.Anchor |= AnchorStyles.Right;
            this.cbxUserName.Anchor |= AnchorStyles.Right;
            this.lblLogonProcess.Margin = new Padding(0, 20, 0, 20);
            this.cbxUserName.FormattingEnabled = true;

            this.AcceptButton = this.btnLogin;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.tlpMain = new HLayoutPanel("tlpMain", 6, 3, 0);
            this.tlpButtons = new HLayoutPanel("tlpButtons", 1, 3, 1);

            this.tlpMain.ColumnStyles[this.tlpMain.ColumnCount - 1] = new ColumnStyle(SizeType.Percent, 100F);
            this.tlpMain.RowStyles[1] = new RowStyle(SizeType.Percent, 100F);

            this.tlpMain.Controls.Add(this.pbxAppIcon, 0, 0);
            this.tlpMain.Controls.Add(this.lblAppName, 1, 0);
            this.tlpMain.Controls.Add(this.lblLogonProcess, 1, 2);
            this.tlpMain.Controls.Add(this.lblUserName, 1, 3);
            this.tlpMain.Controls.Add(this.cbxUserName, 2, 3);
            this.tlpMain.Controls.Add(this.lblPassword, 1, 4);
            this.tlpMain.Controls.Add(this.tbxPassword, 2, 4);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 5);

            this.tlpMain.SetColumnSpan(this.lblAppName, 2);
            this.tlpMain.SetColumnSpan(this.lblLogonProcess, 2);
            this.tlpMain.SetColumnSpan(this.tlpButtons, 3);
            this.tlpMain.SetRowSpan(this.pbxAppIcon, 5);

            this.tlpButtons.Controls.Add(this.btnLogin, 1, 0);
            this.tlpButtons.Controls.Add(this.btnExit, 2, 0);

            this.tlpButtons.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100F);
            this.tlpButtons.Anchor = AnchorStyles.Left | 
                AnchorStyles.Right | AnchorStyles.Bottom;
            this.tlpButtons.AutoSize = true;

            this.Controls.Add(this.tlpMain);

            this.BackColor = System.Drawing.Color.White;
            this.tlpMain.BackColor = this.BackColor;
            this.tlpButtons.BackColor = System.Drawing.Color.WhiteSmoke;

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Resources.Texts.logon;
            this.btnExit.Text = Resources.Texts.exit;
            this.btnLogin.Text = Resources.Texts.login;
            this.lblAppName.Text = Resources.Texts.app_name;

            this.pbxAppIcon.Image = DomainModel.Application.ResourceManager.GetImage("beer_lock");
        }


        private void SetupBindings()
        {
            this.user = new User();

            this.cbxUserName.DataSource = DomainModel.Membership.Users.GetAll();
            this.cbxUserName.DisplayMember = "Name";

            this.cbxUserName.DataBindings.Add(new Binding("Text", this.user, "Name"));
            this.tbxPassword.DataBindings.Add(new Binding("Text", this.user, "Password"));
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = DomainModel.
                Membership.Users.Authenticate(this.user);
            
            if (authenticated)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // UNDONE: update status
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
