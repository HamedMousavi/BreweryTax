using System.Windows.Forms;



namespace TaxDataStore.Presentation.Controls
{
    
    public partial class GroupServiceDetails : UserControl
    {

        Entities.TourServiceBase service;
       
        private FormLabel lblServiceType;
        protected ComboBox cbxServiceTypes;

        private FormLabel lblserved;
        protected TourCostDetailsGridView dgvServedMembers;


        public GroupServiceDetails(Entities.TourServiceBase service)
        {
            InitializeComponent();

            this.service = service;

            SetupControls();
            BindControls();
        }


        private void SetupControls()
        {
            this.Dock = DockStyle.Fill;

            this.lblServiceType = new FormLabel(0, "lblServiceType", true, "lbl_tour_type");
            this.lblserved = new FormLabel(1, "lblCostMembers", true, "lbl_served");

            this.cbxServiceTypes = new ComboBox();
            this.cbxServiceTypes.Anchor = AnchorStyles.Top |
                AnchorStyles.Left | AnchorStyles.Right;
            this.cbxServiceTypes.SelectedIndexChanged += 
                new System.EventHandler(cbxServiceTypes_SelectedIndexChanged);

            this.dgvServedMembers = new 
                TourCostDetailsGridView(this.service.CostDetails);

            this.tlpMain.Controls.Add(this.lblServiceType, 0, 0);
            this.tlpMain.Controls.Add(this.cbxServiceTypes, 1, 0);
            this.tlpMain.Controls.Add(this.lblserved, 0, 1);
            this.tlpMain.Controls.Add(this.dgvServedMembers, 0, 2);

            this.tlpMain.SetColumnSpan(this.dgvServedMembers, 2);
        }


        void cbxServiceTypes_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.cbxServiceTypes.SelectedIndex >= 0)
            {
                Entities.Service service = (Entities.Service)
                    this.cbxServiceTypes.Items[this.cbxServiceTypes.SelectedIndex];

                if (this.service.Detail != service)
                {
                    this.service.Detail = service;
                }
            }
        }


        private void BindControls()
        {
            foreach(Entities.Service service in DomainModel.Services.GetAll())
            {
                if (service.ServiceType == this.service.Detail.ServiceType)
                {
                    this.cbxServiceTypes.Items.Add(service);
                    if (service.Id == this.service.Detail.Id)
                    {
                        this.cbxServiceTypes.SelectedItem =
                            service;
                    }
                }
            }

            this.cbxServiceTypes.DisplayMember = "Name";
        }
    }
}
