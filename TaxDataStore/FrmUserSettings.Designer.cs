namespace TaxDataStore
{
    partial class FrmUserSettings
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
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.mpkPricePerPerson = new TaxDataStore.Presentation.Controls.MoneyPicker();
            this.lblPricePerPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(14, 61);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(72, 13);
            this.lblPaymentType.TabIndex = 26;
            this.lblPaymentType.Text = "PaymentType";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(92, 58);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(180, 21);
            this.comboBox3.TabIndex = 27;
            // 
            // mpkPricePerPerson
            // 
            this.mpkPricePerPerson.BackColor = System.Drawing.SystemColors.Control;
            this.mpkPricePerPerson.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mpkPricePerPerson.Location = new System.Drawing.Point(92, 12);
            this.mpkPricePerPerson.Name = "mpkPricePerPerson";
            this.mpkPricePerPerson.Size = new System.Drawing.Size(180, 24);
            this.mpkPricePerPerson.TabIndex = 25;
            this.mpkPricePerPerson.ValueEditor = null;
            // 
            // lblPricePerPerson
            // 
            this.lblPricePerPerson.AutoSize = true;
            this.lblPricePerPerson.Location = new System.Drawing.Point(6, 12);
            this.lblPricePerPerson.Name = "lblPricePerPerson";
            this.lblPricePerPerson.Size = new System.Drawing.Size(80, 13);
            this.lblPricePerPerson.TabIndex = 24;
            this.lblPricePerPerson.Text = "PricePerPerson";
            // 
            // FrmUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.mpkPricePerPerson);
            this.Controls.Add(this.lblPricePerPerson);
            this.Name = "FrmUserSettings";
            this.Text = "FrmUserSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox comboBox3;
        private Presentation.Controls.MoneyPicker mpkPricePerPerson;
        private System.Windows.Forms.Label lblPricePerPerson;

    }
}