using System.ComponentModel;
using System.Windows.Forms;
using Entities.Abstract;
using TaxDataStore.Presentation;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourServiceListView : TourBaseControl
    {

        protected FormControlManager ctrlManager;


        private Entities.Tour tour;
        public Entities.Tour Tour
        {
            get { return this.tour; }
            set
            {
                if (this.tour != value)
                {
                    this.tour = value;
                    BindControls();
                }
            }
        }

        private Entities.TourGroup group;
        public Entities.TourGroup Group
        {
            get { return this.group; }
            set
            {
                if (this.group != value)
                {
                    this.group = value;
                    this.Services = this.group.Services;
                }
            }
        }


        protected Entities.TourServiceCollection services;
        public Entities.TourServiceCollection Services
        {
            get { return this.services; }
            set
            {
                if (this.services != value)
                {
                    DetachServices();
                    this.services = value;
                    AttachServices();
                }
            }
        }


        public TourServiceListView()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.White;
            this.Dock = DockStyle.Fill;
        }


        private void BindControls()
        {
            if (this.group == null ||
                this.tour == null) return;

            this.ctrlManager = new FormControlManager(this.flpMain, this.Group.Services);
            this.ctrlManager.CreateControl = CreateService;
            this.ctrlManager.ControlsContainItem = ServiceContainItem;
            this.ctrlManager.ListContainsControl = ListContainsService;

            UpdateData();
        }


        public Control CreateService(object item)
        {
            TourServiceItem client = new 
                TourServiceItem();

            client.Tour = this.tour;
            client.Group = this.group;
            client.Service = (ITourService)item;

            return client;
        }


        public bool ServiceContainItem(object item)
        {
            ITourService service =
                (ITourService)item;

            return FindInClients(service) != null;
        }


        public bool ListContainsService(UserControl ctrl)
        {
            TourServiceItem srvCtrl = (TourServiceItem)ctrl;
            return this.Services.Contains(srvCtrl.Service);
        }


        void services_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsDisposed) return;

            UpdateData();
        }


        private void UpdateData()
        {
            if (IsDisposed) return;

            this.SuspendLayout();
            this.ctrlManager.Sync();
            this.ResumeLayout(true);

        }


        private TourServiceItem FindInClients(ITourService service)
        {
            foreach (UserControl ctrl in this.flpMain.Controls)
            {
                TourServiceItem srvCtrl = ctrl as TourServiceItem;
                if (srvCtrl != null)
                {
                    if (srvCtrl.Service == service)
                    {
                        return srvCtrl;
                    }
                }
            }

            return null;
        }


        private void AttachServices()
        {
            BindControls();

            this.services.ListChanged += new
                ListChangedEventHandler(services_ListChanged);
        }


        private void DetachServices()
        {
            if (this.services != null)
            {
                this.services.ListChanged -= new
                    ListChangedEventHandler(services_ListChanged);
            }
        }
    }
}
