using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Entities;
using Entities.Abstract;


namespace TaxDataStore
{

    public partial class TourServiceListView : UserControl
    {

        public TourServiceListView(TourServiceCollection services)
            : this()
        {
            this.Services = services;
        }


        public TourServiceListView()
        {
            InitializeComponent();

            BindControls();
        }


        private void BindControls()
        {
        }


        void services_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsDisposed) return;

            UpdateData();
        }


        private void UpdateData()
        {
            if (IsDisposed) return;

            List<TourServiceItem> removable = new List<TourServiceItem>();

            foreach (UserControl ctrl in this.flpMain.Controls)
            {
                TourServiceItem srvCtrl = ctrl as TourServiceItem;
                if (srvCtrl != null)
                {
                    ITourService srv = srvCtrl.Service;

                    if (services.Contains(srv))
                    {
                        srvCtrl.UpdateData();
                    }
                    else
                    {
                        removable.Add(srvCtrl);
                    }
                }
            }

            foreach (TourServiceItem srvCtrl in removable)
            {
                this.flpMain.Controls.Remove(srvCtrl);
                srvCtrl.Dispose();
            }
            removable.Clear();

            foreach(ITourService srv in services)
            {
                TourServiceItem ctrl = FindInClients(srv);
                if (ctrl == null)
                {
                    TourServiceItem client = new TourServiceItem(srv);
                    this.flpMain.Controls.Add(client);
                }
            }

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


        protected TourServiceCollection services;


        public TourServiceCollection Services
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


        private void AttachServices()
        {
            this.services.ListChanged += new
                ListChangedEventHandler(services_ListChanged);

            UpdateData();
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
