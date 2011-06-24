using System;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore
{

    public partial class FrmTourPaymentEditor : BaseForm
    {

        protected TourPayment payment;
        protected TourPayment editPayment;
        protected TourPaymentCollection payments;


        public FrmTourPaymentEditor()
        {
            InitializeComponent();
            this.payment = new TourPayment();
        }


        public FrmTourPaymentEditor(TourPayment payment)
            : this()
        {
            this.editPayment = payment;
            this.editPayment.CopyTo(this.payment);

            BindControls();
 
            this.mpkPaymentAmount.Value.Currency = this.payment.Amount.Currency;
            this.mpkPaymentAmount.ValueEditor = Convert.ToString(this.payment.Amount.Value);
       }


        public FrmTourPaymentEditor(TourPaymentCollection payments)
            : this()
        {
            this.payments = payments;

            BindControls();
        }


        private void BindControls()
        {
            this.cbxPaymentTypes.DataSource = DomainModel.PaymentTypes.GetAll();
            this.cbxPaymentTypes.DisplayMember = "Name";

            this.cbxPaymentTypes.DataBindings.Add(
                new Binding(
                    "SelectedItem",
                    this.payment,
                    "Type",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    null,
                    string.Empty,
                    null));
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.payment.Amount.Value = this.mpkPaymentAmount.Value.Value;
            this.payment.Amount.Currency = this.mpkPaymentAmount.Value.Currency;

            if (this.editPayment != null)
            {
                // Update edit user and database
                this.payment.CopyTo(this.editPayment);
            }
            else
            {
                this.payments.Add(this.payment);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
