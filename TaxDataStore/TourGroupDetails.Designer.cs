namespace TaxDataStore
{
    partial class TourGroupDetails
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
            this.pbxSignupType = new System.Windows.Forms.PictureBox();
            this.lblSignupType = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignupType)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pbxSignupType, 0, 1);
            this.tlpMain.Controls.Add(this.lblSignupType, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(80, 150);
            this.tlpMain.TabIndex = 0;
            // 
            // pbxSignupType
            // 
            this.pbxSignupType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSignupType.Location = new System.Drawing.Point(3, 84);
            this.pbxSignupType.Name = "pbxSignupType";
            this.pbxSignupType.Size = new System.Drawing.Size(74, 50);
            this.pbxSignupType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSignupType.TabIndex = 0;
            this.pbxSignupType.TabStop = false;
            // 
            // lblSignupType
            // 
            this.lblSignupType.AutoSize = true;
            this.lblSignupType.Location = new System.Drawing.Point(3, 137);
            this.lblSignupType.Name = "lblSignupType";
            this.lblSignupType.Size = new System.Drawing.Size(35, 13);
            this.lblSignupType.TabIndex = 1;
            this.lblSignupType.Text = "label1";
            // 
            // TourGroupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "TourGroupDetails";
            this.Size = new System.Drawing.Size(80, 150);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignupType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbxSignupType;
        private System.Windows.Forms.Label lblSignupType;
    }
}
