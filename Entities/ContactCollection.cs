using System.ComponentModel;


namespace Entities
{

    public class ContactCollection : BindingList<Contact>
    {

        internal void CopyTo(ContactCollection contacts)
        {
            contacts.Clear();

            foreach (Contact contact in this)
            {
                Contact newcontact = new Contact();
                contact.CopyTo(newcontact);

                contacts.Add(newcontact);
            }
        }


        public void UndoDelete(ContactCollection originalList)
        {
            foreach (Contact contact in this)
            {
                originalList.Add(contact);
            }

            this.Clear();
        }
    }
}
