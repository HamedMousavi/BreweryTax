﻿namespace TaxDataStore
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gpxUsers = new System.Windows.Forms.GroupBox();
            this.gpxDetails = new System.Windows.Forms.GroupBox();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblRoleNameValue = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIsEnabled = new System.Windows.Forms.Label();
            this.lblLanguageValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEnableUser = new System.Windows.Forms.Button();
            this.mnuUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain.SuspendLayout();
            this.gpxDetails.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.mnuUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.Controls.Add(this.gpxUsers, 0, 0);
            this.tlpMain.Controls.Add(this.gpxDetails, 1, 0);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.Size = new System.Drawing.Size(525, 475);
            this.tlpMain.TabIndex = 0;
            // 
            // gpxUsers
            // 
            this.gpxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxUsers.Location = new System.Drawing.Point(3, 3);
            this.gpxUsers.Name = "gpxUsers";
            this.gpxUsers.Size = new System.Drawing.Size(151, 437);
            this.gpxUsers.TabIndex = 0;
            this.gpxUsers.TabStop = false;
            this.gpxUsers.Text = "Users";
            // 
            // gpxDetails
            // 
            this.gpxDetails.Controls.Add(this.tlpDetails);
            this.gpxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxDetails.Location = new System.Drawing.Point(160, 3);
            this.gpxDetails.Name = "gpxDetails";
            this.gpxDetails.Size = new System.Drawing.Size(362, 437);
            this.gpxDetails.TabIndex = 1;
            this.gpxDetails.TabStop = false;
            this.gpxDetails.Text = "Details";
            // 
            // tlpDetails
            // 
            this.tlpDetails.ColumnCount = 2;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.lblRoleName, 0, 3);
            this.tlpDetails.Controls.Add(this.lblRoleNameValue, 1, 3);
            this.tlpDetails.Controls.Add(this.lblLanguage, 0, 2);
            this.tlpDetails.Controls.Add(this.lblName, 0, 1);
            this.tlpDetails.Controls.Add(this.lblIsEnabled, 0, 0);
            this.tlpDetails.Controls.Add(this.lblLanguageValue, 1, 2);
            this.tlpDetails.Controls.Add(this.lblNameValue, 1, 1);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpDetails.Location = new System.Drawing.Point(3, 16);
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
            this.tlpDetails.Size = new System.Drawing.Size(356, 418);
            this.tlpDetails.TabIndex = 0;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRoleName.ForeColor = System.Drawing.Color.Gray;
            this.lblRoleName.Location = new System.Drawing.Point(3, 42);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(34, 14);
            this.lblRoleName.TabIndex = 5;
            this.lblRoleName.Text = "Role";
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
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLanguage.ForeColor = System.Drawing.Color.Gray;
            this.lblLanguage.Location = new System.Drawing.Point(3, 28);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(67, 14);
            this.lblLanguage.TabIndex = 3;
            this.lblLanguage.Text = "Language";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(3, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 14);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblIsEnabled
            // 
            this.lblIsEnabled.AutoSize = true;
            this.tlpDetails.SetColumnSpan(this.lblIsEnabled, 2);
            this.lblIsEnabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIsEnabled.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblIsEnabled.Location = new System.Drawing.Point(3, 0);
            this.lblIsEnabled.MaximumSize = new System.Drawing.Size(400, 1024);
            this.lblIsEnabled.Name = "lblIsEnabled";
            this.lblIsEnabled.Size = new System.Drawing.Size(98, 14);
            this.lblIsEnabled.TabIndex = 0;
            this.lblIsEnabled.Text = "User is enabled";
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
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 5;
            this.tlpMain.SetColumnSpan(this.tlpButtons, 2);
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Controls.Add(this.btnAddUser, 0, 0);
            this.tlpButtons.Controls.Add(this.btnEditUser, 1, 0);
            this.tlpButtons.Controls.Add(this.btnDeleteUser, 2, 0);
            this.tlpButtons.Controls.Add(this.btnEnableUser, 3, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(0, 443);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(525, 32);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(3, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 26);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(84, 3);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 26);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(165, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 26);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEnableUser
            // 
            this.btnEnableUser.Location = new System.Drawing.Point(246, 3);
            this.btnEnableUser.Name = "btnEnableUser";
            this.btnEnableUser.Size = new System.Drawing.Size(75, 26);
            this.btnEnableUser.TabIndex = 3;
            this.btnEnableUser.Text = "Enable";
            this.btnEnableUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnableUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnableUser.UseVisualStyleBackColor = true;
            this.btnEnableUser.Click += new System.EventHandler(this.btnEnableUser_Click);
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
            // UsersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "UsersManager";
            this.Size = new System.Drawing.Size(525, 475);
            this.tlpMain.ResumeLayout(false);
            this.gpxDetails.ResumeLayout(false);
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.mnuUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gpxUsers;
        private System.Windows.Forms.GroupBox gpxDetails;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEnableUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblIsEnabled;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblLanguageValue;
        private System.Windows.Forms.Label lblRoleNameValue;
        private System.Windows.Forms.ContextMenuStrip mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;

    }
}
