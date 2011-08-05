namespace TaxDataStore
{
    partial class TourControl
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
            this.tlpTourDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblTourTime = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpTourDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpTourDetail, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(207, 68);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpTourDetail
            // 
            this.tlpTourDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTourDetail.AutoSize = true;
            this.tlpTourDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTourDetail.ColumnCount = 4;
            this.tlpTourDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourDetail.Controls.Add(this.lblTourTime, 0, 0);
            this.tlpTourDetail.Controls.Add(this.lblDetails, 2, 0);
            this.tlpTourDetail.Controls.Add(this.btnClose, 3, 0);
            this.tlpTourDetail.Location = new System.Drawing.Point(0, 0);
            this.tlpTourDetail.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTourDetail.Name = "tlpTourDetail";
            this.tlpTourDetail.RowCount = 1;
            this.tlpTourDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourDetail.Size = new System.Drawing.Size(207, 16);
            this.tlpTourDetail.TabIndex = 0;
            // 
            // lblTourTime
            // 
            this.lblTourTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTourTime.AutoSize = true;
            this.lblTourTime.Location = new System.Drawing.Point(0, 0);
            this.lblTourTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTourTime.Name = "lblTourTime";
            this.lblTourTime.Size = new System.Drawing.Size(34, 16);
            this.lblTourTime.TabIndex = 0;
            this.lblTourTime.Text = "00:00";
            this.lblTourTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(76, 1);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(115, 13);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Groups(0)   Services(0)";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(191, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Name = "TourControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Size = new System.Drawing.Size(207, 72);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpTourDetail.ResumeLayout(false);
            this.tlpTourDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpTourDetail;
        private System.Windows.Forms.Label lblTourTime;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnClose;
    }
}
