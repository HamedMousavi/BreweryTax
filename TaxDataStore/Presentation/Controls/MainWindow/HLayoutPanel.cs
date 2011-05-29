using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class HLayoutPanel : TableLayoutPanel
    {

        protected override void OnVisibleChanged(System.EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible)
            {
                if (this.RightToLeft != View.LayoutDirection)
                {
                    this.RightToLeft =
                        View.LayoutDirection;
                }
            }
        }
    }
}
