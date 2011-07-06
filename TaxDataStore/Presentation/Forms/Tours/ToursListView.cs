using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class ToursListView : UserControl
    {

        public ToursListView(Entities.TourCollection tours)
        {
            InitializeComponent();

            SetupControls();
            BindControls(tours);
        }


        private void SetupControls()
        {
            this.BackColor = System.Drawing.Color.White;
        }


        private void BindControls(Entities.TourCollection tours)
        {
            tours.ListChanged += new ListChangedEventHandler(Tours_ListChanged);
        }


        void Tours_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsDisposed) return;

            UpdateData((Entities.TourCollection)sender);
        }


        private void UpdateData(Entities.TourCollection tours)
        {
            if (IsDisposed) return;

            List<TourControl> removable = new List<TourControl>();

            foreach (UserControl ctrl in this.flpTours.Controls)
            {
                TourControl tourCtrl = ctrl as TourControl;
                if (tourCtrl != null)
                {
                    Entities.Tour tr = tourCtrl.Tour;

                    if (tours.Contains(tr))
                    {
                        tourCtrl.UpdateData();
                    }
                    else
                    {
                        removable.Add(tourCtrl);
                    }
                }
            }

            lock (this)
            {
                this.flpTours.SuspendLayout();

                foreach (TourControl tourCtrl in removable)
                {
                    this.flpTours.Controls.Remove(tourCtrl);
                    tourCtrl.Dispose();
                }
                removable.Clear();

                foreach (Entities.Tour tour in tours)
                {
                    TourControl ctrl = FindInClients(tour);
                    if (ctrl == null)
                    {
                        TourControl client = new TourControl(tour);
                        client.Dock = DockStyle.Top;
                        this.flpTours.Controls.Add(client);
                    }
                }

                this.flpTours.ResumeLayout(true);
            }
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
    }
}
