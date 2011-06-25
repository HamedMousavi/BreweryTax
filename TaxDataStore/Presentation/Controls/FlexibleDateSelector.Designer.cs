namespace TaxDataStore.Presentation.Controls
{
    partial class ConstraintDateSelector
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.cbxMonths = new System.Windows.Forms.ComboBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.ColumnCount = 7;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblYear, 0, 0);
            this.tlpMain.Controls.Add(this.cbxYear, 1, 0);
            this.tlpMain.Controls.Add(this.lblMonth, 2, 0);
            this.tlpMain.Controls.Add(this.cbxMonths, 3, 0);
            this.tlpMain.Controls.Add(this.Daylbl, 4, 0);
            this.tlpMain.Controls.Add(this.cbxDay, 5, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(446, 53);
            this.tlpMain.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(3, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Items.AddRange(new object[] {
            "Any year"});
            this.cbxYear.Location = new System.Drawing.Point(38, 3);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(90, 21);
            this.cbxYear.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(134, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month";
            // 
            // cbxMonths
            // 
            this.cbxMonths.FormattingEnabled = true;
            this.cbxMonths.Items.AddRange(new object[] {
            "Any month",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxMonths.Location = new System.Drawing.Point(177, 3);
            this.cbxMonths.Name = "cbxMonths";
            this.cbxMonths.Size = new System.Drawing.Size(90, 21);
            this.cbxMonths.TabIndex = 3;
            // 
            // Daylbl
            // 
            this.Daylbl.AutoSize = true;
            this.Daylbl.Location = new System.Drawing.Point(273, 0);
            this.Daylbl.Name = "Daylbl";
            this.Daylbl.Size = new System.Drawing.Size(26, 13);
            this.Daylbl.TabIndex = 4;
            this.Daylbl.Text = "Day";
            // 
            // cbxDay
            // 
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "AnyDay",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDay.Location = new System.Drawing.Point(305, 3);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(90, 21);
            this.cbxDay.TabIndex = 5;
            // 
            // FlexibleDateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "FlexibleDateSelector";
            this.Size = new System.Drawing.Size(446, 53);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private FormLabel lblYear;
        private System.Windows.Forms.ComboBox cbxYear;
        private FormLabel lblMonth;
        private System.Windows.Forms.ComboBox cbxMonths;
        private FormLabel Daylbl;
        private System.Windows.Forms.ComboBox cbxDay;
    }
}
