namespace TaxDataStore
{
    partial class RoleManager
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
            this.mnuRoles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gpxRoles = new System.Windows.Forms.GroupBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.gpxTasks = new System.Windows.Forms.GroupBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.mnuRoles.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.gpxTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRoles
            // 
            this.mnuRoles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.mnuRoles.Name = "mnuRoles";
            this.mnuRoles.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.Controls.Add(this.gpxRoles, 0, 0);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpMain.Controls.Add(this.gpxTasks, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.Size = new System.Drawing.Size(557, 481);
            this.tlpMain.TabIndex = 1;
            // 
            // gpxRoles
            // 
            this.gpxRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxRoles.Location = new System.Drawing.Point(3, 3);
            this.gpxRoles.Name = "gpxRoles";
            this.gpxRoles.Size = new System.Drawing.Size(161, 443);
            this.gpxRoles.TabIndex = 0;
            this.gpxRoles.TabStop = false;
            this.gpxRoles.Text = "Roles";
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 4;
            this.tlpMain.SetColumnSpan(this.tlpButtons, 2);
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Controls.Add(this.btnAddRole, 0, 0);
            this.tlpButtons.Controls.Add(this.btnEditRole, 1, 0);
            this.tlpButtons.Controls.Add(this.btnDeleteRole, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(0, 449);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(557, 32);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(3, 3);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(75, 26);
            this.btnAddRole.TabIndex = 0;
            this.btnAddRole.Text = "Add";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnEditRole
            // 
            this.btnEditRole.Location = new System.Drawing.Point(84, 3);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(75, 26);
            this.btnEditRole.TabIndex = 1;
            this.btnEditRole.Text = "Edit";
            this.btnEditRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditRole.UseVisualStyleBackColor = true;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(165, 3);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(75, 26);
            this.btnDeleteRole.TabIndex = 2;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // gpxTasks
            // 
            this.gpxTasks.Controls.Add(this.lblComment);
            this.gpxTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxTasks.Location = new System.Drawing.Point(170, 3);
            this.gpxTasks.Name = "gpxTasks";
            this.gpxTasks.Size = new System.Drawing.Size(384, 443);
            this.gpxTasks.TabIndex = 1;
            this.gpxTasks.TabStop = false;
            this.gpxTasks.Text = "Tasks";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblComment.ForeColor = System.Drawing.Color.Red;
            this.lblComment.Location = new System.Drawing.Point(6, 16);
            this.lblComment.MaximumSize = new System.Drawing.Size(300, 1024);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(0, 14);
            this.lblComment.TabIndex = 0;
            // 
            // RoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "RoleManager";
            this.Size = new System.Drawing.Size(557, 481);
            this.mnuRoles.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.gpxTasks.ResumeLayout(false);
            this.gpxTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mnuRoles;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gpxRoles;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.GroupBox gpxTasks;
        private System.Windows.Forms.Label lblComment;
    }
}
