using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmGroupServiceEditor : BaseForm
    {

        protected Entities.TourGroup group;
        protected Entities.TourServiceBase service;
        protected Entities.TourServiceBase editService;

        protected GroupServiceDetails ctrlDetails;
        protected GroupServiceBill ctrlBill;
        protected GroupServicePayment ctrlPayment;


        public FrmGroupServiceEditor(Entities.TourGroup group, Entities.GeneralType serviceType)
        {
            this.group = group;

            CreateService();
            this.service.Detail.ServiceType = serviceType;

            Init();
        }


        public FrmGroupServiceEditor(Entities.TourServiceBase service)
        {
            this.editService = service;

            CreateService();
            service.CopyTo(this.service);

            Init();
        }


        private void CreateService()
        {
            this.service = new Entities.TourServiceBase(
                DomainModel.TourCostGroups.GetAll());
            this.service.PaymentStrategy = new 
                DomainModel.PaymentStrategies.NormalStrategy();
        }


        private void Init()
        {
            InitializeComponent();

            this.ctrlDetails = new GroupServiceDetails(service);
            this.ctrlBill = new GroupServiceBill(service);
            this.ctrlPayment = new GroupServicePayment(service);

            this.tpgDetails.Controls.Add(this.ctrlDetails);
            this.tpgBill.Controls.Add(this.ctrlBill);
            this.tpgPayment.Controls.Add(this.ctrlPayment);

            this.sbbMain.SaveButtonClick += new System.EventHandler(sbbMain_SaveButtonClick);
            this.sbbMain.CancelButtonClick += new System.EventHandler(sbbMain_CancelButtonClick);
        }


        void sbbMain_CancelButtonClick(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }


        void sbbMain_SaveButtonClick(object sender, System.EventArgs e)
        {
            if (DomainModel.TourGroupServices.Save(this.group, this.service))
            {
                if (this.editService != null)
                {
                    this.service.CopyTo(this.editService);
                }
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
