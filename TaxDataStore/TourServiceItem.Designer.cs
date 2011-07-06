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
            this.lblServiceCount = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.pbxServiceType = new System.Windows.Forms.PictureBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceType)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.Controls.Add(this.pbxServiceType, 0, 0);
            this.tlpMain.Controls.Add(this.lblServiceCount, 2, 0);
            this.tlpMain.Controls.Add(this.lblServiceType, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(180, 42);
            this.tlpMain.TabIndex = 0;
            // 
            // lblServiceCount
            // 
            this.lblServiceCount.AutoSize = true;
            this.lblServiceCount.Location = new System.Drawing.Point(143, 0);
            this.lblServiceCount.Name = "lblServiceCount";
            this.lblServiceCount.Size = new System.Drawing.Size(13, 13);
            this.lblServiceCount.TabIndex = 0;
            this.lblServiceCount.Text = "0";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(43, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(26, 13);
            this.lblServiceType.TabIndex = 1;
            this.lblServiceType.Text = "Mini";
            // 
            // pbxServiceType
            // 
            this.pbxServiceType.Location = new System.Drawing.Point(0, 0);
            this.pbxServiceType.Margin = new System.Windows.Forms.Padding(0);
            this.pbxServiceType.Name = "pbxServiceType";
            this.pbxServiceType.Size = new System.Drawing.Size(40, 40);
            this.pbxServiceType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxServiceType.TabIndex = 2;
            this.pbxServiceType.TabStop = false;
            // 
            // TourServiceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "TourServiceItem";
            this.Size = new System.Drawing.Size(180, 42);
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
    }
}
