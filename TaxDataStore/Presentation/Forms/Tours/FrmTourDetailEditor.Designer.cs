namespace TaxDataStore
{
    partial class FrmTourDetailEditor
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
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblSignupType = new System.Windows.Forms.Label();
            this.cbxSignupType = new System.Windows.Forms.ComboBox();
            this.tbxGuestName = new System.Windows.Forms.TextBox();
            this.lblInvitationCount = new System.Windows.Forms.Label();
            this.lblParticipantsCount = new System.Windows.Forms.Label();
            this.lblTourType = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblPricePerPerson = new System.Windows.Forms.Label();
            this.tbxInvitationCount = new System.Windows.Forms.TextBox();
            this.tbxParticipantsCount = new System.Windows.Forms.TextBox();
            this.cbxTourType = new System.Windows.Forms.ComboBox();
            this.cbxPaymentType = new System.Windows.Forms.ComboBox();
            this.tbxPricePerPerson = new System.Windows.Forms.TextBox();
            this.tkpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tkpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblGuestName, 0, 0);
            this.tlpMain.Controls.Add(this.lblSignupType, 0, 1);
            this.tlpMain.Controls.Add(this.cbxSignupType, 1, 1);
            this.tlpMain.Controls.Add(this.tbxGuestName, 1, 0);
            this.tlpMain.Controls.Add(this.lblInvitationCount, 0, 2);
            this.tlpMain.Controls.Add(this.lblParticipantsCount, 0, 3);
            this.tlpMain.Controls.Add(this.lblTourType, 0, 4);
            this.tlpMain.Controls.Add(this.lblPaymentType, 0, 5);
            this.tlpMain.Controls.Add(this.lblPricePerPerson, 0, 6);
            this.tlpMain.Controls.Add(this.tbxInvitationCount, 1, 2);
            this.tlpMain.Controls.Add(this.tbxParticipantsCount, 1, 3);
            this.tlpMain.Controls.Add(this.cbxTourType, 1, 4);
            this.tlpMain.Controls.Add(this.cbxPaymentType, 1, 5);
            this.tlpMain.Controls.Add(this.tbxPricePerPerson, 1, 6);
            this.tlpMain.Controls.Add(this.tkpButtons, 0, 8);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 9;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(325, 230);
            this.tlpMain.TabIndex = 0;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(3, 0);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(73, 14);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest name";
            // 
            // lblSignupType
            // 
            this.lblSignupType.AutoSize = true;
            this.lblSignupType.Location = new System.Drawing.Point(3, 28);
            this.lblSignupType.Name = "lblSignupType";
            this.lblSignupType.Size = new System.Drawing.Size(73, 14);
            this.lblSignupType.TabIndex = 2;
            this.lblSignupType.Text = "Signup type";
            // 
            // cbxSignupType
            // 
            this.cbxSignupType.FormattingEnabled = true;
            this.cbxSignupType.Location = new System.Drawing.Point(114, 31);
            this.cbxSignupType.Name = "cbxSignupType";
            this.cbxSignupType.Size = new System.Drawing.Size(205, 22);
            this.cbxSignupType.TabIndex = 3;
            // 
            // tbxGuestName
            // 
            this.tbxGuestName.Location = new System.Drawing.Point(114, 3);
            this.tbxGuestName.Name = "tbxGuestName";
            this.tbxGuestName.Size = new System.Drawing.Size(205, 22);
            this.tbxGuestName.TabIndex = 1;
            // 
            // lblInvitationCount
            // 
            this.lblInvitationCount.AutoSize = true;
            this.lblInvitationCount.Location = new System.Drawing.Point(3, 56);
            this.lblInvitationCount.Name = "lblInvitationCount";
            this.lblInvitationCount.Size = new System.Drawing.Size(94, 14);
            this.lblInvitationCount.TabIndex = 4;
            this.lblInvitationCount.Text = "Invitation count";
            // 
            // lblParticipantsCount
            // 
            this.lblParticipantsCount.AutoSize = true;
            this.lblParticipantsCount.Location = new System.Drawing.Point(3, 84);
            this.lblParticipantsCount.Name = "lblParticipantsCount";
            this.lblParticipantsCount.Size = new System.Drawing.Size(105, 14);
            this.lblParticipantsCount.TabIndex = 6;
            this.lblParticipantsCount.Text = "Participants count";
            // 
            // lblTourType
            // 
            this.lblTourType.AutoSize = true;
            this.lblTourType.Location = new System.Drawing.Point(3, 112);
            this.lblTourType.Name = "lblTourType";
            this.lblTourType.Size = new System.Drawing.Size(62, 14);
            this.lblTourType.TabIndex = 8;
            this.lblTourType.Text = "Tour type";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(3, 140);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(84, 14);
            this.lblPaymentType.TabIndex = 10;
            this.lblPaymentType.Text = "Payment type";
            // 
            // lblPricePerPerson
            // 
            this.lblPricePerPerson.AutoSize = true;
            this.lblPricePerPerson.Location = new System.Drawing.Point(3, 168);
            this.lblPricePerPerson.Name = "lblPricePerPerson";
            this.lblPricePerPerson.Size = new System.Drawing.Size(96, 14);
            this.lblPricePerPerson.TabIndex = 12;
            this.lblPricePerPerson.Text = "Price per person";
            // 
            // tbxInvitationCount
            // 
            this.tbxInvitationCount.Location = new System.Drawing.Point(114, 59);
            this.tbxInvitationCount.Name = "tbxInvitationCount";
            this.tbxInvitationCount.Size = new System.Drawing.Size(205, 22);
            this.tbxInvitationCount.TabIndex = 5;
            // 
            // tbxParticipantsCount
            // 
            this.tbxParticipantsCount.Location = new System.Drawing.Point(114, 87);
            this.tbxParticipantsCount.Name = "tbxParticipantsCount";
            this.tbxParticipantsCount.Size = new System.Drawing.Size(205, 22);
            this.tbxParticipantsCount.TabIndex = 7;
            // 
            // cbxTourType
            // 
            this.cbxTourType.FormattingEnabled = true;
            this.cbxTourType.Location = new System.Drawing.Point(114, 115);
            this.cbxTourType.Name = "cbxTourType";
            this.cbxTourType.Size = new System.Drawing.Size(205, 22);
            this.cbxTourType.TabIndex = 9;
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.Location = new System.Drawing.Point(114, 143);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(205, 22);
            this.cbxPaymentType.TabIndex = 11;
            // 
            // tbxPricePerPerson
            // 
            this.tbxPricePerPerson.Location = new System.Drawing.Point(114, 171);
            this.tbxPricePerPerson.Name = "tbxPricePerPerson";
            this.tbxPricePerPerson.Size = new System.Drawing.Size(205, 22);
            this.tbxPricePerPerson.TabIndex = 13;
            // 
            // tkpButtons
            // 
            this.tkpButtons.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tkpButtons, 2);
            this.tkpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tkpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tkpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tkpButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tkpButtons.Controls.Add(this.btnSave, 1, 0);
            this.tkpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tkpButtons.Location = new System.Drawing.Point(0, 197);
            this.tkpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tkpButtons.Name = "tkpButtons";
            this.tkpButtons.RowCount = 1;
            this.tkpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tkpButtons.Size = new System.Drawing.Size(325, 33);
            this.tkpButtons.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmTourDetailEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 230);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTourDetailEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmTourDetailEditor";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tkpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblSignupType;
        private System.Windows.Forms.ComboBox cbxSignupType;
        private System.Windows.Forms.TextBox tbxGuestName;
        private System.Windows.Forms.Label lblInvitationCount;
        private System.Windows.Forms.Label lblParticipantsCount;
        private System.Windows.Forms.Label lblTourType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblPricePerPerson;
        private System.Windows.Forms.TextBox tbxInvitationCount;
        private System.Windows.Forms.TextBox tbxParticipantsCount;
        private System.Windows.Forms.ComboBox cbxTourType;
        private System.Windows.Forms.ComboBox cbxPaymentType;
        private System.Windows.Forms.TextBox tbxPricePerPerson;
        private System.Windows.Forms.TableLayoutPanel tkpButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}