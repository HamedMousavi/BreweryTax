﻿namespace TaxDataStore
{
    partial class ToursListView
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
            this.flpTours = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpTours
            // 
            this.flpTours.AutoScroll = true;
            this.flpTours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTours.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTours.Location = new System.Drawing.Point(0, 0);
            this.flpTours.Name = "flpTours";
            this.flpTours.Size = new System.Drawing.Size(314, 199);
            this.flpTours.TabIndex = 0;
            // 
            // ToursListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpTours);
            this.Name = "ToursListView";
            this.Size = new System.Drawing.Size(314, 199);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTours;
    }
}
