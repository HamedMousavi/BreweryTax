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
            this.pbxGroupState = new System.Windows.Forms.PictureBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignupType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGroupState)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pbxSignupType, 0, 1);
            this.tlpMain.Controls.Add(this.pbxGroupState, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(80, 150);
            this.tlpMain.TabIndex = 0;
            // 
            // pbxSignupType
            // 
            this.pbxSignupType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSignupType.Location = new System.Drawing.Point(3, 115);
            this.pbxSignupType.Name = "pbxSignupType";
            this.pbxSignupType.Size = new System.Drawing.Size(74, 32);
            this.pbxSignupType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSignupType.TabIndex = 0;
            this.pbxSignupType.TabStop = false;
            // 
            // pbxGroupState
            // 
            this.pbxGroupState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxGroupState.Location = new System.Drawing.Point(3, 3);
            this.pbxGroupState.Name = "pbxGroupState";
            this.pbxGroupState.Size = new System.Drawing.Size(74, 32);
            this.pbxGroupState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGroupState.TabIndex = 2;
            this.pbxGroupState.TabStop = false;
            // 
            // TourGroupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "TourGroupDetails";
            this.Size = new System.Drawing.Size(80, 150);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignupType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGroupState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbxSignupType;
        private System.Windows.Forms.PictureBox pbxGroupState;
    }
}
