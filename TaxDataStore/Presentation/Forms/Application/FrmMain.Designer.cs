namespace TaxDataStore
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.barsHolder = new System.Windows.Forms.ToolStripContainer();
            this.barsHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // barsHolder
            // 
            // 
            // barsHolder.ContentPanel
            // 
            this.barsHolder.ContentPanel.Size = new System.Drawing.Size(530, 416);
            this.barsHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barsHolder.Location = new System.Drawing.Point(0, 0);
            this.barsHolder.Name = "barsHolder";
            this.barsHolder.Size = new System.Drawing.Size(530, 441);
            this.barsHolder.TabIndex = 0;
            this.barsHolder.Text = "toolStripContainer1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 441);
            this.Controls.Add(this.barsHolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.barsHolder.ResumeLayout(false);
            this.barsHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer barsHolder;

    }
}