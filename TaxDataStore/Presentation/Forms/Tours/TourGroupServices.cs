using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourGroupServices : TourBaseControl
    {

        protected GeneralTypeMenu mnuServiceTypes;
        protected TourServiceListView tslServices;
        protected Entities.TourGroup group;
        protected Entities.Tour tour;


        public Entities.TourGroup Group
        {
            get { return this.group; }
            set
            {
                if (this.group != value)
                {
                    this.group = value;
                    this.tslServices.Group = this.group;
                }
            }
        }

        public Entities.Tour Tour
        {
            get { return this.tour; }
            set
            {
                if (this.tour != value)
                {
                    this.tour = value;
                    this.tslServices.Tour = this.tour;
                }
            }
        }
        

        public TourGroupServices()
        {
            InitializeComponent();

            SetupControls();
        }


        private void SetupControls()
        {
            this.mnuServiceTypes = new GeneralTypeMenu(
                DomainModel.ServiceTypes.GetAll());
            this.mnuServiceTypes.ClickAction = OnNewServiceTypeClicked;

            this.editToolbar.ShowDelete = false;
            this.editToolbar.ShowEdit = false;
            this.editToolbar.AddContextMenu = this.mnuServiceTypes;

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
            this.tlpMain.Controls.Add(this.tslServices, 0, 1);

            this.Dock = DockStyle.Fill;
            this.tlpMain.Dock = DockStyle.Fill;
            this.tslServices.Dock = DockStyle.Fill;
        }


        public void OnNewServiceTypeClicked(Entities.GeneralType item)
        {
            Presentation.Controllers.GroupServices.AddNew(this.tour, this.group, item);
        }
    }
}
