using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Entities.Abstract;


namespace TaxDataStore
{

    public partial class TourServiceListView : UserControl
    {

        public TourServiceListView(Entities.TourGroup group)
            : this()
        {
            this.Group = group;
        }


        public TourServiceListView()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.White;

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


            this.SuspendLayout();
            this.flpMain.SuspendLayout();

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
                    TourServiceItem client = new TourServiceItem(this.group, srv);
                    this.flpMain.Controls.Add(client);
                }
            }

            this.flpMain.ResumeLayout(true);
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
    }
}
