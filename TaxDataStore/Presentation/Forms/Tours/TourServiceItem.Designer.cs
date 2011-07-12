namespace TaxDataStore
{
    partial class TourServiceItem
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
            this.pbxServiceType = new System.Windows.Forms.PictureBox();
            this.lblServiceCount = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceType)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.Controls.Add(this.pbxServiceType, 1, 0);
            this.tlpMain.Controls.Add(this.lblServiceCount, 3, 0);
            this.tlpMain.Controls.Add(this.lblServiceType, 2, 0);
            this.tlpMain.Controls.Add(this.btnClose, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(138, 30);
            this.tlpMain.TabIndex = 0;
            // 
            // pbxServiceType
            // 
            this.pbxServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxServiceType.Location = new System.Drawing.Point(16, 3);
            this.pbxServiceType.Margin = new System.Windows.Forms.Padding(0);
            this.pbxServiceType.Name = "pbxServiceType";
            this.pbxServiceType.Size = new System.Drawing.Size(24, 24);
            this.pbxServiceType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxServiceType.TabIndex = 2;
            this.pbxServiceType.TabStop = false;
            // 
            // lblServiceCount
            // 
            this.lblServiceCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblServiceCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblServiceCount.Location = new System.Drawing.Point(100, 2);
            this.lblServiceCount.Margin = new System.Windows.Forms.Padding(2);
            this.lblServiceCount.Name = "lblServiceCount";
            this.lblServiceCount.Size = new System.Drawing.Size(36, 26);
            this.lblServiceCount.TabIndex = 0;
            this.lblServiceCount.Text = "0";
            this.lblServiceCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServiceType
            // 
            this.lblServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblServiceType.Location = new System.Drawing.Point(43, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(52, 30);
            this.lblServiceType.TabIndex = 1;
            this.lblServiceType.Text = "Mini";
            this.lblServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // TourServiceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "TourServiceItem";
            this.Size = new System.Drawing.Size(138, 30);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblServiceCount;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.PictureBox pbxServiceType;
        private System.Windows.Forms.Button btnClose;
    }
}
