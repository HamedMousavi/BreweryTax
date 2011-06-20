using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;
using System;


namespace TaxDataStore
{

    public partial class FrmDailyTours : Form
    {
        protected ToursGridView fgvTours;
        protected FlatGridView fgvEmployees;
        protected FlatGridView fgvTourMembers;
        protected ContactsListView fgvMemberContacts;
        protected TourCostDetailsGridView dgvCostDetails;

        protected Entities.TourCollection tours;

        protected BindingSource bstMaster;
        protected BindingSource bstEmployees;
        protected BindingSource bstTourContacts;
        protected BindingSource bstMemberContacts;
        protected BindingSource bstTourCosts;


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

            bstTourCosts = new BindingSource();
            bstTourCosts.DataSource = bstMaster;
            bstTourCosts.DataMember = "CostDetails";

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
            this.fgvTourMembers = new FlatGridView();
            this.fgvMemberContacts = new ContactsListView();

            this.fgvTourMembers.HiddenColumnNames.Add("MemberShip");
            this.fgvTourMembers.ColumnHeadersVisible = false;
            this.fgvTourMembers.Font = Presentation.View.Theme.FormLabelFont;

            this.fgvEmployees.ColumnHeadersVisible = false;
            this.fgvEmployees.Font = Presentation.View.Theme.FormLabelFont;
            this.fgvEmployees.DefaultCellStyle.SelectionBackColor =
                this.fgvEmployees.DefaultCellStyle.BackColor;
            this.fgvEmployees.DefaultCellStyle.SelectionForeColor =
                this.fgvEmployees.DefaultCellStyle.ForeColor;

            this.dgvCostDetails = new TourCostDetailsGridView(null);
            this.dgvCostDetails.ColumnHeadersVisible = false;
            this.dgvCostDetails.DefaultCellStyle.SelectionBackColor =
                this.dgvCostDetails.DefaultCellStyle.BackColor;
            this.dgvCostDetails.DefaultCellStyle.SelectionForeColor =
                this.dgvCostDetails.DefaultCellStyle.ForeColor;
            this.dgvCostDetails.ReadOnly = true;


            this.tlpTourCosts.Controls.Add(this.dgvCostDetails, 0, 1);

            this.tlpTours.Controls.Add(this.fgvTours);
            this.tlpEmployees.Controls.Add(this.fgvEmployees, 0, 1);
            this.tlpTourMembers.Controls.Add(this.fgvTourMembers, 0, 1);
            this.tlpMemberContacts.Controls.Add(this.fgvMemberContacts, 0, 1);

            this.btnAddTour.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnDeleteTour.Image = DomainModel.Application.ResourceManager.GetImage("delete");
            this.btnEditTour.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            
            this.fgvEmployees.DataSource = this.bstEmployees;
            this.fgvTourMembers.DataSource = this.bstTourContacts;
            this.dgvCostDetails.SetDataSource(this.bstTourCosts);

            this.fgvTourMembers.SelectionChanged += new
                EventHandler(fgvTourMembers_SelectionChanged);
        }


        void fgvTourMembers_SelectionChanged(object sender, EventArgs e)
        {
            Entities.TourMember member = 
                (Entities.TourMember)this.fgvTourMembers.SelectedItem;

            if (member != null)
            {
                this.fgvMemberContacts.SetDataSource(
                    member.Contacts);
            }
            else
            {
                this.fgvMemberContacts.SetDataSource(null);
            }
        }


        private void btnEditTour_Click(object sender, EventArgs e)
        {
            Entities.Tour tour =  (Entities.Tour)this.fgvTours.SelectedItem;
            if (tour != null)
            {
                Presentation.Controllers.Tours.Edit(tour);
            }
        }


        private void btnAddTour_Click(object sender, EventArgs e)
        {
            Presentation.Controllers.Tours.AddNew(this.dtpCurrentDate.Value);
        }


        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            Entities.Tour tour = (Entities.Tour)this.fgvTours.SelectedItem;
            if (tour != null)
            {
                if (Presentation.Controllers.MessageBox.ConfirmDelete())
                {
                    DomainModel.Tours.Delete(tour);
                }
            }
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
