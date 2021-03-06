﻿namespace TaxDataStore
{
    partial class FrmAppSettings
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
            this.tabUsers = new System.Windows.Forms.TabControl();
            this.tbpRoles = new System.Windows.Forms.TabPage();
            this.tbpUsers = new System.Windows.Forms.TabPage();
            this.tbpCategories = new System.Windows.Forms.TabPage();
            this.tbpTourCost = new System.Windows.Forms.TabPage();
            this.tbpDatabase = new System.Windows.Forms.TabPage();
            this.tbpUpdates = new System.Windows.Forms.TabPage();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabUsers.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsers
            // 
            this.tlpMain.SetColumnSpan(this.tabUsers, 2);
            this.tabUsers.Controls.Add(this.tbpRoles);
            this.tabUsers.Controls.Add(this.tbpUsers);
            this.tabUsers.Controls.Add(this.tbpCategories);
            this.tabUsers.Controls.Add(this.tbpTourCost);
            this.tabUsers.Controls.Add(this.tbpDatabase);
            this.tabUsers.Controls.Add(this.tbpUpdates);
            this.tabUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabUsers.Location = new System.Drawing.Point(3, 3);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(511, 359);
            this.tabUsers.TabIndex = 0;
            // 
            // tbpRoles
            // 
            this.tbpRoles.Location = new System.Drawing.Point(4, 22);
            this.tbpRoles.Name = "tbpRoles";
            this.tbpRoles.Size = new System.Drawing.Size(503, 333);
            this.tbpRoles.TabIndex = 1;
            this.tbpRoles.Text = "Roles";
            this.tbpRoles.UseVisualStyleBackColor = true;
            // 
            // tbpUsers
            // 
            this.tbpUsers.Location = new System.Drawing.Point(4, 22);
            this.tbpUsers.Name = "tbpUsers";
            this.tbpUsers.Size = new System.Drawing.Size(509, 339);
            this.tbpUsers.TabIndex = 2;
            this.tbpUsers.Text = "Users";
            this.tbpUsers.UseVisualStyleBackColor = true;
            // 
            // tbpCategories
            // 
            this.tbpCategories.Location = new System.Drawing.Point(4, 22);
            this.tbpCategories.Name = "tbpCategories";
            this.tbpCategories.Size = new System.Drawing.Size(509, 339);
            this.tbpCategories.TabIndex = 6;
            this.tbpCategories.Text = "Categories";
            this.tbpCategories.UseVisualStyleBackColor = true;
            // 
            // tbpTourCost
            // 
            this.tbpTourCost.Location = new System.Drawing.Point(4, 22);
            this.tbpTourCost.Name = "tbpTourCost";
            this.tbpTourCost.Size = new System.Drawing.Size(509, 339);
            this.tbpTourCost.TabIndex = 3;
            this.tbpTourCost.Text = "Tour Cost";
            this.tbpTourCost.UseVisualStyleBackColor = true;
            // 
            // tbpDatabase
            // 
            this.tbpDatabase.Location = new System.Drawing.Point(4, 22);
            this.tbpDatabase.Name = "tbpDatabase";
            this.tbpDatabase.Size = new System.Drawing.Size(509, 339);
            this.tbpDatabase.TabIndex = 4;
            this.tbpDatabase.Text = "Database";
            this.tbpDatabase.UseVisualStyleBackColor = true;
            // 
            // tbpUpdates
            // 
            this.tbpUpdates.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdates.Name = "tbpUpdates";
            this.tbpUpdates.Size = new System.Drawing.Size(509, 339);
            this.tbpUpdates.TabIndex = 5;
            this.tbpUpdates.Text = "Updates";
            this.tbpUpdates.UseVisualStyleBackColor = true;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.tabUsers, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(517, 365);
            this.tlpMain.TabIndex = 1;
            // 
            // FrmAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 365);
            this.Controls.Add(this.tlpMain);
            this.Name = "FrmAppSettings";
            this.Text = "FrmAppSettings";
            this.tabUsers.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsers;
        private System.Windows.Forms.TabPage tbpRoles;
        private System.Windows.Forms.TabPage tbpUsers;
        private System.Windows.Forms.TabPage tbpTourCost;
        private System.Windows.Forms.TabPage tbpDatabase;
        private System.Windows.Forms.TabPage tbpUpdates;
        private System.Windows.Forms.TabPage tbpCategories;
        private System.Windows.Forms.TableLayoutPanel tlpMain;

    }
}