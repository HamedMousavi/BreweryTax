using System.Windows.Forms;

namespace TaxDataStore.Presentation.Controls
{
    public class WorkbenchCalendar : WorkbenchItem
    {
        public WorkbenchCalendar()
            : base("calendar")
        {
            this.Anchor = AnchorStyles.Top;
            this.ClickAction = Presentation.Controllers.Tours.Today;
        }
    }
}
