using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmDailyTours : BaseForm
    {
        private FormLabel lblDate;

        private ToolbarLabel lblTours;
        private ToolbarLabel lblTourMembers;
        private ToolbarLabel lblEmployees;
        private ToolbarLabel lblMemberContacts;
        private ToolbarLabel lblTourCosts;
        private ToolbarLabel lblNotes;
        private FlatButton btnAddTour;
        private FlatButton btnEditTour;
        private FlatButton btnDeleteTour;

        private ToursListView tlvTours;

        protected Entities.TourCollection tours;

        protected BindingSource bstMaster;


        public FrmDailyTours()
        {
            InitializeComponent();

            CreateControls();

            BindControls();

            SetupControls();

            UpdateTourList();
        }


        private void BindControls()
        {
            this.tours = new Entities.TourCollection();

            bstMaster = new BindingSource();
            bstMaster.DataSource = this.tours;

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
        }


        private void CreateControls()
        {
            this.lblDate = new FormLabel(0, "lblDate", true, "date");

            this.lblTourMembers = new ToolbarLabel(1, "lblTourMembers", "lbl_tour_members");
            this.lblEmployees = new ToolbarLabel(2, "lblEmployees", "lbl_employees");
            this.lblNotes = new ToolbarLabel(3, "lblNotes", "lbl_notes");
            this.lblMemberContacts = new ToolbarLabel(4, "lblMemberContacts", "lbl_member_contacts");
            this.lblTourCosts = new ToolbarLabel(5, "lblTourCosts", "lbl_tour_costs");
            this.lblTours = new ToolbarLabel(6, "lblTours", "lbl_tours");

            this.btnAddTour = new FlatButton(7, "btnAdd", "add", "add");
            this.btnEditTour = new FlatButton(8, "btnEdit", "pencil", "edit");
            this.btnDeleteTour = new FlatButton(9, "btnDelete", "delete", "delete");

            this.btnAddTour.Click += new EventHandler(btnAddTour_Click);
            this.btnDeleteTour.Click += new EventHandler(btnDeleteTour_Click);

            this.tlpButtons.Controls.Add(this.btnAddTour, 0, 0);
            this.tlpButtons.Controls.Add(this.btnEditTour, 1, 0);
            this.tlpButtons.Controls.Add(this.btnDeleteTour, 2, 0);

            this.tlpToursToolbar.Controls.Add(this.lblTours, 0, 0);
            this.tlpDate.Controls.Add(this.lblDate, 0, 0);
        }


        private void SetupControls()
        {
            this.tlvTours = new ToursListView(this.tours);

            this.tlvTours.Dock = DockStyle.Fill;
            this.tlpTours.Controls.Add(this.tlvTours);
        }


        private void btnAddTour_Click(object sender, EventArgs e)
        {
            Presentation.Controllers.Tours.AddNew(this.dtpCurrentDate.Value);
        }


        private void btnDeleteTour_Click(object sender, EventArgs e)
        {/*
            Entities.Tour tour = (Entities.Tour)this.fgvTours.SelectedItem;
            if (tour != null)
            {
                if (Presentation.Controllers.MessageBox.ConfirmDelete())
                {
                    DomainModel.Tours.Delete(tour);
                }
            }*/
        }


        private void dtpCurrentDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTourList();
        }


        private void UpdateTourList()
        {
            this.tours.SuspendEvents();

            DomainModel.Tours.LoadByDate(this.dtpCurrentDate.Value, this.tours);

            this.tours.ResumeEvents();
        }
    }
}
