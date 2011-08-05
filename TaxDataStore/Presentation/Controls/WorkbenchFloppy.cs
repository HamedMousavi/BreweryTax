using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class WorkbenchFloppy : WorkbenchItem
    {
        public WorkbenchFloppy()
            : base("floppy")
        {
            this.Anchor = AnchorStyles.Right ;//| AnchorStyles.Top;

            if (DomainModel.Membership.Users.Authorise("Manage application settings"))
            {
                this.ClickAction = Presentation.Controllers.Application.Settings;
            }
            else
            {
                this.ClickAction = Presentation.Controllers.Users.Settings;
            }
        }
    }
}
