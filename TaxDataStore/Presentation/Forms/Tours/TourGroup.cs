using System.Windows.Forms;
using System.Drawing;
using System;


namespace TaxDataStore
{

    public partial class TourGroup : UserControl
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
                    BindControls();
                }
            }
        }


        TourGroupDetails ctrlDetail;
        TourGroupContacts ctrlContacts;
        TourGroupServices ctrlServices;
        TourGroupEmployees ctrlEmployees;


        public TourGroup()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.DimGray;

            SetupControls();
        }


        public TourGroup(Entities.TourGroup group)
            : this()
        {
            this.Group = group;
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
        }


        private void BindControls()
        {
            this.ctrlDetail.DataBindings.Clear();
            this.ctrlServices.DataBindings.Clear();
            this.ctrlContacts.DataBindings.Clear();

            this.ctrlDetail.DataBindings.Add(new Binding("Group", this, "Group"));
            this.ctrlServices.DataBindings.Add(new Binding("Group", this, "Group"));
            this.ctrlContacts.DataBindings.Add(new Binding("Group", this, "Group"));
        }
    }
}
