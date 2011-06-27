﻿using System;
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

            CreateControls();

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


        private void CreateControls()
        {
            this.lblDate = new FormLabel(0, "lblDate", true, "date");

            this.lblTourMembers = new ToolbarLabel(1, "lblTourMembers", "lbl_tour_members");
            this.lblEmployees = new ToolbarLabel(2, "lblEmployees", "lbl_employees");
            this.lblNotes = new ToolbarLabel(3, "lblNotes", "lbl_notes");
            this.lblMemberContacts = new ToolbarLabel(4, "lblMemberContacts", "lbl_member_contacts");
            this.lblTourCosts = new ToolbarLabel(5, "lblTourCosts", "lbl_tour_costs");
            this.lblTours = new ToolbarLabel(6, "lblTours", "lbl_tours");

            this.tlpEmployees.Controls.Add(this.lblEmployees, 0, 0);
            this.tlpTourMembers.Controls.Add(this.lblTourMembers, 0, 0);
            this.tlpMemberContacts.Controls.Add(this.lblMemberContacts, 0, 0);
            this.tlpTourCosts.Controls.Add(this.lblTourCosts, 0, 0);
            this.tlpToursToolbar.Controls.Add(this.lblTours, 0, 0);
            this.tlpNotes.Controls.Add(this.lblNotes, 0, 0);
            this.tlpDate.Controls.Add(this.lblDate, 0, 0);
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
