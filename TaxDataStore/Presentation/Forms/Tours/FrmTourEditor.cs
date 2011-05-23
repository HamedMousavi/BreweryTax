using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmTourEditor : Form
    {

        protected Entities.Tour tour;
        protected Entities.Tour editTour;
        protected FlatGridView fgvEmployees;
        protected FlatGridView fgvDetails;
        protected EmployeesSplitButton spbEmployees;


        public FrmTourEditor(Entities.Tour editTour = null)
        {
            InitializeComponent();

            this.tour = new Entities.Tour();
            this.editTour = editTour;
            if (editTour != null)
            {
                this.editTour.CopyTo(this.tour);
            }
            
            this.fgvEmployees = new FlatGridView();
            this.fgvEmployees.GridColor = this.BackColor;
            this.fgvEmployees.BackgroundColor = this.BackColor;
            this.fgvEmployees.DefaultCellStyle.BackColor = this.BackColor;
            this.fgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = this.BackColor;


            this.fgvDetails = new FlatGridView();
            this.fgvDetails.GridColor = this.BackColor;
            this.fgvDetails.BackgroundColor = this.BackColor;
            this.fgvDetails.DefaultCellStyle.BackColor = this.BackColor;
            this.fgvDetails.ColumnHeadersDefaultCellStyle.BackColor = this.BackColor;

            this.tlpEmployees.Controls.Add(this.fgvEmployees);
            this.tlpDetails.Controls.Add(this.fgvDetails);

            this.tlpEmployees.SetColumnSpan(this.fgvEmployees, 2);

            this.spbEmployees = new EmployeesSplitButton(OnMenuItemClicked);
            this.tlpEmployees.Controls.Add(this.spbEmployees, 0, 0);

            this.btnAddDetail.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnEditDetail.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            this.btnRemoveEmployee.Image = DomainModel.Application.ResourceManager.GetImage("delete");
            this.btnRemoveDetail.Image = DomainModel.Application.ResourceManager.GetImage("delete");

            BindData();
        }


        public FrmTourEditor(DateTime? date)
            : this()
        {
            if (date != null && date.HasValue)
            {
                this.tour.Time.Date = date.Value.Date;
            }
        }


        private void BindData()
        {
            this.dtpTourTime.DataBindings.Add(
                new Binding(
                    "Value",
                    this.tour.Time,
                    "Time",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.dtpTourDate.DataBindings.Add(
                new Binding(
                    "Value",
                    this.tour.Time,
                    "Date",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.fgvEmployees.DataSource = this.tour.Employees;
            this.fgvDetails.DataSource = this.tour.Details;
        }


        public void OnMenuItemClicked(string itemName)
        {
            Entities.Employee emp = DomainModel.Employees.GetByName(itemName);
            if (emp != null)
            {
                this.tour.Employees.Add(emp);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool res = false;


            if (this.editTour != null)
            {
                // Update edit user and database
                this.tour.CopyTo(this.editTour);
                res = DomainModel.Tours.Save(this.editTour);
            }
            else
            {
                res = DomainModel.Tours.Save(this.tour);
            }

            if (res)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }


        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            Presentation.Controllers.Tours.AddDetail(this.tour);
        }


        private void btnRemoveDetail_Click(object sender, EventArgs e)
        {
            Entities.TourDetail selected = (Entities.TourDetail)this.fgvDetails.SelectedItem;
            if (selected != null)
            {
                this.tour.Details.Remove(selected);
            }
            // UNDONE: Highlight next item
            // UNDONE: Turn buttons on/off based on data source
        }


        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            Entities.Employee selected = (Entities.Employee)this.fgvEmployees.SelectedItem;
            if (selected != null)
            {
                this.tour.Employees.Remove(selected);
            }
            // UNDONE: Highlight next item
            // UNDONE: Turn buttons on/off based on data source
        }


        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            Entities.TourDetail selected = (Entities.TourDetail)this.fgvDetails.SelectedItem;
            if (selected != null)
            {
                Presentation.Controllers.Tours.EditDetail(selected);
                this.fgvDetails.UpdateBinding();
                this.fgvDetails.Update();
                this.fgvDetails.Refresh();
            }
        }
    }
}
