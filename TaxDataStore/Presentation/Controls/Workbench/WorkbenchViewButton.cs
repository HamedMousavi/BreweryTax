
namespace TaxDataStore.Presentation.Controls
{
    public class WorkbenchViewButton : FlatButton
    {
        public WorkbenchViewButton()
            : base(0, "btnWorkbenchView", "arrow_turn_180_left", "lbl_back_to_workbench")
        {
            this.Click += new System.EventHandler(WorkbenchViewButton_Click);
        }


        void WorkbenchViewButton_Click(object sender, System.EventArgs e)
        {
            Presentation.Controllers.Desktop.Workbench();
        }
    }
}
