namespace TaxDataStore
{
    partial class GeneralAppSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatabaseServerName = new System.Windows.Forms.Label();
            this.lblDatabaseTcpPort = new System.Windows.Forms.Label();
            this.lblDatabaseUserId = new System.Windows.Forms.Label();
            this.lblDatabasePassword = new System.Windows.Forms.Label();
            this.lblDatabaseCatalog = new System.Windows.Forms.Label();
            this.tbxDatabaseServerName = new System.Windows.Forms.TextBox();
            this.tbxDatabaseTcpPort = new System.Windows.Forms.TextBox();
            this.tbxDatabaseUserId = new System.Windows.Forms.TextBox();
            this.tbxDatabasePassword = new System.Windows.Forms.TextBox();
            this.tbxDatabaseCatalog = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblDatabaseServerName, 0, 1);
            this.tlpMain.Controls.Add(this.lblDatabaseTcpPort, 0, 2);
            this.tlpMain.Controls.Add(this.lblDatabaseUserId, 0, 3);
            this.tlpMain.Controls.Add(this.lblDatabasePassword, 0, 4);
            this.tlpMain.Controls.Add(this.lblDatabaseCatalog, 0, 5);
            this.tlpMain.Controls.Add(this.tbxDatabaseServerName, 1, 1);
            this.tlpMain.Controls.Add(this.tbxDatabaseTcpPort, 1, 2);
            this.tlpMain.Controls.Add(this.tbxDatabaseUserId, 1, 3);
            this.tlpMain.Controls.Add(this.tbxDatabasePassword, 1, 4);
            this.tlpMain.Controls.Add(this.tbxDatabaseCatalog, 1, 5);
            this.tlpMain.Controls.Add(this.btnSave, 1, 8);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 9;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(502, 394);
            this.tlpMain.TabIndex = 1;
            // 
            // lblDatabaseServerName
            // 
            this.lblDatabaseServerName.AutoSize = true;
            this.lblDatabaseServerName.Location = new System.Drawing.Point(3, 20);
            this.lblDatabaseServerName.Name = "lblDatabaseServerName";
            this.lblDatabaseServerName.Size = new System.Drawing.Size(76, 13);
            this.lblDatabaseServerName.TabIndex = 8;
            this.lblDatabaseServerName.Text = "InstanceName";
            // 
            // lblDatabaseTcpPort
            // 
            this.lblDatabaseTcpPort.AutoSize = true;
            this.lblDatabaseTcpPort.Location = new System.Drawing.Point(3, 46);
            this.lblDatabaseTcpPort.Name = "lblDatabaseTcpPort";
            this.lblDatabaseTcpPort.Size = new System.Drawing.Size(50, 13);
            this.lblDatabaseTcpPort.TabIndex = 10;
            this.lblDatabaseTcpPort.Text = "TCP Port";
            // 
            // lblDatabaseUserId
            // 
            this.lblDatabaseUserId.AutoSize = true;
            this.lblDatabaseUserId.Location = new System.Drawing.Point(3, 72);
            this.lblDatabaseUserId.Name = "lblDatabaseUserId";
            this.lblDatabaseUserId.Size = new System.Drawing.Size(43, 13);
            this.lblDatabaseUserId.TabIndex = 12;
            this.lblDatabaseUserId.Text = "User ID";
            // 
            // lblDatabasePassword
            // 
            this.lblDatabasePassword.AutoSize = true;
            this.lblDatabasePassword.Location = new System.Drawing.Point(3, 98);
            this.lblDatabasePassword.Name = "lblDatabasePassword";
            this.lblDatabasePassword.Size = new System.Drawing.Size(53, 13);
            this.lblDatabasePassword.TabIndex = 14;
            this.lblDatabasePassword.Text = "Password";
            // 
            // lblDatabaseCatalog
            // 
            this.lblDatabaseCatalog.AutoSize = true;
            this.lblDatabaseCatalog.Location = new System.Drawing.Point(3, 124);
            this.lblDatabaseCatalog.Name = "lblDatabaseCatalog";
            this.lblDatabaseCatalog.Size = new System.Drawing.Size(43, 13);
            this.lblDatabaseCatalog.TabIndex = 16;
            this.lblDatabaseCatalog.Text = "Catalog";
            // 
            // tbxDatabaseServerName
            // 
            this.tbxDatabaseServerName.Location = new System.Drawing.Point(85, 23);
            this.tbxDatabaseServerName.Name = "tbxDatabaseServerName";
            this.tbxDatabaseServerName.Size = new System.Drawing.Size(248, 20);
            this.tbxDatabaseServerName.TabIndex = 9;
            // 
            // tbxDatabaseTcpPort
            // 
            this.tbxDatabaseTcpPort.Location = new System.Drawing.Point(85, 49);
            this.tbxDatabaseTcpPort.Name = "tbxDatabaseTcpPort";
            this.tbxDatabaseTcpPort.Size = new System.Drawing.Size(248, 20);
            this.tbxDatabaseTcpPort.TabIndex = 11;
            // 
            // tbxDatabaseUserId
            // 
            this.tbxDatabaseUserId.Location = new System.Drawing.Point(85, 75);
            this.tbxDatabaseUserId.Name = "tbxDatabaseUserId";
            this.tbxDatabaseUserId.Size = new System.Drawing.Size(248, 20);
            this.tbxDatabaseUserId.TabIndex = 13;
            // 
            // tbxDatabasePassword
            // 
            this.tbxDatabasePassword.Location = new System.Drawing.Point(85, 101);
            this.tbxDatabasePassword.Name = "tbxDatabasePassword";
            this.tbxDatabasePassword.Size = new System.Drawing.Size(248, 20);
            this.tbxDatabasePassword.TabIndex = 15;
            this.tbxDatabasePassword.UseSystemPasswordChar = true;
            // 
            // tbxDatabaseCatalog
            // 
            this.tbxDatabaseCatalog.Location = new System.Drawing.Point(85, 127);
            this.tbxDatabaseCatalog.Name = "tbxDatabaseCatalog";
            this.tbxDatabaseCatalog.Size = new System.Drawing.Size(248, 20);
            this.tbxDatabaseCatalog.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(85, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GeneralAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "GeneralAppSettings";
            this.Size = new System.Drawing.Size(502, 394);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblDatabaseServerName;
        private System.Windows.Forms.Label lblDatabaseTcpPort;
        private System.Windows.Forms.Label lblDatabaseUserId;
        private System.Windows.Forms.Label lblDatabasePassword;
        private System.Windows.Forms.Label lblDatabaseCatalog;
        private System.Windows.Forms.TextBox tbxDatabaseServerName;
        private System.Windows.Forms.TextBox tbxDatabaseTcpPort;
        private System.Windows.Forms.TextBox tbxDatabaseUserId;
        private System.Windows.Forms.TextBox tbxDatabasePassword;
        private System.Windows.Forms.TextBox tbxDatabaseCatalog;
        private System.Windows.Forms.Button btnSave;
    }
}
