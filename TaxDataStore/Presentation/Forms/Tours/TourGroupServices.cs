using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourGroupServices : UserControl
    {

        protected GeneralTypeMenu mnuServiceTypes;
        protected TourServiceListView tslServices;
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


        public void OnNewServiceTypeClicked(Entities.GeneralType item)
        {
            Presentation.Controllers.GroupServices.AddNew(this.group, item);
        }
    }
}
