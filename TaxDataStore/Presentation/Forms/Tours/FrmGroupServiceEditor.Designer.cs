namespace TaxDataStore
{
    partial class FrmGroupServiceEditor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sbbMain = new TaxDataStore.Presentation.Controls.SaveButtonBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgDetails = new System.Windows.Forms.TabPage();
            this.tpgBill = new System.Windows.Forms.TabPage();
            this.tpgPayment = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sbbMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // saveButtonBar1
            // 
            this.sbbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sbbMain.AutoSize = true;
            this.sbbMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbbMain.Location = new System.Drawing.Point(3, 230);
            this.sbbMain.Name = "saveButtonBar1";
            this.sbbMain.Size = new System.Drawing.Size(278, 29);
            this.sbbMain.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgDetails);
            this.tabControl1.Controls.Add(this.tpgBill);
            this.tabControl1.Controls.Add(this.tpgPayment);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(278, 221);
            this.tabControl1.TabIndex = 1;
            // 
            // tpgDetails
            // 
            this.tpgDetails.Location = new System.Drawing.Point(4, 22);
            this.tpgDetails.Name = "tpgDetails";
            this.tpgDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDetails.Size = new System.Drawing.Size(270, 195);
            this.tpgDetails.TabIndex = 0;
            this.tpgDetails.Text = "Details";
            this.tpgDetails.UseVisualStyleBackColor = true;
            // 
            // tpgBill
            // 
            this.tpgBill.Location = new System.Drawing.Point(4, 22);
            this.tpgBill.Name = "tpgBill";
            this.tpgBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBill.Size = new System.Drawing.Size(270, 195);
            this.tpgBill.TabIndex = 1;
            this.tpgBill.Text = "Bill";
            this.tpgBill.UseVisualStyleBackColor = true;
            // 
            // tpgPayment
            // 
            this.tpgPayment.Location = new System.Drawing.Point(4, 22);
            this.tpgPayment.Name = "tpgPayment";
            this.tpgPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPayment.Size = new System.Drawing.Size(270, 195);
            this.tpgPayment.TabIndex = 2;
            this.tpgPayment.Text = "Payment";
            this.tpgPayment.UseVisualStyleBackColor = true;
            // 
            // FrmGroupServiceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGroupServiceEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGroupServiceEditor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Presentation.Controls.SaveButtonBar sbbMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgDetails;
        private System.Windows.Forms.TabPage tpgBill;
        private System.Windows.Forms.TabPage tpgPayment;
    }
}