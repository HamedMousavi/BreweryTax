namespace TaxDataStore.Presentation.Controls
{
    partial class JobProgress
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
            this.lblJobName = new System.Windows.Forms.Label();
            this.pgsMainBar = new System.Windows.Forms.ProgressBar();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblJobName, 0, 0);
            this.tlpMain.Controls.Add(this.pgsMainBar, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(302, 54);
            this.tlpMain.TabIndex = 0;
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(3, 0);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(0, 13);
            this.lblJobName.TabIndex = 0;
            // 
            // pgsMainBar
            // 
            this.pgsMainBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.SetColumnSpan(this.pgsMainBar, 2);
            this.pgsMainBar.Location = new System.Drawing.Point(3, 16);
            this.pgsMainBar.Name = "pgsMainBar";
            this.pgsMainBar.Size = new System.Drawing.Size(296, 17);
            this.pgsMainBar.TabIndex = 1;
            // 
            // JobProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "JobProgress";
            this.Size = new System.Drawing.Size(302, 54);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.ProgressBar pgsMainBar;
    }
}
