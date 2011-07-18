using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourGroup : TourBaseControl
    {

        protected Entities.Tour tour;
        protected Entities.TourGroup group;

        public Entities.TourGroup Group
        {
            get { return this.group; }
            set
            {
                if (this.group != value)
                {
                    this.group = value;
                    BindControls(this.group);
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
                    BindControls(this.tour);
                }
            }
        }


        protected TourGroupDetails ctrlDetail;
        protected TourGroupContacts ctrlContacts;
        protected TourGroupServices ctrlServices;
        protected TourGroupEmployees ctrlEmployees;


        public TourGroup()
        {
            InitializeComponent();

            SetupControls();
        }


        private void SetupControls()
        {
            this.ctrlDetail = new TourGroupDetails();
            this.ctrlContacts = new TourGroupContacts();
            this.ctrlServices = new TourGroupServices();
            this.ctrlEmployees = new TourGroupEmployees();

            this.ctrlDetail.Dock = DockStyle.Fill;
            this.ctrlContacts.Dock = DockStyle.Fill;
            this.ctrlServices.Dock = DockStyle.Fill;
            this.ctrlEmployees.Dock = DockStyle.Fill;

            this.tlpMain.Controls.Add(this.ctrlDetail, 0, 0);
            this.tlpMain.Controls.Add(this.ctrlContacts, 1, 0);
            this.tlpMain.Controls.Add(this.ctrlServices, 2, 0);
            this.tlpMain.Controls.Add(this.ctrlEmployees, 3, 0);

            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.TourGroupBackColor;
            }

            this.ctrlDetail.DeleteGroupClicked += 
                new EventHandler(ctrlDetail_DeleteGroupClicked);
        }


        void ctrlDetail_DeleteGroupClicked(object sender, EventArgs e)
        {
            if (DomainModel.TourGroups.Delete(this.group))
            {
                this.ctrlContacts.Cleanup();
                this.tour.Groups.Remove(this.group);
            }
        }


        private void BindControls(Entities.TourGroup group)
        {
            this.ctrlDetail.Group = group;
            this.ctrlServices.Group = group;
            this.ctrlContacts.Group = group;
            this.ctrlEmployees.Group = group;
        }


        private void BindControls(Entities.Tour tour)
        {
            //this.ctrlDetail.Tour = tour;
            this.ctrlServices.Tour = tour;
            //this.ctrlContacts.Tour = tour;
            //this.ctrlEmployees.Tour = tour;
        }

        /*
        public event EventHandler DeleteGroupClicked
        {
            add
            {
                this.ctrlDetail.DeleteGroupClicked += value;
            }

            remove
            {
                this.ctrlDetail.DeleteGroupClicked -= value;
            }
        }*/
    }
}
