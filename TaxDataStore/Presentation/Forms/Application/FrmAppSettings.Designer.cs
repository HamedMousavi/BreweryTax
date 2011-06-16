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
            this.tbpRoles = new System.Windows.Forms.TabPage();
            this.tbpUsers = new System.Windows.Forms.TabPage();
            this.tbpCategories = new System.Windows.Forms.TabPage();
            this.tbpTourPayment = new System.Windows.Forms.TabPage();
            this.tbpDatabase = new System.Windows.Forms.TabPage();
            this.tbpUpdates = new System.Windows.Forms.TabPage();
            this.tabUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tbpRoles);
            this.tabUsers.Controls.Add(this.tbpUsers);
            this.tabUsers.Controls.Add(this.tbpCategories);
            this.tabUsers.Controls.Add(this.tbpTourPayment);
            this.tabUsers.Controls.Add(this.tbpDatabase);
            this.tabUsers.Controls.Add(this.tbpUpdates);
            this.tabUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabUsers.Location = new System.Drawing.Point(0, 0);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(517, 365);
            this.tabUsers.TabIndex = 0;
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
            // tbpTourPayment
            // 
            this.tbpTourPayment.Location = new System.Drawing.Point(4, 22);
            this.tbpTourPayment.Name = "tbpTourPayment";
            this.tbpTourPayment.Size = new System.Drawing.Size(509, 339);
            this.tbpTourPayment.TabIndex = 3;
            this.tbpTourPayment.Text = "Tour Payment";
            this.tbpTourPayment.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tbpRoles;
        private System.Windows.Forms.TabPage tbpUsers;
        private System.Windows.Forms.TabPage tbpTourPayment;
        private System.Windows.Forms.TabPage tbpDatabase;
        private System.Windows.Forms.TabPage tbpUpdates;
        private System.Windows.Forms.TabPage tbpCategories;

    }
}