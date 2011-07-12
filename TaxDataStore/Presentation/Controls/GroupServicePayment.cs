using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class GroupServicePayment : UserControl
    {

        private Entities.TourServiceBase service;
        private TourPaymentsGridView dgvPayments;
        private EditToolbar etbPayments;


        public GroupServicePayment(Entities.TourServiceBase service)
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;

            this.service = service;
            this.dgvPayments = new 
                TourPaymentsGridView(this.service.Payments);

            this.etbPayments = new EditToolbar(
                DomainModel.Application.ResourceManager.GetText("tab_title_Payments"));
            this.etbPayments.ButtonAutohide = false;

            this.tlpMain.Controls.Add(this.etbPayments, 0, 0);
            this.tlpMain.Controls.Add(this.dgvPayments, 0, 1);

            this.etbPayments.AddButtonClick += new System.EventHandler(etbPayments_AddButtonClick);
            this.etbPayments.EditButtonClick += new System.EventHandler(etbPayments_EditButtonClick);
            this.etbPayments.DeleteButtonClick += new System.EventHandler(etbPayments_DeleteButtonClick);

            this.tlpMain.BackColor = Presentation.View.Theme.GroupPanelBackColor;
        }


        void etbPayments_DeleteButtonClick(object sender, System.EventArgs e)
        {
            Entities.TourPayment payment =
                (Entities.TourPayment)this.dgvPayments.SelectedItem;
            if (payment != null)
            {
                if (payment.Id >= 0)
                {
                    this.service.DeletedPayments.Add(payment);
                }

                this.service.Payments.Remove(payment);
            }
        }


        void etbPayments_EditButtonClick(object sender, System.EventArgs e)
        {
            Entities.TourPayment payment =
                (Entities.TourPayment)this.dgvPayments.SelectedItem;
            if (payment != null)
            {
                Presentation.Controllers.Tours.EditPayment(payment);
            }
        }


        void etbPayments_AddButtonClick(object sender, System.EventArgs e)
        {
            Presentation.Controllers.Tours.AddPayment(this.service.Payments);
        }
    }
}
