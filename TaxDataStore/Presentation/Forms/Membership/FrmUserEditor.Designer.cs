namespace TaxDataStore
{
    partial class FrmUserEditor
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
            this.lblName = new System.Windows.Forms.Label();
            this.chbxIsEnabled = new System.Windows.Forms.CheckBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.chbxIsEnabled, 0, 0);
            this.tlpMain.Controls.Add(this.lblName, 0, 1);
            this.tlpMain.Controls.Add(this.tbxName, 1, 1);
            this.tlpMain.Controls.Add(this.cbxLanguage, 1, 3);
            this.tlpMain.Controls.Add(this.lblLanguage, 0, 3);
            this.tlpMain.Controls.Add(this.lblPassword, 0, 2);
            this.tlpMain.Controls.Add(this.tbxPassword, 1, 2);
            this.tlpMain.Controls.Add(this.lblRole, 0, 4);
            this.tlpMain.Controls.Add(this.cbxRole, 1, 4);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 6);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 8;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(277, 175);
            this.tlpMain.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // chbxIsEnabled
            // 
            this.chbxIsEnabled.AutoSize = true;
            this.chbxIsEnabled.Checked = true;
            this.chbxIsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpMain.SetColumnSpan(this.chbxIsEnabled, 2);
            this.chbxIsEnabled.Location = new System.Drawing.Point(3, 3);
            this.chbxIsEnabled.Name = "chbxIsEnabled";
            this.chbxIsEnabled.Size = new System.Drawing.Size(72, 20);
            this.chbxIsEnabled.TabIndex = 9;
            this.chbxIsEnabled.Text = "Enabled";
            this.chbxIsEnabled.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(72, 29);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(197, 23);
            this.tbxName.TabIndex = 1;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(3, 84);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(63, 16);
            this.lblLanguage.TabIndex = 4;
            this.lblLanguage.Text = "Language";
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Location = new System.Drawing.Point(72, 87);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(197, 24);
            this.cbxLanguage.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 55);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(72, 58);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(197, 23);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(3, 111);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(33, 16);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role";
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(72, 114);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(197, 24);
            this.cbxRole.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 141);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 32);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(199, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmUserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 175);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserEditor";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.CheckBox chbxIsEnabled;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

    }
}