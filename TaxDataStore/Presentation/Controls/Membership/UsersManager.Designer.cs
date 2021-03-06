﻿using TaxDataStore.Presentation.Controls;
namespace TaxDataStore
{
    partial class UsersManager
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
            this.components = new System.ComponentModel.Container();
            this.mnuUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblLanguageValue = new System.Windows.Forms.Label();
            this.lblRoleNameValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.mnuUsers.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUsers
            // 
            this.mnuUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.enableToolStripMenuItem});
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(110, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.White;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 0);
            this.tlpMain.Controls.Add(this.tlpDetails, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(519, 469);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 6;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(233, 32);
            this.tlpButtons.TabIndex = 2;
            // 
            // tlpDetails
            // 
            this.tlpDetails.BackColor = System.Drawing.Color.White;
            this.tlpDetails.ColumnCount = 2;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.lblRoleNameValue, 1, 3);
            this.tlpDetails.Controls.Add(this.lblLanguageValue, 1, 2);
            this.tlpDetails.Controls.Add(this.lblNameValue, 1, 1);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpDetails.Location = new System.Drawing.Point(233, 35);
            this.tlpDetails.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.RowCount = 9;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Size = new System.Drawing.Size(283, 431);
            this.tlpDetails.TabIndex = 4;
            // 
            // lblRoleNameValue
            // 
            this.lblRoleNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRoleNameValue.AutoSize = true;
            this.lblRoleNameValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleNameValue.Location = new System.Drawing.Point(76, 42);
            this.lblRoleNameValue.Name = "lblRoleNameValue";
            this.lblRoleNameValue.Size = new System.Drawing.Size(0, 14);
            this.lblRoleNameValue.TabIndex = 6;
            this.lblRoleNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLanguageValue
            // 
            this.lblLanguageValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLanguageValue.AutoSize = true;
            this.lblLanguageValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguageValue.Location = new System.Drawing.Point(76, 28);
            this.lblLanguageValue.Name = "lblLanguageValue";
            this.lblLanguageValue.Size = new System.Drawing.Size(0, 14);
            this.lblLanguageValue.TabIndex = 4;
            this.lblLanguageValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameValue
            // 
            this.lblNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValue.Location = new System.Drawing.Point(76, 14);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(0, 14);
            this.lblNameValue.TabIndex = 2;
            this.lblNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "UsersManager";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(525, 475);
            this.mnuUsers.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ContainerLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.ContextMenuStrip mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Label lblRoleNameValue;
        private System.Windows.Forms.Label lblLanguageValue;
        private System.Windows.Forms.Label lblNameValue;

    }
}
