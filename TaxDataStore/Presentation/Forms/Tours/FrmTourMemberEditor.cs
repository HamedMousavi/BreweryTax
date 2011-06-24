using System;
using System.Windows.Forms;
using Entities;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmTourMemberEditor : BaseForm
    {

        protected ContactsGridView dgvContacts;
        protected ComboBox cbxTitle;
        protected TourMemberCollection members;
        protected TourMember member;
        protected TourMember editMember;


        public FrmTourMemberEditor()
        {
            InitializeComponent();

            this.btnAddContact.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnRemoveContact.Image = DomainModel.Application.ResourceManager.GetImage("delete");

            this.Text = Resources.Texts.frm_title_member_editor;
            this.lblContacts.Text = Resources.Texts.gpx_contacts;
            
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


            this.tlpMain.Controls.Add(this.cbxTitle, 1, 0);

            this.dgvContacts = new ContactsGridView(this.member.Contacts);
            this.tlpContacts.Controls.Add(this.dgvContacts, 0, 1);
            this.tlpContacts.SetColumnSpan(this.dgvContacts, 3);

            this.Load += new EventHandler(FrmTourMemberEditor_Load);
        }


        public FrmTourMemberEditor(TourMemberCollection members)
            : this()
        {
            this.members = members;
        }


        public FrmTourMemberEditor(TourMember member)
            : this()
        {
            this.editMember = member;
            this.editMember.CopyTo(this.member);
        }


        void FrmTourMemberEditor_Load(object sender, EventArgs e)
        {
            this.cbxTitle.DataSource = DomainModel.PersonTitleTypes.GetAll();
            this.cbxTitle.DisplayMember = "Name";
            this.member.Title = this.cbxTitle.Items
                [this.cbxTitle.SelectedIndex] as GeneralType;
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
            if (this.editMember != null && this.members == null)
            {
                // Update edit user and database
                this.member.CopyTo(this.editMember);
            }
            else
            {
                this.members.Add(this.member);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
