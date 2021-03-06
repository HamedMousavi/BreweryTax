﻿using System;
using System.Windows.Forms;
using Entities;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmTourMemberEditor : BaseForm
    {
        private FormLabel lblTitle;
        private FormLabel lblFirstName;
        private FormLabel lblLastName;
        private ToolbarLabel lblContacts;
        private FlatButton btnAddContact;
        private FlatButton btnRemoveContact;


        protected ContactsGridView dgvContacts;
        protected ComboBox cbxTitle;
        protected Entities.TourGroup group;
        protected TourMember member;
        protected TourMember editMember;


        public FrmTourMemberEditor()
        {
            InitializeComponent();

            CreateControls();

            this.Text = Resources.Texts.frm_title_member_editor;
            
            this.member = new TourMember();
            
            this.cbxTitle = new ComboBox();
            this.cbxTitle.Anchor = AnchorStyles.Top | 
                AnchorStyles.Left | AnchorStyles.Right;

            this.tbxFirstName.DataBindings.Add(
                new Binding(
                    "Text",
                    this.member,
                    "FirstName",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.tbxLastName.DataBindings.Add(
                new Binding(
                    "Text",
                    this.member,
                    "LastName",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.cbxTitle.DataBindings.Add(
                new Binding(
                    "SelectedItem",
                    this.member,
                    "Title",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    null,
                    string.Empty,
                    null));

            this.chbxAddToPhonebook.DataBindings.Add(
                new Binding(
                    "Checked",
                    this.member,
                    "IsInPhonebook",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    false,
                    string.Empty,
                    null));

            this.tlpMain.Controls.Add(this.cbxTitle, 1, 1);

            this.dgvContacts = new ContactsGridView(this.member.Contacts);
            this.tlpContacts.Controls.Add(this.dgvContacts, 0, 1);
            this.tlpContacts.SetColumnSpan(this.dgvContacts, 3);

            this.chbxAddToPhonebook.Checked = this.member.IsInPhonebook;

            this.cbxTitle.DataSource = DomainModel.PersonTitleTypes.GetAll();
            this.cbxTitle.DisplayMember = "Name";
            this.member.Title = this.cbxTitle.Items
                [this.cbxTitle.SelectedIndex] as GeneralType;
        }


        private void CreateControls()
        {
            this.lblTitle = new FormLabel(0, "lblTitle", false, "lbl_title");
            this.lblFirstName = new FormLabel(2, "lblFirstName", false, "lbl_first_name");
            this.lblLastName = new FormLabel(4, "lblLastName", false, "lbl_last_name");
            this.lblContacts = new ToolbarLabel(6, "lblContacts", "lbl_contacts");

            this.btnAddContact = new FlatButton(8, "btnAdd", "add", "add");
            this.btnRemoveContact = new FlatButton(9, "btnDelete", "delete", "delete");

            this.tlpContacts.Controls.Add(this.btnAddContact, 1, 0);
            this.tlpContacts.Controls.Add(this.btnRemoveContact, 2, 0);

            this.tlpMain.Controls.Add(this.lblTitle, 0, 1);
            this.tlpMain.Controls.Add(this.lblFirstName, 0, 2);
            this.tlpMain.Controls.Add(this.lblLastName, 0, 3);
            this.tlpContacts.Controls.Add(this.lblContacts, 0, 0);

            this.btnAddContact.Click += new EventHandler(btnAddContact_Click);
            this.btnRemoveContact.Click += new EventHandler(btnRemoveContact_Click);
        }


        public FrmTourMemberEditor(Entities.TourGroup group)
            : this()
        {
            this.group = group;
        }


        public FrmTourMemberEditor(TourMember member)
            : this()
        {
            this.editMember = member;
            this.editMember.CopyTo(this.member);

            //this.cbxTitle.SelectedItem = this.member.Title;
        }


        private void btnAddContact_Click(object sender, EventArgs e)
        {
            GeneralTypeCollection medias = 
                DomainModel.ContactMediaTypes.GetAll();

            Contact contact = new Contact();
            if (medias != null && medias.Count > 0)
            {
                contact.Media = medias[0];
            }
            this.member.Contacts.Add(contact);

            try
            {
                int lastId = Math.Max(this.dgvContacts.Rows.Count - 1, 0);
                this.dgvContacts.Rows[lastId].Cells[0].Selected = true;
                this.dgvContacts.BeginEdit(true);
            }
            catch (Exception)
            {
            }
        }


        private void btnRemoveContact_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)this.dgvContacts.SelectedItem;
            if (contact != null)
            {
                if (contact.Id >= 0)
                {
                    this.member.DeletedContacts.Add(contact);
                }

                this.member.Contacts.Remove(contact);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DomainModel.TourGroupMembers.Save(this.member, this.group))
            {
                DomainModel.Phonebook.Save(this.member);

                if (this.editMember != null)
                {
                    // Update edit user and database
                    this.member.CopyTo(this.editMember);
                }

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        
        public bool AlwaysInAddressbook
        {
            get
            {
                return !this.chbxAddToPhonebook.Visible;
            }

            set
            {
                this.chbxAddToPhonebook.Visible = !value;

                if (value)
                {
                    this.member.IsInPhonebook = true;
                }
            }
        }
    }
}
