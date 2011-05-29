using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;
using System;


namespace TaxDataStore
{

    public partial class FrmDailyTours : Form
    {
        protected ToursGridView fgvTours;
        protected FlatGridView fgvEmployees;
        protected FlatGridView fgvTourContacts;
        protected FlatGridView fgvMemberContacts;

        protected Entities.TourCollection tours;

        protected BindingSource bstMaster;
        protected BindingSource bstEmployees;
        protected BindingSource bstTourContacts;
        protected BindingSource bstMemberContacts;


        public FrmDailyTours()
        {
            InitializeComponent();

            this.tours = new Entities.TourCollection();
            UpdateTourList();

            bstMaster = new BindingSource();
            bstMaster.DataSource = this.tours;

            bstEmployees = new BindingSource();
            bstEmployees.DataSource = bstMaster;
            bstEmployees.DataMember = "Employees";

            bstTourContacts = new BindingSource();
            bstTourContacts.DataSource = bstMaster;
            bstTourContacts.DataMember = "Members";

            bstMemberContacts = new BindingSource();
            bstMemberContacts.DataSource = bstTourContacts;
            bstMemberContacts.DataMember = "Contacts";

            this.rtbComments.DataBindings.Add(
                new Binding(
                    "Text",
                    this.bstMaster,
                    "Comments",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            SetupControls();
        }


        private void SetupControls()
        {
            this.fgvTours = new ToursGridView(this.bstMaster);
            this.fgvEmployees = new FlatGridView();
            this.fgvTourContacts = new FlatGridView();
            this.fgvMemberContacts = new FlatGridView();

            this.gpxTours.Controls.Add(this.fgvTours);
            this.gpxEmployees.Controls.Add(this.fgvEmployees);
            this.gpxTourMembers.Controls.Add(this.fgvTourContacts);
            this.gpxMemberContacts.Controls.Add(this.fgvMemberContacts);

            this.btnAddTour.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnDeleteTour.Image = DomainModel.Application.ResourceManager.GetImage("delete");
            this.btnEditTour.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            
            this.fgvEmployees.DataSource = this.bstEmployees;
            this.fgvTourContacts.DataSource = this.bstTourContacts;
            this.fgvMemberContacts.DataSource = this.bstMemberContacts;
        }


        private void btnEditTour_Click(object sender, EventArgs e)
        {
            Entities.Tour tour =  (Entities.Tour)this.fgvTours.SelectedItem;
            if (tour != null)
            {
                Presentation.Controllers.Tours.Edit(tour);
            }
            UpdateTourList();
        }


        private void btnAddTour_Click(object sender, EventArgs e)
        {
            Presentation.Controllers.Tours.AddNew(this.dtpCurrentDate.Value);
            UpdateTourList();
        }


        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            Entities.Tour tour = (Entities.Tour)this.fgvTours.SelectedItem;
            if (tour != null)
            {
                Presentation.Controllers.Tours.Delete(tour);
            }
            UpdateTourList();
        }


        private void dtpCurrentDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTourList();
        }


        private void UpdateTourList()
        {
            DomainModel.Tours.LoadByDate(this.dtpCurrentDate.Value, this.tours);
            //if (this.bstMaster != null) this.bstMaster.ResetBindings(true);
        }
    }
}
