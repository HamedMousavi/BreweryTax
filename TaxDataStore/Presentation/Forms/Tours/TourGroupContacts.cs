using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourGroupContacts : UserControl
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
                    if (this.fgvMembers != null && value !=null && value.Members != null)
                    {
                        this.fgvMembers.SetDataSource(value.Members);
                    }

                    //this.group.va
                }
            }
        }

        
        protected FlatGridView fgvMembers;
        protected ContactsListView lsvMemberContacts;
        protected ContactsMenu mnuContacts;


        public TourGroupContacts()
        {
            InitializeComponent();

            SetupControls();
        }


        private void SetupControls()
        {
            this.fgvMembers = new FlatGridView();
            this.lsvMemberContacts = new ContactsListView();
            
            if (DomainModel.Application.ResourceManager != null)
            {
                this.editToolbar.Title = DomainModel.
                    Application.ResourceManager.GetText("lbl_contacts");
            }

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

            this.tlpMain.Controls.Add(this.fgvMembers, 0, 1);
            this.tlpMain.Controls.Add(this.lsvMemberContacts, 1, 1);

            this.fgvMembers.SelectionChanged += new
                EventHandler(fgvMembers_SelectionChanged);
            /*
            this.editToolbar.AddButtonClick += new 
                EventHandler(editToolbar_AddButtonClick);*/

            this.editToolbar.EditButtonClick += new 
                EventHandler(editToolbar_EditButtonClick);

            this.editToolbar.DeleteButtonClick += new 
                EventHandler(editToolbar_DeleteButtonClick);

            this.mnuContacts = new ContactsMenu();
            this.mnuContacts.ClickAction = OnContactMenu;
            this.mnuContacts.Persons = DomainModel.Phonebook.GetAll();
            this.editToolbar.AddContextMenu = this.mnuContacts;
        }


        public void OnContactMenu(Entities.TourMember item)
        {
            if (item == null)
            {
                // Add new contact
                Presentation.Controllers.Tours.AddMember(this.group);
            }
            else
            {
                DomainModel.TourGroupMembers.Save(item, this.group);
            }
        }


        void editToolbar_DeleteButtonClick(object sender, EventArgs e)
        {
            Entities.TourMember member = 
                (Entities.TourMember)this.fgvMembers.SelectedItem;

            if (member != null)
            {
                if (member.Id >= 0)
                {
                    if (DomainModel.TourGroupMembers.Delete(this.group, member))
                    {
                        group.Members.Remove(member);
                    }
                }
            }
        }


        void editToolbar_EditButtonClick(object sender, EventArgs e)
        {
            Entities.TourMember member = 
                (Entities.TourMember)this.fgvMembers.SelectedItem;

            if (member != null)
            {
                Presentation.Controllers.Tours.EditMember(member);
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
