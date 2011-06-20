using TaxDataStore.Presentation.Controls;
namespace TaxDataStore
{
    partial class FrmPasswordEditor
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
            this.tlpPassword = new System.Windows.Forms.TableLayoutPanel();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.tbxOldPass = new System.Windows.Forms.TextBox();
            this.tbxNewPass = new System.Windows.Forms.TextBox();
            this.tbxConfirmPass = new System.Windows.Forms.TextBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new ButtonBase();
            this.btnSave = new ButtonBase();
            this.tlpPassword.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPassword
            // 
            this.tlpPassword.ColumnCount = 2;
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPassword.Controls.Add(this.tlpButtons, 0, 4);
            this.tlpPassword.Controls.Add(this.lblOldPass, 0, 0);
            this.tlpPassword.Controls.Add(this.lblNewPass, 0, 1);
            this.tlpPassword.Controls.Add(this.lblConfirmPass, 0, 2);
            this.tlpPassword.Controls.Add(this.tbxOldPass, 1, 0);
            this.tlpPassword.Controls.Add(this.tbxNewPass, 1, 1);
            this.tlpPassword.Controls.Add(this.tbxConfirmPass, 1, 2);
            this.tlpPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPassword.Location = new System.Drawing.Point(0, 0);
            this.tlpPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpPassword.Name = "tlpPassword";
            this.tlpPassword.RowCount = 5;
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPassword.Size = new System.Drawing.Size(307, 142);
            this.tlpPassword.TabIndex = 1;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(3, 0);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(80, 14);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Old Password";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(3, 30);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(87, 14);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "New Password";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(3, 60);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(103, 14);
            this.lblConfirmPass.TabIndex = 2;
            this.lblConfirmPass.Text = "Confirm password";
            // 
            // tbxOldPass
            // 
            this.tbxOldPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOldPass.Location = new System.Drawing.Point(112, 4);
            this.tbxOldPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxOldPass.Name = "tbxOldPass";
            this.tbxOldPass.Size = new System.Drawing.Size(192, 22);
            this.tbxOldPass.TabIndex = 3;
            this.tbxOldPass.UseSystemPasswordChar = true;
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNewPass.Location = new System.Drawing.Point(112, 34);
            this.tbxNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.Size = new System.Drawing.Size(192, 22);
            this.tbxNewPass.TabIndex = 4;
            this.tbxNewPass.UseSystemPasswordChar = true;
            // 
            // tbxConfirmPass
            // 
            this.tbxConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxConfirmPass.Location = new System.Drawing.Point(112, 64);
            this.tbxConfirmPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxConfirmPass.Name = "tbxConfirmPass";
            this.tbxConfirmPass.Size = new System.Drawing.Size(192, 22);
            this.tbxConfirmPass.TabIndex = 5;
            this.tbxConfirmPass.UseSystemPasswordChar = true;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 3;
            this.tlpPassword.SetColumnSpan(this.tlpButtons, 2);
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tlpButtons.Controls.Add(this.btnSave, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 103);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtons.Size = new System.Drawing.Size(301, 35);
            this.tlpButtons.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmPasswordEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 142);
            this.Controls.Add(this.tlpPassword);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPasswordEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Editor";
            this.tlpPassword.ResumeLayout(false);
            this.tlpPassword.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPassword;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private ButtonBase btnCancel;
        private ButtonBase btnSave;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox tbxOldPass;
        private System.Windows.Forms.TextBox tbxNewPass;
        private System.Windows.Forms.TextBox tbxConfirmPass;
    }
}