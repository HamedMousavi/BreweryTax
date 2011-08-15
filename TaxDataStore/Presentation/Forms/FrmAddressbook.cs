using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;



namespace TaxDataStore
{

    public partial class FrmAddressbook : Form
    {

        protected FlatGridView fgvMembers;
        protected ContactsListView lsvMemberContacts;
        private EditToolbar editToolbar;


        public FrmAddressbook()
        {
            InitializeComponent();

            SetupControls();
        }


        private void SetupControls()
        {
            this.fgvMembers = new FlatGridView();
            this.lsvMemberContacts = new ContactsListView();
            //this.Dock = DockStyle.Fill;
            this.tlpMain.Dock = DockStyle.Fill;
            this.fgvMembers.Dock = DockStyle.Fill;
            this.lsvMemberContacts.Dock = DockStyle.Fill;

            this.editToolbar = new EditToolbar();
            this.editToolbar.ButtonAutohide = false;
            this.editToolbar.Anchor = AnchorStyles.Top | 
                AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.editToolbar.Title = "";
            /*
            if (DomainModel.Application.ResourceManager != null)
            {
                this.editToolbar.Title = DomainModel.
                    Application.ResourceManager.GetText("lbl_contacts");
            }*/

            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.TourGroupItemBackColor;
                this.editToolbar.BackColor = this.BackColor;

                this.fgvMembers.Font = Presentation.View.Theme.FormLabelFont;
            }

            this.fgvMembers.HiddenColumnNames.Add("MemberShip");
            this.fgvMembers.HiddenColumnNames.Add("Title");
            this.fgvMembers.HiddenColumnNames.Add("FirstName");
            this.fgvMembers.HiddenColumnNames.Add("LastName");
            this.fgvMembers.HiddenColumnNames.Add("Contacts");
            this.fgvMembers.HiddenColumnNames.Add("IsInPhonebook");
            this.fgvMembers.HiddenColumnNames.Add("IsEmployee");
            this.fgvMembers.ColumnHeadersVisible = false;
            this.fgvMembers.Margin = new Padding(2, 2, 1, 2);

            this.lsvMemberContacts.Margin = new Padding(0, 2, 2, 2);

            this.tlpMain.Controls.Add(this.editToolbar, 0, 0);
            this.tlpMain.Controls.Add(this.fgvMembers, 0, 1);
            this.tlpMain.Controls.Add(this.lsvMemberContacts, 1, 1);

            this.tlpMain.SetColumnSpan(this.editToolbar, 2);

            this.fgvMembers.SelectionChanged += new
                EventHandler(fgvMembers_SelectionChanged);

            this.editToolbar.AddButtonClick += new 
                EventHandler(editToolbar_AddButtonClick);

            this.editToolbar.EditButtonClick += new 
                EventHandler(editToolbar_EditButtonClick);

            this.editToolbar.DeleteButtonClick += new 
                EventHandler(editToolbar_DeleteButtonClick);

            this.fgvMembers.SetDataSource(DomainModel.Phonebook.GetAll());
        }


        void editToolbar_AddButtonClick(object sender, EventArgs e)
        {
            Presentation.Controllers.Phonebook.Add();
        }


        void editToolbar_DeleteButtonClick(object sender, EventArgs e)
        {
            Entities.TourMember member =
                (Entities.TourMember)this.fgvMembers.SelectedItem;

            if (Presentation.Controllers.Phonebook.Delete(member))
            {
                this.fgvMembers.SelectLastItem();
            }
        }


        void editToolbar_EditButtonClick(object sender, EventArgs e)
        {
            Entities.TourMember member =
                (Entities.TourMember)this.fgvMembers.SelectedItem;

            if (member != null)
            {
                Presentation.Controllers.Phonebook.Edit(member);
            }
        }


        void fgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedMemberContacts();
        }


        private void UpdateSelectedMemberContacts()
        {
            Entities.TourMember member =
                (Entities.TourMember)this.fgvMembers.SelectedItem;

            if (member != null)
            {
                this.lsvMemberContacts.SetDataSource(
                    member.Contacts);
            }
            else
            {
                this.lsvMemberContacts.SetDataSource(null);
            }
        }


        internal void Cleanup()
        {
            this.fgvMembers.SelectionChanged -= new
                EventHandler(fgvMembers_SelectionChanged);

            this.lsvMemberContacts.Dispose();
            this.lsvMemberContacts.Visible = false;
        }
    }
}