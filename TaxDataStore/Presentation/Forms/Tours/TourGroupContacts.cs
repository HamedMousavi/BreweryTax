﻿using System;
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
                }
            }
        }

        
        protected FlatGridView fgvMembers;
        protected ContactsListView lsvMemberContacts;


        public TourGroupContacts(Entities.TourGroup group)
            : this()
        {
            this.Group = group;
        }


        public TourGroupContacts()
        {
            InitializeComponent();

            SetupControls();
            BindControls();
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
            this.fgvMembers.ColumnHeadersVisible = false;
            this.fgvMembers.Margin = new Padding(2, 2, 1, 2);
            this.lsvMemberContacts.Margin = new Padding(0, 2, 2, 2);

            this.tlpMain.Controls.Add(this.fgvMembers, 0, 1);
            this.tlpMain.Controls.Add(this.lsvMemberContacts, 1, 1);

            this.fgvMembers.SelectionChanged += new
                EventHandler(fgvMembers_SelectionChanged);

            this.editToolbar.AddButtonClick += new 
                EventHandler(editToolbar_AddButtonClick);
        }


        void editToolbar_AddButtonClick(object sender, EventArgs e)
        {
            Presentation.Controllers.Tours.AddMember(this.group);
        }


        private void BindControls()
        {
            if (this.group != null)
            {
                this.fgvMembers.DataSource = this.Group.Members;
            }
        }


        void fgvMembers_SelectionChanged(object sender, EventArgs e)
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
    }
}
