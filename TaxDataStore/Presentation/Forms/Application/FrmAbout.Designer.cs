using TaxDataStore.Presentation.Controls;

namespace TaxDataStore
{
    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.lblAppName = new FormLabel("");
            this.lblRegistrationCaption = new FormLabel("");
            this.lblCopyright = new FormLabel("");
            this.lblSupportCaption = new FormLabel("");
            this.lblUpdateStateCaption = new FormLabel("");
            this.lblVersionCaption = new FormLabel("");
            this.lblLastUpdateCheckCaption = new FormLabel("");
            this.gpxUpdates = new System.Windows.Forms.GroupBox();
            this.tlpUpdates = new System.Windows.Forms.TableLayoutPanel();
            this.btnCheckNow = new ButtonBase();
            this.btnUnInstallService = new ButtonBase();
            this.btnInstallUpdate = new ButtonBase();
            this.btnDownloadUpdate = new ButtonBase();
            this.tbxVersion = new System.Windows.Forms.TextBox();
            this.tbxLastUpdateCheck = new System.Windows.Forms.TextBox();
            this.tbxNewVersionState = new System.Windows.Forms.TextBox();
            this.tbxNewVersionDetails = new System.Windows.Forms.TextBox();
            this.btnInstallService = new ButtonBase();
            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxOwner = new System.Windows.Forms.TextBox();
            this.lbtnProducer = new System.Windows.Forms.LinkLabel();
            this.tlpMain.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.gpxUpdates.SuspendLayout();
            this.tlpUpdates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpMain.Controls.Add(this.tlpControls, 1, 0);
            this.tlpMain.Controls.Add(this.pbxAppIcon, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMain.Size = new System.Drawing.Size(558, 364);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 2;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Controls.Add(this.lblAppName, 0, 0);
            this.tlpControls.Controls.Add(this.gpxUpdates, 0, 1);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(142, 3);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 6;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControls.Size = new System.Drawing.Size(413, 303);
            this.tlpControls.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.tlpControls.SetColumnSpan(this.lblAppName, 2);
            this.lblAppName.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(3, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(194, 39);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Settlement";
            // 
            // gpxUpdates
            // 
            this.tlpControls.SetColumnSpan(this.gpxUpdates, 2);
            this.gpxUpdates.Controls.Add(this.tlpUpdates);
            this.gpxUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxUpdates.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxUpdates.Location = new System.Drawing.Point(3, 42);
            this.gpxUpdates.Name = "gpxUpdates";
            this.gpxUpdates.Size = new System.Drawing.Size(407, 258);
            this.gpxUpdates.TabIndex = 4;
            this.gpxUpdates.TabStop = false;
            this.gpxUpdates.Text = "Updates";
            // 
            // tlpUpdates
            // 
            this.tlpUpdates.ColumnCount = 3;
            this.tlpUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUpdates.Controls.Add(this.lblVersionCaption, 0, 1);
            this.tlpUpdates.Controls.Add(this.lblLastUpdateCheckCaption, 0, 3);
            this.tlpUpdates.Controls.Add(this.btnCheckNow, 2, 3);
            this.tlpUpdates.Controls.Add(this.lblUpdateStateCaption, 0, 4);
            this.tlpUpdates.Controls.Add(this.btnUnInstallService, 2, 2);
            this.tlpUpdates.Controls.Add(this.btnInstallUpdate, 2, 5);
            this.tlpUpdates.Controls.Add(this.btnDownloadUpdate, 2, 4);
            this.tlpUpdates.Controls.Add(this.tbxVersion, 1, 1);
            this.tlpUpdates.Controls.Add(this.tbxLastUpdateCheck, 1, 3);
            this.tlpUpdates.Controls.Add(this.tbxNewVersionState, 1, 4);
            this.tlpUpdates.Controls.Add(this.tbxNewVersionDetails, 1, 5);
            this.tlpUpdates.Controls.Add(this.btnInstallService, 2, 1);
            this.tlpUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUpdates.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpUpdates.Location = new System.Drawing.Point(3, 17);
            this.tlpUpdates.Name = "tlpUpdates";
            this.tlpUpdates.RowCount = 6;
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUpdates.Size = new System.Drawing.Size(401, 238);
            this.tlpUpdates.TabIndex = 0;
            // 
            // lblVersionCaption
            // 
            this.lblVersionCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersionCaption.AutoSize = true;
            this.lblVersionCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVersionCaption.ForeColor = System.Drawing.Color.Gray;
            this.lblVersionCaption.Location = new System.Drawing.Point(3, 10);
            this.lblVersionCaption.Name = "lblVersionCaption";
            this.lblVersionCaption.Size = new System.Drawing.Size(49, 29);
            this.lblVersionCaption.TabIndex = 0;
            this.lblVersionCaption.Text = "Version";
            this.lblVersionCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastUpdateCheckCaption
            // 
            this.lblLastUpdateCheckCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastUpdateCheckCaption.AutoSize = true;
            this.lblLastUpdateCheckCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastUpdateCheckCaption.ForeColor = System.Drawing.Color.Gray;
            this.lblLastUpdateCheckCaption.Location = new System.Drawing.Point(3, 68);
            this.lblLastUpdateCheckCaption.Name = "lblLastUpdateCheckCaption";
            this.lblLastUpdateCheckCaption.Size = new System.Drawing.Size(96, 29);
            this.lblLastUpdateCheckCaption.TabIndex = 2;
            this.lblLastUpdateCheckCaption.Text = "Last check time";
            this.lblLastUpdateCheckCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(152)))), ((int)(((byte)(54)))));
            this.btnCheckNow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(136)))), ((int)(((byte)(38)))));
            this.btnCheckNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckNow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCheckNow.ForeColor = System.Drawing.Color.White;
            this.btnCheckNow.Location = new System.Drawing.Point(260, 71);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(138, 23);
            this.btnCheckNow.TabIndex = 3;
            this.btnCheckNow.Text = "Check now";
            this.btnCheckNow.UseVisualStyleBackColor = false;
            this.btnCheckNow.Click += new System.EventHandler(this.btnCheckNow_Click);
            // 
            // lblUpdateStateCaption
            // 
            this.lblUpdateStateCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdateStateCaption.AutoSize = true;
            this.lblUpdateStateCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUpdateStateCaption.ForeColor = System.Drawing.Color.Gray;
            this.lblUpdateStateCaption.Location = new System.Drawing.Point(3, 97);
            this.lblUpdateStateCaption.Name = "lblUpdateStateCaption";
            this.lblUpdateStateCaption.Size = new System.Drawing.Size(71, 29);
            this.lblUpdateStateCaption.TabIndex = 4;
            this.lblUpdateStateCaption.Text = "NewUpdate";
            this.lblUpdateStateCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUnInstallService
            // 
            this.btnUnInstallService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(152)))), ((int)(((byte)(54)))));
            this.btnUnInstallService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(136)))), ((int)(((byte)(38)))));
            this.btnUnInstallService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnInstallService.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnInstallService.ForeColor = System.Drawing.Color.White;
            this.btnUnInstallService.Location = new System.Drawing.Point(260, 42);
            this.btnUnInstallService.Name = "btnUnInstallService";
            this.btnUnInstallService.Size = new System.Drawing.Size(138, 23);
            this.btnUnInstallService.TabIndex = 7;
            this.btnUnInstallService.Text = "UnInstall";
            this.btnUnInstallService.UseVisualStyleBackColor = false;
            this.btnUnInstallService.Visible = false;
            // 
            // btnInstallUpdate
            // 
            this.btnInstallUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(152)))), ((int)(((byte)(54)))));
            this.btnInstallUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(136)))), ((int)(((byte)(38)))));
            this.btnInstallUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInstallUpdate.ForeColor = System.Drawing.Color.White;
            this.btnInstallUpdate.Location = new System.Drawing.Point(260, 129);
            this.btnInstallUpdate.Name = "btnInstallUpdate";
            this.btnInstallUpdate.Size = new System.Drawing.Size(138, 23);
            this.btnInstallUpdate.TabIndex = 6;
            this.btnInstallUpdate.Text = "Install";
            this.btnInstallUpdate.UseVisualStyleBackColor = false;
            this.btnInstallUpdate.Click += new System.EventHandler(this.btnInstallUpdate_Click);
            // 
            // btnDownloadUpdate
            // 
            this.btnDownloadUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(152)))), ((int)(((byte)(54)))));
            this.btnDownloadUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(136)))), ((int)(((byte)(38)))));
            this.btnDownloadUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDownloadUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDownloadUpdate.Location = new System.Drawing.Point(260, 100);
            this.btnDownloadUpdate.Name = "btnDownloadUpdate";
            this.btnDownloadUpdate.Size = new System.Drawing.Size(138, 23);
            this.btnDownloadUpdate.TabIndex = 5;
            this.btnDownloadUpdate.Text = "Download";
            this.btnDownloadUpdate.UseVisualStyleBackColor = false;
            this.btnDownloadUpdate.Click += new System.EventHandler(this.btnDownloadUpdate_Click);
            // 
            // tbxVersion
            // 
            this.tbxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxVersion.BackColor = System.Drawing.Color.White;
            this.tbxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxVersion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxVersion.Location = new System.Drawing.Point(105, 13);
            this.tbxVersion.Multiline = true;
            this.tbxVersion.Name = "tbxVersion";
            this.tbxVersion.ReadOnly = true;
            this.tbxVersion.Size = new System.Drawing.Size(149, 23);
            this.tbxVersion.TabIndex = 8;
            // 
            // tbxLastUpdateCheck
            // 
            this.tbxLastUpdateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLastUpdateCheck.BackColor = System.Drawing.Color.White;
            this.tbxLastUpdateCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLastUpdateCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxLastUpdateCheck.Location = new System.Drawing.Point(105, 71);
            this.tbxLastUpdateCheck.Multiline = true;
            this.tbxLastUpdateCheck.Name = "tbxLastUpdateCheck";
            this.tbxLastUpdateCheck.ReadOnly = true;
            this.tbxLastUpdateCheck.Size = new System.Drawing.Size(149, 23);
            this.tbxLastUpdateCheck.TabIndex = 8;
            // 
            // tbxNewVersionState
            // 
            this.tbxNewVersionState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNewVersionState.BackColor = System.Drawing.Color.White;
            this.tbxNewVersionState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNewVersionState.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxNewVersionState.Location = new System.Drawing.Point(105, 100);
            this.tbxNewVersionState.Multiline = true;
            this.tbxNewVersionState.Name = "tbxNewVersionState";
            this.tbxNewVersionState.ReadOnly = true;
            this.tbxNewVersionState.Size = new System.Drawing.Size(149, 23);
            this.tbxNewVersionState.TabIndex = 8;
            // 
            // tbxNewVersionDetails
            // 
            this.tbxNewVersionDetails.BackColor = System.Drawing.Color.White;
            this.tbxNewVersionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNewVersionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNewVersionDetails.Location = new System.Drawing.Point(105, 129);
            this.tbxNewVersionDetails.Multiline = true;
            this.tbxNewVersionDetails.Name = "tbxNewVersionDetails";
            this.tbxNewVersionDetails.ReadOnly = true;
            this.tbxNewVersionDetails.Size = new System.Drawing.Size(149, 106);
            this.tbxNewVersionDetails.TabIndex = 8;
            // 
            // btnInstallService
            // 
            this.btnInstallService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(78)))));
            this.btnInstallService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(58)))));
            this.btnInstallService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallService.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInstallService.ForeColor = System.Drawing.Color.White;
            this.btnInstallService.Location = new System.Drawing.Point(260, 13);
            this.btnInstallService.Name = "btnInstallService";
            this.btnInstallService.Size = new System.Drawing.Size(138, 23);
            this.btnInstallService.TabIndex = 7;
            this.btnInstallService.Text = "Install";
            this.btnInstallService.UseVisualStyleBackColor = false;
            this.btnInstallService.Visible = false;
            // 
            // pbxAppIcon
            // 
            this.pbxAppIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxAppIcon.Location = new System.Drawing.Point(3, 3);
            this.pbxAppIcon.Name = "pbxAppIcon";
            this.pbxAppIcon.Size = new System.Drawing.Size(133, 303);
            this.pbxAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxAppIcon.TabIndex = 1;
            this.pbxAppIcon.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRegistrationCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxOwner, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSupportCaption, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbtnProducer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCopyright, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 312);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblRegistrationCaption
            // 
            this.lblRegistrationCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistrationCaption.AutoSize = true;
            this.lblRegistrationCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRegistrationCaption.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrationCaption.Location = new System.Drawing.Point(3, 0);
            this.lblRegistrationCaption.Name = "lblRegistrationCaption";
            this.lblRegistrationCaption.Size = new System.Drawing.Size(84, 20);
            this.lblRegistrationCaption.TabIndex = 2;
            this.lblRegistrationCaption.Text = "Registered to";
            this.lblRegistrationCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxOwner
            // 
            this.tbxOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOwner.BackColor = System.Drawing.Color.White;
            this.tbxOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOwner.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxOwner.Location = new System.Drawing.Point(93, 3);
            this.tbxOwner.Name = "tbxOwner";
            this.tbxOwner.ReadOnly = true;
            this.tbxOwner.Size = new System.Drawing.Size(176, 14);
            this.tbxOwner.TabIndex = 8;
            // 
            // lblSupportCaption
            // 
            this.lblSupportCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSupportCaption.AutoSize = true;
            this.lblSupportCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSupportCaption.ForeColor = System.Drawing.Color.Gray;
            this.lblSupportCaption.Location = new System.Drawing.Point(3, 20);
            this.lblSupportCaption.Name = "lblSupportCaption";
            this.lblSupportCaption.Size = new System.Drawing.Size(52, 29);
            this.lblSupportCaption.TabIndex = 3;
            this.lblSupportCaption.Text = "Support";
            this.lblSupportCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbtnProducer
            // 
            this.lbtnProducer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbtnProducer.AutoSize = true;
            this.lbtnProducer.Location = new System.Drawing.Point(93, 20);
            this.lbtnProducer.Name = "lbtnProducer";
            this.lbtnProducer.Size = new System.Drawing.Size(100, 29);
            this.lbtnProducer.TabIndex = 9;
            this.lbtnProducer.TabStop = true;
            this.lbtnProducer.Text = "www.SarvSoft.com";
            this.lbtnProducer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.ForeColor = System.Drawing.Color.Gray;
            this.lblCopyright.Location = new System.Drawing.Point(452, 20);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(97, 29);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "Copyright (c) 2011";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 364);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About program";
            this.tlpMain.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.tlpControls.PerformLayout();
            this.gpxUpdates.ResumeLayout(false);
            this.tlpUpdates.ResumeLayout(false);
            this.tlpUpdates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private FormLabel lblAppName;
        private FormLabel lblCopyright;
        private FormLabel lblRegistrationCaption;
        private FormLabel lblSupportCaption;
        private System.Windows.Forms.GroupBox gpxUpdates;
        private System.Windows.Forms.TableLayoutPanel tlpUpdates;
        private FormLabel lblVersionCaption;
        private FormLabel lblLastUpdateCheckCaption;
        private ButtonBase btnCheckNow;
        private FormLabel lblUpdateStateCaption;
        private ButtonBase btnDownloadUpdate;
        private ButtonBase btnInstallUpdate;
        private ButtonBase btnUnInstallService;
        private System.Windows.Forms.PictureBox pbxAppIcon;
        private System.Windows.Forms.TextBox tbxVersion;
        private System.Windows.Forms.TextBox tbxLastUpdateCheck;
        private System.Windows.Forms.TextBox tbxNewVersionState;
        private System.Windows.Forms.TextBox tbxNewVersionDetails;
        private ButtonBase btnInstallService;
        private System.Windows.Forms.TextBox tbxOwner;
        private System.Windows.Forms.LinkLabel lbtnProducer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}