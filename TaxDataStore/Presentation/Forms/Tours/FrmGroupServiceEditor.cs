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


        public FrmGroupServiceEditor(Entities.Tour tour, Entities.TourGroup group, Entities.GeneralType serviceType)
        {
            this.group = group;

            CreateService(tour, group);
            this.service.Detail.ServiceType = serviceType;

            Init();
        }


        public FrmGroupServiceEditor(Entities.Tour tour, Entities.TourGroup group, Entities.TourServiceBase service)
        {
            this.editService = service;

            CreateService(tour, group);
            service.CopyTo(this.service);

            Init();
        }


        private void CreateService(Entities.Tour tour, Entities.TourGroup group)
        {
            this.service = new Entities.TourServiceBase(
                DomainModel.TourCostGroups.GetAll());

            this.service.PaymentStrategy = new 
                DomainModel.PaymentStrategies.NormalStrategy(
                    new Entities.PaymentStrategyInfo(
                        tour, 
                        group, 
                        this.service));
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
            if (this.service.Detail == null ||
                this.service.Detail.Id < 0 ||
                this.service.Detail.ServiceType == null ||
                this.service.Detail.ServiceType.Id < 0)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "stat_err_type_empty",
                        string.Empty);
                }
                catch { }
            }
            else
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
}
