using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmDailyTours : BaseForm
    {
        private FormLabel lblDate;
        private ToolbarLabel lblTours;
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
            this.lblDate = new FormLabel(0, "lblDate", false, "date");

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
