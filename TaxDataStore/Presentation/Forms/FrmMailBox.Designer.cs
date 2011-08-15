namespace TaxDataStore
{
    partial class FrmMailBox
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbpToday = new System.Windows.Forms.TabPage();
            this.mbxToday = new TaxDataStore.Presentation.Controls.Mailbox();
            this.tbpAll = new System.Windows.Forms.TabPage();
            this.mbxAll = new TaxDataStore.Presentation.Controls.Mailbox();
            this.tlpMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbpToday.SuspendLayout();
            this.tbpAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.tabMain, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(594, 467);
            this.tlpMain.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tlpMain.SetColumnSpan(this.tabMain, 2);
            this.tabMain.Controls.Add(this.tbpToday);
            this.tabMain.Controls.Add(this.tbpAll);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(588, 461);
            this.tabMain.TabIndex = 0;
            // 
            // tbpToday
            // 
            this.tbpToday.Controls.Add(this.mbxToday);
            this.tbpToday.Location = new System.Drawing.Point(4, 22);
            this.tbpToday.Name = "tbpToday";
            this.tbpToday.Padding = new System.Windows.Forms.Padding(3);
            this.tbpToday.Size = new System.Drawing.Size(580, 435);
            this.tbpToday.TabIndex = 0;
            this.tbpToday.Text = "Today";
            this.tbpToday.UseVisualStyleBackColor = true;
            // 
            // mbxToday
            // 
            this.mbxToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbxToday.Location = new System.Drawing.Point(3, 3);
            this.mbxToday.Name = "mbxToday";
            this.mbxToday.Size = new System.Drawing.Size(574, 429);
            this.mbxToday.TabIndex = 0;
            // 
            // tbpAll
            // 
            this.tbpAll.Controls.Add(this.mbxAll);
            this.tbpAll.Location = new System.Drawing.Point(4, 22);
            this.tbpAll.Name = "tbpAll";
            this.tbpAll.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAll.Size = new System.Drawing.Size(580, 435);
            this.tbpAll.TabIndex = 1;
            this.tbpAll.Text = "All";
            this.tbpAll.UseVisualStyleBackColor = true;
            // 
            // mbxAll
            // 
            this.mbxAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbxAll.Location = new System.Drawing.Point(3, 3);
            this.mbxAll.Name = "mbxAll";
            this.mbxAll.Size = new System.Drawing.Size(574, 429);
            this.mbxAll.TabIndex = 1;
            // 
            // FrmMailBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 467);
            this.Controls.Add(this.tlpMain);
            this.Name = "FrmMailBox";
            this.Text = "FrmMailBox";
            this.tlpMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbpToday.ResumeLayout(false);
            this.tbpAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbpToday;
        private System.Windows.Forms.TabPage tbpAll;
        private Presentation.Controls.Mailbox mbxToday;
        private Presentation.Controls.Mailbox mbxAll;
    }
}