using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmTourEditor : Form
    {

        protected EmployeesGridView dgvEmployees;
        protected PaymentsGridView dgvPayments;
        protected MembersGridView dgvMembers;
        protected ContactsGridView dgvContacts;
        protected TourPaymentDetailsGridView dgvPaymentDetails;

        protected EmployeesSplitButton spbEmployees;

        protected TypeComboBox cbxTourTypes;
        protected TypeComboBox cbxSignUpTypes;

        protected Entities.Tour tour;
        protected Entities.Tour editTour;
        

        public FrmTourEditor()
        {
            InitializeComponent();

            this.tour = new Entities.Tour(DomainModel.TourPaymentGroups.GetAll());

            SetupControls();
            BindControls();
        }


        public FrmTourEditor(Entities.Tour editTour)
            : this()
        {
            this.editTour = editTour;
            if (editTour != null)
            {
                this.editTour.CopyTo(this.tour);
            }
        }


        public FrmTourEditor(DateTime? date)
            : this()
        {
            if (date != null && date.HasValue)
            {
                this.tour.Time.Date = date.Value.Date;
            }
        }


        private void SetupControls()
        {
            this.spbEmployees = new EmployeesSplitButton(OnMenuItemClicked);
            this.tlpEmployeeToolbar.Controls.Add(this.spbEmployees, 1, 0);

            this.dgvEmployees = new EmployeesGridView(this.tour.Employees);
            this.tlpStaff.Controls.Add(this.dgvEmployees, 0, 1);

            this.dgvPayments = new PaymentsGridView(this.tour.PaymentDetails);
            this.tlpPayments.Controls.Add(this.dgvPayments, 0, 1);
            this.tlpPayments.SetColumnSpan(this.dgvPayments, 3);
            this.tlpPayments.SetRowSpan(this.dgvPayments, 2);

            this.dgvMembers = new MembersGridView(this.tour.Members);
            this.tlpTourMembers.Controls.Add(this.dgvMembers, 0, 1);

            this.dgvContacts = new ContactsGridView(this.dgvMembers.BindingSource, "Contacts");
            this.tlpTourMembers.Controls.Add(this.dgvContacts, 3, 1);

            this.dgvPaymentDetails = new TourPaymentDetailsGridView(this.tour.PaymentDetails);
            this.gpxPaymentGroups.Controls.Add(this.dgvPaymentDetails);

            SetupControlImages();
            SetupControlTexts();

            this.cbxTourTypes = new TypeComboBox("TourType");
            this.cbxSignUpTypes = new TypeComboBox("SignupType");
            this.tlpTour.Controls.Add(this.cbxTourTypes, 1, 2);
            this.tlpTour.Controls.Add(this.cbxSignUpTypes, 1, 3);

            this.cbxTourTypes.Anchor = (AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right;
            this.cbxSignUpTypes.Anchor = (AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right;

            this.Load += new EventHandler(FrmTourEditor_Load);

        }


        private void SetupControlImages()
        {
            this.btnAddTourMember.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnEditTourMember.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            this.btnRemoveTourMember.Image = DomainModel.Application.ResourceManager.GetImage("delete");
            
            this.btnRemoveEmployee.Image = DomainModel.Application.ResourceManager.GetImage("delete");

            this.btnEditPayment.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            this.btnAddPayment.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnRemovePayment.Image = DomainModel.Application.ResourceManager.GetImage("delete");
            
            this.tabMain.ImageList = new ImageList();
            this.tabMain.ImageList.Images.Add(DomainModel.Application.ResourceManager.GetImage("calendar_day"));
            this.tabMain.ImageList.Images.Add(DomainModel.Application.ResourceManager.GetImage("money_coin"));
            this.tabMain.ImageList.Images.Add(DomainModel.Application.ResourceManager.GetImage("address_book"));
            this.tabMain.ImageList.Images.Add(DomainModel.Application.ResourceManager.GetImage("users"));

            this.tbpTour.ImageIndex = 0;
            this.tbpPayments.ImageIndex = 1;
            this.tbpMembers.ImageIndex = 2;
            this.tbpStaff.ImageIndex = 3;
        }


        private void SetupControlTexts()
        {
            this.Text = Resources.Texts.frm_title_tour_editor;
            this.tbpMembers.Text = Resources.Texts.tab_title_members;
            this.tbpPayments.Text = Resources.Texts.tab_title_payments;
            this.tbpStaff.Text = Resources.Texts.tab_title_staff;
            this.tbpTour.Text = Resources.Texts.tab_title_tour;

            this.lblComments.Text = Resources.Texts.lbl_comments;
            this.lblDate.Text = Resources.Texts.lbl_date;
            this.lblEmployees.Text = Resources.Texts.lbl_employees;
            this.lblSignupType.Text = Resources.Texts.lbl_signup_type;
            this.lblTime.Text = Resources.Texts.lbl_time;
            this.lblTourStatusLabel.Text = Resources.Texts.lbl_tour_status;
            this.lblTourType.Text = Resources.Texts.lbl_tour_type;
            this.lblGuest.Text = Resources.Texts.lbl_guests;
            this.lblGuestContacts.Text = Resources.Texts.lbl_guest_contacts;

            this.btnSave.Text = Resources.Texts.save;
            this.btnCancel.Text = Resources.Texts.cancel;
        }


        void FrmTourEditor_Load(object sender, EventArgs e)
        {
            this.tour.SignUpType = (Entities.GeneralType)this.cbxSignUpTypes.SelectedItem;
            this.tour.TourType = (Entities.GeneralType)this.cbxTourTypes.SelectedItem;
        }


        private void BindControls()
        {
            this.dtpTime.DataBindings.Add(
                new Binding(
                    "Value",
                    this.tour.Time,
                    "Time",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.dtpDate.DataBindings.Add(
                new Binding(
                    "Value",
                    this.tour.Time,
                    "Date",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));


            this.rtbComments.DataBindings.Add(
                new Binding(
                    "Text",
                    this.tour,
                    "Comments",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    0.00M,
                    string.Empty,
                    null));

            this.cbxSignUpTypes.DataBindings.Add(
                new Binding(
                    "SelectedItem",
                    this.tour,
                    "SignUpType",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    null,
                    string.Empty,
                    null));

            this.cbxTourTypes.DataBindings.Add(
                new Binding(
                    "SelectedItem",
                    this.tour,
                    "TourType",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    null,
                    string.Empty,
                    null));
            /*
            this.lblTourStatus.DataBindings.Add(
                new Binding(
                    "Text",
                    this.tour.Status,
                    "Name",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    null,
                    string.Empty,
                    null));*/
        }


        public void OnMenuItemClicked(string itemName)
        {
            Entities.Employee emp = DomainModel.Employees.GetByName(itemName);
            if (emp != null)
            {
                if (!this.tour.Employees.Contains(emp))
                {
                    this.tour.Employees.Add(emp);
                }
            }
        }


        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            Entities.Employee selected = (Entities.Employee)this.dgvEmployees.SelectedItem;
            if (selected != null)
            {
                this.tour.Employees.Remove(selected);
            }
            // UNDONE: Highlight next item
            // UNDONE: Turn buttons on/off based on data source
        }


        private void btnAddTourMember_Click(object sender, EventArgs e)
        {
            Presentation.Controllers.Tours.AddMember(this.tour);
        }


        private void btnEditTourMember_Click(object sender, EventArgs e)
        {
            Entities.TourMember member = (Entities.TourMember) this.dgvMembers.SelectedItem;
            if (member != null)
            {
                Presentation.Controllers.Tours.EditMember(member);
            }
        }


        private void btnRemoveTourMember_Click(object sender, EventArgs e)
        {
            Entities.TourMember member = (Entities.TourMember) this.dgvMembers.SelectedItem;
            if (member != null)
            {
                if (member.Id >= 0)
                {
                    if (Presentation.Controllers.Tours.DeleteMember(member))
                    {
                        this.tour.Members.Remove(member);
                    }
                }
                else
                {
                    this.tour.Members.Remove(member);
                }
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


        private void btnAddPayment_Click(object sender, EventArgs e)
        {

        }


        private void btnRemovePayment_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }


        private void btnEditPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
