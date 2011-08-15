using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class WorkbenchWorklog : WorkbenchItem
    {

        public WorkbenchWorklog()
            : base("workhours")
        {
            this.Anchor = AnchorStyles.Bottom;
            this.ClickAction = Presentation.Controllers.Tours.Today;
        }
    }
}
