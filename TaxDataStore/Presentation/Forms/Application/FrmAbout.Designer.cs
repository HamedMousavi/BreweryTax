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
            this.gpxUpdates = new System.Windows.Forms.GroupBox();
            this.tlpUpdates = new System.Windows.Forms.TableLayoutPanel();
            this.btnCheckNow = new TaxDataStore.Presentation.Controls.ButtonBase();
            this.btnUnInstallService = new TaxDataStore.Presentation.Controls.ButtonBase();
            this.btnInstallUpdate = new TaxDataStore.Presentation.Controls.ButtonBase();
            this.btnDownloadUpdate = new TaxDataStore.Presentation.Controls.ButtonBase();
            this.btnInstallService = new TaxDataStore.Presentation.Controls.ButtonBase();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLastUpdateCheck = new System.Windows.Forms.Label();
            this.lblNewVersionState = new System.Windows.Forms.Label();
            this.lblNewVersionDetails = new System.Windows.Forms.Label();
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
            // gpxUpdates
            // 
            this.tlpControls.SetColumnSpan(this.gpxUpdates, 2);
            this.gpxUpdates.Controls.Add(this.tlpUpdates);
            this.gpxUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxUpdates.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxUpdates.Location = new System.Drawing.Point(3, 3);
            this.gpxUpdates.Name = "gpxUpdates";
            this.gpxUpdates.Size = new System.Drawing.Size(407, 297);
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
            this.tlpUpdates.Controls.Add(this.btnCheckNow, 2, 3);
            this.tlpUpdates.Controls.Add(this.btnUnInstallService, 2, 2);
            this.tlpUpdates.Controls.Add(this.btnInstallUpdate, 2, 5);
            this.tlpUpdates.Controls.Add(this.btnDownloadUpdate, 2, 4);
            this.tlpUpdates.Controls.Add(this.btnInstallService, 2, 1);
            this.tlpUpdates.Controls.Add(this.lblVersion, 1, 1);
            this.tlpUpdates.Controls.Add(this.lblLastUpdateCheck, 1, 3);
            this.tlpUpdates.Controls.Add(this.lblNewVersionState, 1, 4);
            this.tlpUpdates.Controls.Add(this.lblNewVersionDetails, 1, 5);
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
            this.tlpUpdates.Size = new System.Drawing.Size(401, 277);
            this.tlpUpdates.TabIndex = 0;
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.AutoSize = true;
            this.btnCheckNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(152)))), ((int)(((byte)(54)))));
            this.btnCheckNow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(136)))), ((int)(((byte)(38)))));
            this.btnCheckNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckNow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCheckNow.ForeColor = System.Drawing.Color.White;
            this.btnCheckNow.Location = new System.Drawing.Point(260, 75);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(138, 25);
            this.btnCheckNow.TabIndex = 3;
            this.btnCheckNow.Text = "Check now";
            this.btnCheckNow.UseVisualStyleBackColor = false;
            this.btnCheckNow.Click += new System.EventHandler(this.btnCheckNow_Click);
            // 
            // btnUnInstallService
            // 
            this.btnUnInstallService.AutoSize = true;
            this.btnUnInstallService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(152)))), ((int)(((byte)(54)))));
            this.btnUnInstallService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(136)))), ((int)(((byte)(38)))));
            this.btnUnInstallService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnInstallService.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnInstallService.ForeColor = System.Drawing.Color.White;
            this.btnUnInstallService.Location = new System.Drawing.Point(260, 44);
            this.btnUnInstallService.Name = "btnUnInstallService";
            this.btnUnInstallService.Size = new System.Drawing.Size(138, 25);
            this.btnUnInstallService.TabIndex = 7;
            this.btnUnInstallService.Text = "UnInstall";
            this.btnUnInstallService.UseVisualStyleBackColor = false;
            this.btnUnInstallService.Visible = false;
            // 
            // btnInstallUpdate
            // 
            this.btnInstallUpdate.AutoSize = true;
            this.btnInstallUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(152)))), ((int)(((byte)(54)))));
            this.btnInstallUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(136)))), ((int)(((byte)(38)))));
            this.btnInstallUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInstallUpdate.ForeColor = System.Drawing.Color.White;
            this.btnInstallUpdate.Location = new System.Drawing.Point(260, 137);
            this.btnInstallUpdate.Name = "btnInstallUpdate";
            this.btnInstallUpdate.Size = new System.Drawing.Size(138, 25);
            this.btnInstallUpdate.TabIndex = 6;
            this.btnInstallUpdate.Text = "Install";
            this.btnInstallUpdate.UseVisualStyleBackColor = false;
            this.btnInstallUpdate.Click += new System.EventHandler(this.btnInstallUpdate_Click);
            // 
            // btnDownloadUpdate
            // 
            this.btnDownloadUpdate.AutoSize = true;
            this.btnDownloadUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(152)))), ((int)(((byte)(54)))));
            this.btnDownloadUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(136)))), ((int)(((byte)(38)))));
            this.btnDownloadUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDownloadUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDownloadUpdate.Location = new System.Drawing.Point(260, 106);
            this.btnDownloadUpdate.Name = "btnDownloadUpdate";
            this.btnDownloadUpdate.Size = new System.Drawing.Size(138, 25);
            this.btnDownloadUpdate.TabIndex = 5;
            this.btnDownloadUpdate.Text = "Download";
            this.btnDownloadUpdate.UseVisualStyleBackColor = false;
            this.btnDownloadUpdate.Click += new System.EventHandler(this.btnDownloadUpdate_Click);
            // 
            // btnInstallService
            // 
            this.btnInstallService.AutoSize = true;
            this.btnInstallService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(78)))));
            this.btnInstallService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(58)))));
            this.btnInstallService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallService.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInstallService.ForeColor = System.Drawing.Color.White;
            this.btnInstallService.Location = new System.Drawing.Point(260, 13);
            this.btnInstallService.Name = "btnInstallService";
            this.btnInstallService.Size = new System.Drawing.Size(138, 25);
            this.btnInstallService.TabIndex = 7;
            this.btnInstallService.Text = "Install";
            this.btnInstallService.UseVisualStyleBackColor = false;
            this.btnInstallService.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(3, 10);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(251, 31);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastUpdateCheck
            // 
            this.lblLastUpdateCheck.AutoSize = true;
            this.lblLastUpdateCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastUpdateCheck.Location = new System.Drawing.Point(3, 72);
            this.lblLastUpdateCheck.Name = "lblLastUpdateCheck";
            this.lblLastUpdateCheck.Size = new System.Drawing.Size(251, 31);
            this.lblLastUpdateCheck.TabIndex = 10;
            this.lblLastUpdateCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewVersionState
            // 
            this.lblNewVersionState.AutoSize = true;
            this.lblNewVersionState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewVersionState.Location = new System.Drawing.Point(3, 103);
            this.lblNewVersionState.Name = "lblNewVersionState";
            this.lblNewVersionState.Size = new System.Drawing.Size(251, 31);
            this.lblNewVersionState.TabIndex = 11;
            this.lblNewVersionState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewVersionDetails
            // 
            this.lblNewVersionDetails.AutoSize = true;
            this.lblNewVersionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewVersionDetails.Location = new System.Drawing.Point(3, 134);
            this.lblNewVersionDetails.Name = "lblNewVersionDetails";
            this.lblNewVersionDetails.Size = new System.Drawing.Size(251, 143);
            this.lblNewVersionDetails.TabIndex = 12;
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
            this.tableLayoutPanel1.Controls.Add(this.tbxOwner, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbtnProducer, 1, 1);
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
            // tbxOwner
            // 
            this.tbxOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOwner.BackColor = System.Drawing.Color.White;
            this.tbxOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOwner.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxOwner.Location = new System.Drawing.Point(3, 3);
            this.tbxOwner.Name = "tbxOwner";
            this.tbxOwner.ReadOnly = true;
            this.tbxOwner.Size = new System.Drawing.Size(176, 14);
            this.tbxOwner.TabIndex = 8;
            // 
            // lbtnProducer
            // 
            this.lbtnProducer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbtnProducer.AutoSize = true;
            this.lbtnProducer.Location = new System.Drawing.Point(3, 20);
            this.lbtnProducer.Name = "lbtnProducer";
            this.lbtnProducer.Size = new System.Drawing.Size(100, 29);
            this.lbtnProducer.TabIndex = 9;
            this.lbtnProducer.TabStop = true;
            this.lbtnProducer.Text = "www.SarvSoft.com";
            this.lbtnProducer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        private System.Windows.Forms.GroupBox gpxUpdates;
        private System.Windows.Forms.TableLayoutPanel tlpUpdates;
        private ButtonBase btnCheckNow;
        private ButtonBase btnDownloadUpdate;
        private ButtonBase btnInstallUpdate;
        private ButtonBase btnUnInstallService;
        private System.Windows.Forms.PictureBox pbxAppIcon;
        private ButtonBase btnInstallService;
        private System.Windows.Forms.TextBox tbxOwner;
        private System.Windows.Forms.LinkLabel lbtnProducer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLastUpdateCheck;
        private System.Windows.Forms.Label lblNewVersionState;
        private System.Windows.Forms.Label lblNewVersionDetails;
    }
}