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
            this.tbxDatabaseServerName = new System.Windows.Forms.TextBox();
            this.tbxDatabaseTcpPort = new System.Windows.Forms.TextBox();
            this.tbxDatabaseUserId = new System.Windows.Forms.TextBox();
            this.tbxDatabasePassword = new System.Windows.Forms.TextBox();
            this.tbxDatabaseCatalog = new System.Windows.Forms.TextBox();
            this.btnSave = new ButtonBase();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
        private System.Windows.Forms.TextBox tbxDatabaseServerName;
        private System.Windows.Forms.TextBox tbxDatabaseTcpPort;
        private System.Windows.Forms.TextBox tbxDatabaseUserId;
        private System.Windows.Forms.TextBox tbxDatabasePassword;
        private System.Windows.Forms.TextBox tbxDatabaseCatalog;
        private ButtonBase btnSave;
    }
}
