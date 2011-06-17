namespace TaxDataStore.Presentation.Controls.Settings
{
    partial class Database
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
            this.lblDatabaseServerName = new FormLabel("lbl_db_server");
            this.lblDatabaseTcpPort = new FormLabel("lbl_db_port");
            this.lblDatabaseUserId = new FormLabel("lbl_db_srv_user");
            this.lblDatabasePassword = new FormLabel("lbl_db_password");
            this.lblDatabaseCatalog = new FormLabel("lbl_db_name");
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
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.tlpMain.Controls.Add(this.btnSave, 0, 7);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 8;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(539, 558);
            this.tlpMain.TabIndex = 1;
            // 
            // lblDatabaseServerName
            // 
            this.lblDatabaseServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatabaseServerName.AutoSize = true;
            this.lblDatabaseServerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDatabaseServerName.ForeColor = System.Drawing.Color.DimGray;
            this.lblDatabaseServerName.Location = new System.Drawing.Point(3, 5);
            this.lblDatabaseServerName.Name = "lblDatabaseServerName";
            this.lblDatabaseServerName.Size = new System.Drawing.Size(89, 27);
            this.lblDatabaseServerName.TabIndex = 0;
            this.lblDatabaseServerName.Text = "InstanceName";
            this.lblDatabaseServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabaseTcpPort
            // 
            this.lblDatabaseTcpPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatabaseTcpPort.AutoSize = true;
            this.lblDatabaseTcpPort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDatabaseTcpPort.ForeColor = System.Drawing.Color.DimGray;
            this.lblDatabaseTcpPort.Location = new System.Drawing.Point(3, 32);
            this.lblDatabaseTcpPort.Name = "lblDatabaseTcpPort";
            this.lblDatabaseTcpPort.Size = new System.Drawing.Size(55, 27);
            this.lblDatabaseTcpPort.TabIndex = 2;
            this.lblDatabaseTcpPort.Text = "TCP Port";
            this.lblDatabaseTcpPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabaseUserId
            // 
            this.lblDatabaseUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatabaseUserId.AutoSize = true;
            this.lblDatabaseUserId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDatabaseUserId.ForeColor = System.Drawing.Color.DimGray;
            this.lblDatabaseUserId.Location = new System.Drawing.Point(3, 59);
            this.lblDatabaseUserId.Name = "lblDatabaseUserId";
            this.lblDatabaseUserId.Size = new System.Drawing.Size(49, 27);
            this.lblDatabaseUserId.TabIndex = 4;
            this.lblDatabaseUserId.Text = "User ID";
            this.lblDatabaseUserId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabasePassword
            // 
            this.lblDatabasePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatabasePassword.AutoSize = true;
            this.lblDatabasePassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDatabasePassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblDatabasePassword.Location = new System.Drawing.Point(3, 86);
            this.lblDatabasePassword.Name = "lblDatabasePassword";
            this.lblDatabasePassword.Size = new System.Drawing.Size(61, 27);
            this.lblDatabasePassword.TabIndex = 6;
            this.lblDatabasePassword.Text = "Password";
            this.lblDatabasePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabaseCatalog
            // 
            this.lblDatabaseCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatabaseCatalog.AutoSize = true;
            this.lblDatabaseCatalog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDatabaseCatalog.ForeColor = System.Drawing.Color.DimGray;
            this.lblDatabaseCatalog.Location = new System.Drawing.Point(3, 113);
            this.lblDatabaseCatalog.Name = "lblDatabaseCatalog";
            this.lblDatabaseCatalog.Size = new System.Drawing.Size(50, 27);
            this.lblDatabaseCatalog.TabIndex = 8;
            this.lblDatabaseCatalog.Text = "Catalog";
            this.lblDatabaseCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxDatabaseServerName
            // 
            this.tbxDatabaseServerName.Location = new System.Drawing.Point(149, 8);
            this.tbxDatabaseServerName.Name = "tbxDatabaseServerName";
            this.tbxDatabaseServerName.Size = new System.Drawing.Size(248, 21);
            this.tbxDatabaseServerName.TabIndex = 1;
            // 
            // tbxDatabaseTcpPort
            // 
            this.tbxDatabaseTcpPort.Location = new System.Drawing.Point(149, 35);
            this.tbxDatabaseTcpPort.Name = "tbxDatabaseTcpPort";
            this.tbxDatabaseTcpPort.Size = new System.Drawing.Size(248, 21);
            this.tbxDatabaseTcpPort.TabIndex = 3;
            // 
            // tbxDatabaseUserId
            // 
            this.tbxDatabaseUserId.Location = new System.Drawing.Point(149, 62);
            this.tbxDatabaseUserId.Name = "tbxDatabaseUserId";
            this.tbxDatabaseUserId.Size = new System.Drawing.Size(248, 21);
            this.tbxDatabaseUserId.TabIndex = 5;
            // 
            // tbxDatabasePassword
            // 
            this.tbxDatabasePassword.Location = new System.Drawing.Point(149, 89);
            this.tbxDatabasePassword.Name = "tbxDatabasePassword";
            this.tbxDatabasePassword.Size = new System.Drawing.Size(248, 21);
            this.tbxDatabasePassword.TabIndex = 7;
            this.tbxDatabasePassword.UseSystemPasswordChar = true;
            // 
            // tbxDatabaseCatalog
            // 
            this.tbxDatabaseCatalog.Location = new System.Drawing.Point(149, 116);
            this.tbxDatabaseCatalog.Name = "tbxDatabaseCatalog";
            this.tbxDatabaseCatalog.Size = new System.Drawing.Size(248, 21);
            this.tbxDatabaseCatalog.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(78)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 26);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Name = "Database";
            this.Size = new System.Drawing.Size(539, 558);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private FormLabel lblDatabaseServerName;
        private FormLabel lblDatabaseTcpPort;
        private FormLabel lblDatabaseUserId;
        private FormLabel lblDatabasePassword;
        private FormLabel lblDatabaseCatalog;
        private System.Windows.Forms.TextBox tbxDatabaseServerName;
        private System.Windows.Forms.TextBox tbxDatabaseTcpPort;
        private System.Windows.Forms.TextBox tbxDatabaseUserId;
        private System.Windows.Forms.TextBox tbxDatabasePassword;
        private System.Windows.Forms.TextBox tbxDatabaseCatalog;
        private System.Windows.Forms.Button btnSave;
    }
}
