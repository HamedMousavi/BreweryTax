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
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.btnEditTour = new System.Windows.Forms.Button();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.tlpTourDetails = new System.Windows.Forms.TableLayoutPanel();
            this.gpxTourDetails = new System.Windows.Forms.GroupBox();
            this.tlpEmployeeNotes = new System.Windows.Forms.TableLayoutPanel();
            this.gpxEmployees = new System.Windows.Forms.GroupBox();
            this.gpxNotes = new System.Windows.Forms.GroupBox();
            this.gpxTimeList = new System.Windows.Forms.GroupBox();
            this.tlpMain.SuspendLayout();
            this.tlpDate.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpTourDetails.SuspendLayout();
            this.tlpEmployeeNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpDate, 0, 0);
            this.tlpMain.Controls.Add(this.tlpTourDetails, 1, 1);
            this.tlpMain.Controls.Add(this.gpxTimeList, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(649, 456);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpDate
            // 
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
            this.tlpDate.Size = new System.Drawing.Size(649, 32);
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
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 32);
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
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(461, 32);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnAddTour
            // 
            this.btnAddTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTour.Location = new System.Drawing.Point(3, 3);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(100, 26);
            this.btnAddTour.TabIndex = 0;
            this.btnAddTour.Text = "Add tour";
            this.btnAddTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // btnEditTour
            // 
            this.btnEditTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditTour.Location = new System.Drawing.Point(109, 3);
            this.btnEditTour.Name = "btnEditTour";
            this.btnEditTour.Size = new System.Drawing.Size(100, 26);
            this.btnEditTour.TabIndex = 1;
            this.btnEditTour.Text = "Edit tour";
            this.btnEditTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTour.UseVisualStyleBackColor = true;
            this.btnEditTour.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTour.Location = new System.Drawing.Point(215, 3);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(100, 26);
            this.btnDeleteTour.TabIndex = 2;
            this.btnDeleteTour.Text = "Delete tour";
            this.btnDeleteTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteTour.UseVisualStyleBackColor = true;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // tlpTourDetails
            // 
            this.tlpTourDetails.ColumnCount = 1;
            this.tlpTourDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTourDetails.Controls.Add(this.gpxTourDetails, 0, 1);
            this.tlpTourDetails.Controls.Add(this.tlpEmployeeNotes, 0, 0);
            this.tlpTourDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTourDetails.Location = new System.Drawing.Point(160, 32);
            this.tlpTourDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTourDetails.Name = "tlpTourDetails";
            this.tlpTourDetails.RowCount = 2;
            this.tlpTourDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTourDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTourDetails.Size = new System.Drawing.Size(489, 424);
            this.tlpTourDetails.TabIndex = 1;
            // 
            // gpxTourDetails
            // 
            this.gpxTourDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxTourDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxTourDetails.Location = new System.Drawing.Point(3, 215);
            this.gpxTourDetails.Name = "gpxTourDetails";
            this.gpxTourDetails.Size = new System.Drawing.Size(483, 206);
            this.gpxTourDetails.TabIndex = 0;
            this.gpxTourDetails.TabStop = false;
            this.gpxTourDetails.Text = "Tour details";
            // 
            // tlpEmployeeNotes
            // 
            this.tlpEmployeeNotes.ColumnCount = 2;
            this.tlpEmployeeNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpEmployeeNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeNotes.Controls.Add(this.gpxEmployees, 0, 0);
            this.tlpEmployeeNotes.Controls.Add(this.gpxNotes, 1, 0);
            this.tlpEmployeeNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployeeNotes.Location = new System.Drawing.Point(3, 3);
            this.tlpEmployeeNotes.Name = "tlpEmployeeNotes";
            this.tlpEmployeeNotes.RowCount = 1;
            this.tlpEmployeeNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeNotes.Size = new System.Drawing.Size(483, 206);
            this.tlpEmployeeNotes.TabIndex = 1;
            // 
            // gpxEmployees
            // 
            this.gpxEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxEmployees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxEmployees.Location = new System.Drawing.Point(3, 3);
            this.gpxEmployees.Name = "gpxEmployees";
            this.gpxEmployees.Size = new System.Drawing.Size(154, 200);
            this.gpxEmployees.TabIndex = 0;
            this.gpxEmployees.TabStop = false;
            this.gpxEmployees.Text = "Employees";
            // 
            // gpxNotes
            // 
            this.gpxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxNotes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxNotes.Location = new System.Drawing.Point(163, 3);
            this.gpxNotes.Name = "gpxNotes";
            this.gpxNotes.Size = new System.Drawing.Size(317, 200);
            this.gpxNotes.TabIndex = 0;
            this.gpxNotes.TabStop = false;
            this.gpxNotes.Text = "Notes";
            // 
            // gpxTimeList
            // 
            this.gpxTimeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxTimeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpxTimeList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxTimeList.Location = new System.Drawing.Point(3, 35);
            this.gpxTimeList.Name = "gpxTimeList";
            this.gpxTimeList.Size = new System.Drawing.Size(154, 418);
            this.gpxTimeList.TabIndex = 4;
            this.gpxTimeList.TabStop = false;
            this.gpxTimeList.Text = "Time of day";
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
            this.tlpDate.ResumeLayout(false);
            this.tlpDate.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpTourDetails.ResumeLayout(false);
            this.tlpEmployeeNotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.Button btnEditTour;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.TableLayoutPanel tlpTourDetails;
        private System.Windows.Forms.GroupBox gpxTimeList;
        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gpxEmployees;
        private System.Windows.Forms.GroupBox gpxTourDetails;
        private System.Windows.Forms.TableLayoutPanel tlpEmployeeNotes;
        private System.Windows.Forms.GroupBox gpxNotes;
    }
}