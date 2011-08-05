

namespace TaxDataStore.Presentation.Controllers
{

    public class Phonebook
    {

        public static void Display()
        {
            using (FrmAddressbook frm = new FrmAddressbook())
            {
                frm.ShowDialog();
            }
        }


        internal static bool Delete(Entities.TourMember person)
        {
            if (person != null && person.Id >= 0)
            {
                return DomainModel.Phonebook.Delete(person);
            }

            return false;
        }


        internal static void Add()
        {
            using (FrmTourMemberEditor frm = new FrmTourMemberEditor())
            {
                frm.AlwaysInAddressbook = true;
                frm.ShowDialog();
            }
        }


        internal static void Edit(Entities.TourMember person)
        {
            using (FrmTourMemberEditor frm = new FrmTourMemberEditor(person))
            {
                frm.AlwaysInAddressbook = true;
                frm.ShowDialog();
            }
        }
    }
}
