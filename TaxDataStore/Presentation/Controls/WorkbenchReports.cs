using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class WorkbenchReports : WorkbenchItem
    {

        public WorkbenchReports() :
            base("reports")
        {
            this.Anchor = /*AnchorStyles.Top |*/ AnchorStyles.Left;
            this.ClickAction = Presentation.Controllers.TourReports.MonthlyBill;
        }
    }
}
