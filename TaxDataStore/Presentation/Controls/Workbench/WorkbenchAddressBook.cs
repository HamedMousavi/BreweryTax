using System.Windows.Forms;

namespace TaxDataStore.Presentation.Controls
{
    public class WorkbenchAddressBook : WorkbenchItem
    {
        public WorkbenchAddressBook()
            : base("addressbook")
        {
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.ClickAction = Presentation.Controllers.Phonebook.Display;
        }
    }
}
