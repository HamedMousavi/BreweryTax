namespace TaxDataStore
{
    partial class FrmMonthlyReportInfo
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblFrom, 0, 0);
            this.tlpMain.Controls.Add(this.lblTo, 0, 1);
            this.tlpMain.Controls.Add(this.dtpStartDate, 1, 0);
            this.tlpMain.Controls.Add(this.dtpEndDate, 1, 1);
            this.tlpMain.Controls.Add(this.lblFilePath, 0, 2);
            this.tlpMain.Controls.Add(this.tbxDestination, 1, 2);
            this.tlpMain.Controls.Add(this.btnBrowse, 2, 2);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(496, 183);
            this.tlpMain.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(34, 14);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(3, 28);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 14);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CustomFormat = "MMMM";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(58, 3);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowUpDown = true;
            this.dtpStartDate.Size = new System.Drawing.Size(342, 22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.CustomFormat = "MMMM";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(58, 31);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowUpDown = true;
            this.dtpEndDate.Size = new System.Drawing.Size(342, 22);
            this.dtpEndDate.TabIndex = 3;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(3, 56);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(49, 14);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "Save to";
            // 
            // tbxDestination
            // 
            this.tbxDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDestination.Location = new System.Drawing.Point(58, 59);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(342, 22);
            this.tbxDestination.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(406, 59);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(87, 25);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.AutoSize = true;
            this.tlpButtons.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tlpButtons, 3);
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tlpButtons.Controls.Add(this.btnSave, 1, 0);
            this.tlpButtons.Location = new System.Drawing.Point(3, 149);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(490, 31);
            this.tlpButtons.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmMonthlyReportInfo
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 183);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMonthlyReportInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MonthlyReportInfo";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}