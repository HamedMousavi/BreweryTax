using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;
using System;


namespace TaxDataStore
{

    public partial class FrmDailyTours : Form
    {
        protected FlatGridView fgvTimeList;
        protected FlatGridView fgvEmployees;
        protected FlatGridView fgvDetails;


        protected Entities.TourCollection tours;

        protected BindingSource bstMaster;
        protected BindingSource bstTimes;
        protected BindingSource bstEmployees;
        protected BindingSource bstDetails;


        public FrmDailyTours()
        {
            InitializeComponent();

            SetupControls();

            this.tours = new Entities.TourCollection();
            UpdateTourList();

            bstMaster = new BindingSource();
            bstMaster.DataSource = this.tours;

            bstTimes = new BindingSource();
            bstTimes.DataSource = bstMaster;
            bstTimes.DataMember = "Time";

            bstEmployees = new BindingSource();
            bstEmployees.DataSource = bstMaster;
            bstEmployees.DataMember = "Employees";

            bstDetails = new BindingSource();
            bstDetails.DataSource = bstMaster;
            bstDetails.DataMember = "Details";

            this.fgvTimeList.DataSource = this.bstMaster;
            this.fgvEmployees.DataSource = this.bstEmployees;
            this.fgvDetails.DataSource = this.bstDetails;
        }



        private void SetupControls()
        {
            this.fgvTimeList = new FlatGridView();
            this.fgvTimeList.ColumnHeadersVisible = false;

            this.fgvEmployees = new FlatGridView();
            this.fgvDetails = new FlatGridView();

            this.gpxEmployees.Controls.Add(this.fgvEmployees);
            this.gpxTimeList.Controls.Add(this.fgvTimeList);
            this.gpxTourDetails.Controls.Add(this.fgvDetails);

            this.btnAddTour.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnDeleteTour.Image = DomainModel.Application.ResourceManager.GetImage("delete");
            this.btnEditTour.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
        }


        private void btnEditTour_Click(object sender, EventArgs e)
        {
            Entities.Tour tour =  (Entities.Tour)this.fgvTimeList.SelectedItem;
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
            Entities.Tour tour = (Entities.Tour)this.fgvTimeList.SelectedItem;
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
