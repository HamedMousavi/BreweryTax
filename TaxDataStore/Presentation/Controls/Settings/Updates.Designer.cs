namespace TaxDataStore.Presentation.Controls.Settings
{
    partial class Updates
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
            this.chbxUpdateAutoDownload = new System.Windows.Forms.CheckBox();
            this.lblUpdateSeconds = new FormLabel("lbl_upd_sseconds");
            this.lblUpdateEvery = new FormLabel("lbl_upd_interval");
            this.lblUpdateUrl = new FormLabel("lbl_upd_url");
            this.tbxUpdateCheckInterval = new System.Windows.Forms.TextBox();
            this.tbxUpdateUrl = new System.Windows.Forms.TextBox();
            this.chbxToggleAutoUpdate = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.chbxUpdateAutoDownload, 0, 3);
            this.tlpMain.Controls.Add(this.lblUpdateSeconds, 2, 2);
            this.tlpMain.Controls.Add(this.tbxUpdateCheckInterval, 1, 2);
            this.tlpMain.Controls.Add(this.lblUpdateEvery, 0, 2);
            this.tlpMain.Controls.Add(this.lblUpdateUrl, 0, 1);
            this.tlpMain.Controls.Add(this.tbxUpdateUrl, 1, 1);
            this.tlpMain.Controls.Add(this.chbxToggleAutoUpdate, 0, 0);
            this.tlpMain.Controls.Add(this.btnSave, 0, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
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
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(472, 299);
            this.tlpMain.TabIndex = 0;
            // 
            // chbxUpdateAutoDownload
            // 
            this.chbxUpdateAutoDownload.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.chbxUpdateAutoDownload, 3);
            this.chbxUpdateAutoDownload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbxUpdateAutoDownload.ForeColor = System.Drawing.Color.DimGray;
            this.chbxUpdateAutoDownload.Location = new System.Drawing.Point(3, 80);
            this.chbxUpdateAutoDownload.Name = "chbxUpdateAutoDownload";
            this.chbxUpdateAutoDownload.Size = new System.Drawing.Size(233, 17);
            this.chbxUpdateAutoDownload.TabIndex = 6;
            this.chbxUpdateAutoDownload.Text = "Download new version automatically";
            this.chbxUpdateAutoDownload.UseVisualStyleBackColor = true;
            // 
            // lblUpdateSeconds
            // 
            this.lblUpdateSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdateSeconds.AutoSize = true;
            this.lblUpdateSeconds.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUpdateSeconds.ForeColor = System.Drawing.Color.DimGray;
            this.lblUpdateSeconds.Location = new System.Drawing.Point(242, 50);
            this.lblUpdateSeconds.Name = "lblUpdateSeconds";
            this.lblUpdateSeconds.Size = new System.Drawing.Size(54, 27);
            this.lblUpdateSeconds.TabIndex = 5;
            this.lblUpdateSeconds.Text = "Seconds";
            this.lblUpdateSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUpdateCheckInterval
            // 
            this.tbxUpdateCheckInterval.Location = new System.Drawing.Point(154, 53);
            this.tbxUpdateCheckInterval.Name = "tbxUpdateCheckInterval";
            this.tbxUpdateCheckInterval.Size = new System.Drawing.Size(82, 21);
            this.tbxUpdateCheckInterval.TabIndex = 4;
            // 
            // lblUpdateEvery
            // 
            this.lblUpdateEvery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdateEvery.AutoSize = true;
            this.lblUpdateEvery.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUpdateEvery.ForeColor = System.Drawing.Color.DimGray;
            this.lblUpdateEvery.Location = new System.Drawing.Point(3, 50);
            this.lblUpdateEvery.Name = "lblUpdateEvery";
            this.lblUpdateEvery.Size = new System.Drawing.Size(145, 27);
            this.lblUpdateEvery.TabIndex = 3;
            this.lblUpdateEvery.Text = "Check for updates every";
            this.lblUpdateEvery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUpdateUrl
            // 
            this.lblUpdateUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdateUrl.AutoSize = true;
            this.lblUpdateUrl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUpdateUrl.ForeColor = System.Drawing.Color.DimGray;
            this.lblUpdateUrl.Location = new System.Drawing.Point(3, 23);
            this.lblUpdateUrl.Name = "lblUpdateUrl";
            this.lblUpdateUrl.Size = new System.Drawing.Size(64, 27);
            this.lblUpdateUrl.TabIndex = 1;
            this.lblUpdateUrl.Text = "UpdateUrl";
            this.lblUpdateUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUpdateUrl
            // 
            this.tlpMain.SetColumnSpan(this.tbxUpdateUrl, 2);
            this.tbxUpdateUrl.Location = new System.Drawing.Point(154, 26);
            this.tbxUpdateUrl.Name = "tbxUpdateUrl";
            this.tbxUpdateUrl.Size = new System.Drawing.Size(248, 21);
            this.tbxUpdateUrl.TabIndex = 2;
            // 
            // chbxToggleAutoUpdate
            // 
            this.chbxToggleAutoUpdate.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.chbxToggleAutoUpdate, 3);
            this.chbxToggleAutoUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbxToggleAutoUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.chbxToggleAutoUpdate.Location = new System.Drawing.Point(3, 3);
            this.chbxToggleAutoUpdate.Name = "chbxToggleAutoUpdate";
            this.chbxToggleAutoUpdate.Size = new System.Drawing.Size(167, 17);
            this.chbxToggleAutoUpdate.TabIndex = 0;
            this.chbxToggleAutoUpdate.Text = "Enable automatic update";
            this.chbxToggleAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(78)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 26);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Name = "Updates";
            this.Size = new System.Drawing.Size(472, 299);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.CheckBox chbxUpdateAutoDownload;
        private FormLabel lblUpdateSeconds;
        private System.Windows.Forms.TextBox tbxUpdateCheckInterval;
        private FormLabel lblUpdateEvery;
        private FormLabel lblUpdateUrl;
        private System.Windows.Forms.TextBox tbxUpdateUrl;
        private System.Windows.Forms.CheckBox chbxToggleAutoUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}
