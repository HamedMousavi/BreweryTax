using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TaxDataStore.Presentation;


namespace TaxDataStore
{

    public partial class ToursListView : UserControl
    {

        protected FormControlManager ctrlManager;
        protected Entities.TourCollection Tours { get; set; }


        public ToursListView(Entities.TourCollection tours)
        {
            InitializeComponent();

            SetupControls();
            BindControls(tours);
        }


        private void SetupControls()
        {
            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.TourListBackColor;
            }
            this.Disposed += new System.EventHandler(ToursListView_Disposed);
        }


        private void BindControls(Entities.TourCollection tours)
        {
            this.Tours = tours;
            this.Tours.ListChanged += new ListChangedEventHandler(Tours_ListChanged);

            this.ctrlManager = new FormControlManager(this.flpTours, tours);
            this.ctrlManager.CreateControl = CreateTour;
            this.ctrlManager.ControlsContainItem = TourContainItem;
            this.ctrlManager.ListContainsControl = ListContainsTour;
        }


        public Control CreateTour(object item)
        {
            TourControl client = new TourControl((Entities.Tour)item);
            client.Dock = DockStyle.Top;

            return client;
        }


        public bool TourContainItem(object item)
        {
            Entities.Tour tour =
                (Entities.Tour)item;

            return FindInClients(tour) != null;
        }


        public bool ListContainsTour(UserControl ctrl)
        {
            TourControl tourCtrl = (TourControl)ctrl;
            return this.Tours.Contains(tourCtrl.Tour);
        }


        void Tours_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsDisposed) return;

            if (e.ListChangedType == ListChangedType.Reset)
            {
                this.ctrlManager.Reset();
            }
            else
            {
                UpdateData();
            }
        }


        public void UpdateData()
        {
            if (IsDisposed || Disposing) return;

            this.SuspendLayout();
            this.ctrlManager.Sync();
            this.ResumeLayout(true);
        }


        private TourControl FindInClients(Entities.Tour tour)
        {
            foreach (UserControl ctrl in this.flpTours.Controls)
            {
                TourControl grpCtrl = ctrl as TourControl;
                if (grpCtrl != null)
                {
                    if (grpCtrl.Tour == tour)
                    {
                        return grpCtrl;
                    }
                }
            }

            return null;
        }


        void ToursListView_Disposed(object sender, System.EventArgs e)
        {
            if (this.Tours != null)
            {
                this.Tours.ListChanged -= 
                    new ListChangedEventHandler(Tours_ListChanged);
            }
        }
    }
}
