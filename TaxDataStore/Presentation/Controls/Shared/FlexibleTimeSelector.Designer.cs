﻿namespace TaxDataStore.Presentation.Controls
{
    partial class FlexibleTimeSelector
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
            this.cbxHour = new System.Windows.Forms.ComboBox();
            this.cbxMinute = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.ColumnCount = 7;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.cbxHour, 1, 0);
            this.tlpMain.Controls.Add(this.cbxMinute, 3, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(432, 47);
            this.tlpMain.TabIndex = 3;
            // 
            // cbxHour
            // 
            this.cbxHour.FormattingEnabled = true;
            this.cbxHour.Items.AddRange(new object[] {
            "Any Hour"});
            this.cbxHour.Location = new System.Drawing.Point(39, 3);
            this.cbxHour.Name = "cbxHour";
            this.cbxHour.Size = new System.Drawing.Size(90, 21);
            this.cbxHour.TabIndex = 1;
            // 
            // cbxMinute
            // 
            this.cbxMinute.FormattingEnabled = true;
            this.cbxMinute.Items.AddRange(new object[] {
            "Any minute"});
            this.cbxMinute.Location = new System.Drawing.Point(180, 3);
            this.cbxMinute.Name = "cbxMinute";
            this.cbxMinute.Size = new System.Drawing.Size(90, 21);
            this.cbxMinute.TabIndex = 3;
            // 
            // FlexibleTimeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "FlexibleTimeSelector";
            this.Size = new System.Drawing.Size(432, 47);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ComboBox cbxHour;
        private System.Windows.Forms.ComboBox cbxMinute;
    }
}
