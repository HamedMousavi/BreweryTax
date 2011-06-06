namespace TaxDataStore
{
    partial class FrmDailyTours
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
            this.gpxNotes = new System.Windows.Forms.GroupBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.gpxEmployees = new System.Windows.Forms.GroupBox();
            this.gpxTours = new System.Windows.Forms.GroupBox();
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.btnEditTour = new System.Windows.Forms.Button();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpxTourMembers = new System.Windows.Forms.GroupBox();
            this.gpxMemberContacts = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlpMain.SuspendLayout();
            this.gpxNotes.SuspendLayout();
            this.tlpDate.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.White;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gpxNotes, 1, 3);
            this.tlpMain.Controls.Add(this.gpxEmployees, 0, 3);
            this.tlpMain.Controls.Add(this.gpxTours, 0, 1);
            this.tlpMain.Controls.Add(this.tlpDate, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpMain.Size = new System.Drawing.Size(649, 456);
            this.tlpMain.TabIndex = 0;
            // 
            // gpxNotes
            // 
            this.gpxNotes.Controls.Add(this.rtbComments);
            this.gpxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxNotes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxNotes.Location = new System.Drawing.Point(163, 365);
            this.gpxNotes.Name = "gpxNotes";
            this.gpxNotes.Size = new System.Drawing.Size(483, 88);
            this.gpxNotes.TabIndex = 6;
            this.gpxNotes.TabStop = false;
            this.gpxNotes.Text = "Notes";
            // 
            // rtbComments
            // 
            this.rtbComments.BackColor = System.Drawing.Color.White;
            this.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbComments.Location = new System.Drawing.Point(3, 18);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.ReadOnly = true;
            this.rtbComments.Size = new System.Drawing.Size(477, 67);
            this.rtbComments.TabIndex = 0;
            this.rtbComments.Text = "";
            // 
            // gpxEmployees
            // 
            this.gpxEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxEmployees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxEmployees.Location = new System.Drawing.Point(3, 365);
            this.gpxEmployees.Name = "gpxEmployees";
            this.gpxEmployees.Size = new System.Drawing.Size(154, 88);
            this.gpxEmployees.TabIndex = 0;
            this.gpxEmployees.TabStop = false;
            this.gpxEmployees.Text = "Employees";
            // 
            // gpxTours
            // 
            this.tlpMain.SetColumnSpan(this.gpxTours, 2);
            this.gpxTours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxTours.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxTours.Location = new System.Drawing.Point(3, 38);
            this.gpxTours.Name = "gpxTours";
            this.gpxTours.Size = new System.Drawing.Size(643, 181);
            this.gpxTours.TabIndex = 0;
            this.gpxTours.TabStop = false;
            this.gpxTours.Text = "Tours";
            // 
            // tlpDate
            // 
            this.tlpDate.BackColor = System.Drawing.Color.LightGray;
            this.tlpDate.ColumnCount = 4;
            this.tlpMain.SetColumnSpan(this.tlpDate, 2);
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.Controls.Add(this.dtpCurrentDate, 1, 0);
            this.tlpDate.Controls.Add(this.lblDate, 0, 0);
            this.tlpDate.Controls.Add(this.tlpButtons, 2, 0);
            this.tlpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDate.Location = new System.Drawing.Point(0, 0);
            this.tlpDate.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDate.Name = "tlpDate";
            this.tlpDate.RowCount = 1;
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.Size = new System.Drawing.Size(649, 35);
            this.tlpDate.TabIndex = 5;
            // 
            // dtpCurrentDate
            // 
            this.dtpCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCurrentDate.Location = new System.Drawing.Point(45, 5);
            this.dtpCurrentDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.Size = new System.Drawing.Size(112, 22);
            this.dtpCurrentDate.TabIndex = 3;
            this.dtpCurrentDate.ValueChanged += new System.EventHandler(this.dtpCurrentDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 35);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnAddTour, 0, 0);
            this.tlpButtons.Controls.Add(this.btnEditTour, 1, 0);
            this.tlpButtons.Controls.Add(this.btnDeleteTour, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(160, 0);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.Padding = new System.Windows.Forms.Padding(3);
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(461, 35);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnAddTour
            // 
            this.btnAddTour.AutoSize = true;
            this.btnAddTour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAddTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTour.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnAddTour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddTour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTour.ForeColor = System.Drawing.Color.Black;
            this.btnAddTour.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddTour.Location = new System.Drawing.Point(3, 3);
            this.btnAddTour.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddTour.Size = new System.Drawing.Size(72, 29);
            this.btnAddTour.TabIndex = 0;
            this.btnAddTour.Text = "Add tour";
            this.btnAddTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTour.UseVisualStyleBackColor = false;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // btnEditTour
            // 
            this.btnEditTour.AutoSize = true;
            this.btnEditTour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEditTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditTour.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnEditTour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditTour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTour.ForeColor = System.Drawing.Color.Black;
            this.btnEditTour.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditTour.Location = new System.Drawing.Point(75, 3);
            this.btnEditTour.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditTour.Name = "btnEditTour";
            this.btnEditTour.Padding = new System.Windows.Forms.Padding(2);
            this.btnEditTour.Size = new System.Drawing.Size(71, 29);
            this.btnEditTour.TabIndex = 1;
            this.btnEditTour.Text = "Edit tour";
            this.btnEditTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTour.UseVisualStyleBackColor = false;
            this.btnEditTour.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.AutoSize = true;
            this.btnDeleteTour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteTour.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnDeleteTour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteTour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTour.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTour.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteTour.Location = new System.Drawing.Point(146, 3);
            this.btnDeleteTour.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Padding = new System.Windows.Forms.Padding(2);
            this.btnDeleteTour.Size = new System.Drawing.Size(86, 29);
            this.btnDeleteTour.TabIndex = 2;
            this.btnDeleteTour.Text = "Delete tour";
            this.btnDeleteTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteTour.UseVisualStyleBackColor = false;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.gpxTourMembers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpxMemberContacts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 222);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 140);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gpxTourMembers
            // 
            this.gpxTourMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxTourMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpxTourMembers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxTourMembers.Location = new System.Drawing.Point(3, 3);
            this.gpxTourMembers.Name = "gpxTourMembers";
            this.gpxTourMembers.Size = new System.Drawing.Size(156, 134);
            this.gpxTourMembers.TabIndex = 5;
            this.gpxTourMembers.TabStop = false;
            this.gpxTourMembers.Text = "Tour members";
            // 
            // gpxMemberContacts
            // 
            this.gpxMemberContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxMemberContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpxMemberContacts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxMemberContacts.Location = new System.Drawing.Point(165, 3);
            this.gpxMemberContacts.Name = "gpxMemberContacts";
            this.gpxMemberContacts.Size = new System.Drawing.Size(221, 134);
            this.gpxMemberContacts.TabIndex = 5;
            this.gpxMemberContacts.TabStop = false;
            this.gpxMemberContacts.Text = "Member contacts";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(392, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 134);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour payments";
            // 
            // FrmDailyTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 456);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmDailyTours";
            this.Text = "Daily tours";
            this.tlpMain.ResumeLayout(false);
            this.gpxNotes.ResumeLayout(false);
            this.tlpDate.ResumeLayout(false);
            this.tlpDate.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.Button btnEditTour;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gpxEmployees;
        private System.Windows.Forms.GroupBox gpxTours;
        private System.Windows.Forms.GroupBox gpxNotes;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gpxTourMembers;
        private System.Windows.Forms.GroupBox gpxMemberContacts;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}