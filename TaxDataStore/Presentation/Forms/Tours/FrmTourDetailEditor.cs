using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class FrmTourDetailEditor : Form
    {

        protected Entities.Tour tour;
        protected Entities.TourDetail detailToEdit;
        protected Entities.TourDetail detail;


        public FrmTourDetailEditor(Entities.Tour tour, Entities.TourDetail detail = null)
        {
            InitializeComponent();

            this.tour = tour;
            this.detail = new Entities.TourDetail();
            this.detailToEdit = detail;
            if (detailToEdit != null)
            {
                this.detailToEdit.CopyTo(this.detail);
            }

            BindControls();
        }


        private void BindControls()
        {
            this.tbxGuestName.DataBindings.Add(
                new Binding(
                    "Text",
                    this.detail,
                    "GuestName",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.tbxInvitationCount.DataBindings.Add(
                new Binding(
                    "Text",
                    this.detail,
                    "SignedupCount",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    0,
                    string.Empty,
                    null));

            this.tbxParticipantsCount.DataBindings.Add(
                new Binding(
                    "Text",
                    this.detail,
                    "ParticipantCount",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    0,
                    string.Empty,
                    null));

            this.tbxPricePerPerson.DataBindings.Add(
                new Binding(
                    "Text",
                    this.detail.PricePerPerson,
                    "Value",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    0.00M,
                    string.Empty,
                    null));
            
            this.cbxPaymentType.DataBindings.Add(
                new Binding(
                    "Text",
                    this.detail,
                    "PaymentType",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.cbxSignupType.DataBindings.Add(
                new Binding(
                    "Text",
                    this.detail,
                    "SignupType",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.cbxTourType.DataBindings.Add(
                new Binding(
                    "Text",
                    this.detail,
                    "TourType",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));
        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (this.detailToEdit == null)
            {
                this.tour.Details.Add(this.detail);
            }
            else
            {
                this.detail.CopyTo(this.detailToEdit);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
