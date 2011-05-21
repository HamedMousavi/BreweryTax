namespace TaxDataStore
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
            this.tbpGeneral = new System.Windows.Forms.TabPage();
            this.tbpUsers = new System.Windows.Forms.TabPage();
            this.tbpRoles = new System.Windows.Forms.TabPage();
            this.tabUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tbpGeneral);
            this.tabUsers.Controls.Add(this.tbpUsers);
            this.tabUsers.Controls.Add(this.tbpRoles);
            this.tabUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsers.Location = new System.Drawing.Point(0, 0);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(517, 365);
            this.tabUsers.TabIndex = 0;
            // 
            // tbpGeneral
            // 
            this.tbpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbpGeneral.Name = "tbpGeneral";
            this.tbpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeneral.Size = new System.Drawing.Size(509, 339);
            this.tbpGeneral.TabIndex = 0;
            this.tbpGeneral.Text = "General";
            this.tbpGeneral.UseVisualStyleBackColor = true;
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
            // tbpRoles
            // 
            this.tbpRoles.Location = new System.Drawing.Point(4, 22);
            this.tbpRoles.Name = "tbpRoles";
            this.tbpRoles.Size = new System.Drawing.Size(509, 339);
            this.tbpRoles.TabIndex = 1;
            this.tbpRoles.Text = "Roles";
            this.tbpRoles.UseVisualStyleBackColor = true;
            // 
            // FrmAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 365);
            this.Controls.Add(this.tabUsers);
            this.Name = "FrmAppSettings";
            this.Text = "FrmAppSettings";
            this.tabUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsers;
        private System.Windows.Forms.TabPage tbpGeneral;
        private System.Windows.Forms.TabPage tbpRoles;
        private System.Windows.Forms.TabPage tbpUsers;

    }
}