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
            this.btnClose = new System.Windows.Forms.Button();
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
            this.tlpMain.Controls.Add(this.btnClose, 0, 0);
            this.tlpMain.Controls.Add(this.pbxSignupType, 0, 3);
            this.tlpMain.Controls.Add(this.pbxGroupState, 0, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(40, 35);
            this.tlpMain.TabIndex = 0;
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
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pbxSignupType
            // 
            this.pbxSignupType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSignupType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSignupType.Location = new System.Drawing.Point(2, -21);
            this.pbxSignupType.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSignupType.Name = "pbxSignupType";
            this.pbxSignupType.Size = new System.Drawing.Size(36, 32);
            this.pbxSignupType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSignupType.TabIndex = 0;
            this.pbxSignupType.TabStop = false;
            this.pbxSignupType.Click += new System.EventHandler(this.pbxSignupType_Click);
            // 
            // pbxGroupState
            // 
            this.pbxGroupState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxGroupState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGroupState.Location = new System.Drawing.Point(2, 15);
            this.pbxGroupState.Margin = new System.Windows.Forms.Padding(2);
            this.pbxGroupState.Name = "pbxGroupState";
            this.pbxGroupState.Size = new System.Drawing.Size(36, 18);
            this.pbxGroupState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxGroupState.TabIndex = 2;
            this.pbxGroupState.TabStop = false;
            this.pbxGroupState.Click += new System.EventHandler(this.pbxGroupState_Click);
            // 
            // TourGroupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "TourGroupDetails";
            this.Size = new System.Drawing.Size(40, 35);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignupType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGroupState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbxSignupType;
        private System.Windows.Forms.PictureBox pbxGroupState;
        private System.Windows.Forms.Button btnClose;
    }
}
