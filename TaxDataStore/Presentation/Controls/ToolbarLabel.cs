using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class ToolbarLabel : Label
    {
        public ToolbarLabel()
            : base()
        {
            this.VisibleChanged += new EventHandler(ToolbarLabel_VisibleChanged);
        }


        void ToolbarLabel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && Presentation.View.Theme != null)
            {
                this.Font = Presentation.View.Theme.ToolbarLabelFont;
                this.ForeColor = Presentation.View.Theme.ToolbarLabelColor;

                this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

                this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }
        }
    }
}
