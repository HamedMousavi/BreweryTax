using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class ContactsMenu : ContextMenuStrip
    {

        protected ToolStripMenuItem phoneBookSub;

        public delegate void ExecutionAction(Entities.TourMember item);
        public ExecutionAction ClickAction { get; set; }


        protected Entities.TourMemberCollection persons;
        public Entities.TourMemberCollection Persons
        {
            get { return this.persons; }
            set 
            {
                if (this.persons != value)
                {
                    this.persons = value;
                    this.persons.ListChanged += new System.ComponentModel.ListChangedEventHandler(persons_ListChanged);

                    UpdateMenu();
                }
            }
        }


        void persons_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            UpdateMenu();
        }


        private void UpdateMenu()
        {
            this.phoneBookSub.DropDownItems.Clear();
            foreach(Entities.TourMember member in this.persons)
            {
                this.phoneBookSub.DropDownItems.Add(new 
                    ContactToolStripItem(member));
            }
        }
        

        public ContactsMenu()
        {
            this.phoneBookSub = new ToolStripMenuItem(
                DomainModel.Application.ResourceManager.GetText("mnu_phone_book"));

            this.Items.Add(new ContactToolStripItem(
                DomainModel.Application.ResourceManager.GetText("mnu_new_contact")));

            this.Items.Add(this.phoneBookSub);

            this.phoneBookSub.DropDownItemClicked += new 
                ToolStripItemClickedEventHandler(phoneBookSub_DropDownItemClicked);
            this.ItemClicked += new ToolStripItemClickedEventHandler(ContactsMenu_ItemClicked);
        }


        void ContactsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContactToolStripItem item =
                (ContactToolStripItem)e.ClickedItem;

            if (item != null)
            {
                if (ClickAction != null) ClickAction(item.Person);
            }
        }


        void phoneBookSub_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContactToolStripItem item =
                (ContactToolStripItem)e.ClickedItem;

            if (item != null)
            {
                if (ClickAction != null) ClickAction(item.Person);
            }
        }

    }
}
