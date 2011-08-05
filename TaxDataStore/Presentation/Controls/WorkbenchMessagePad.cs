using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class WorkbenchMessagePad : WorkbenchItem
    {
        public WorkbenchMessagePad()
            : base("notepad")
        {
            this.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        }
    }
}
