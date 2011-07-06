using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class TourGroupServices : UserControl
    {

        protected Entities.TourGroup group;

        public Entities.TourGroup Group
        {
            get { return this.group; }
            set
            {
                if (this.group != value)
                {
                    this.group = value;
                    ReAttach();
                }
            }
        }


        
        protected TourServiceListView tslServices;


        public TourGroupServices()
        {
            InitializeComponent();
            SetupControls();
            //BindControls();
        }


        public TourGroupServices(Entities.TourGroup group)
            :this()
        {
            this.Group = group;
        }


        private void SetupControls()
        {

            if (DomainModel.Application.ResourceManager != null)
            {
                this.editToolbar.Title = DomainModel.
                    Application.ResourceManager.GetText("lbl_services");
            }

            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.TourGroupItemBackColor;
                this.editToolbar.BackColor = this.BackColor;
            }


            this.tslServices = new TourServiceListView();
            this.tslServices.Dock = DockStyle.Fill;
            this.tlpMain.Controls.Add(this.tslServices, 0, 1);

        }


        private void ReAttach()
        {
            this.tslServices.DataBindings.Clear();

            if (this.group != null)
            {
                this.tslServices.DataBindings.Add(new Binding("Services", this.group, "Services"));
            }
        }
    }
}
