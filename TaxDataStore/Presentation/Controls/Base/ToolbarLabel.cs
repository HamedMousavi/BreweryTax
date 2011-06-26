using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class ToolbarLabel : Label
    {

        protected string textResourceName;


        public ToolbarLabel()
            : base()
        {
            this.VisibleChanged += new EventHandler(ToolbarLabel_VisibleChanged);
        }


        public ToolbarLabel(string textResourceName)
            : this()
        {
            this.textResourceName = textResourceName;
        }


        void ToolbarLabel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && Presentation.View.Theme != null)
            {
                this.Font = Presentation.View.Theme.GroupPanelTitleFont;
                this.ForeColor = Presentation.View.Theme.GroupPanelTitleColor;

                this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

                this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                if (string.IsNullOrWhiteSpace(this.Text) &&
                !string.IsNullOrWhiteSpace(this.textResourceName) &&
                DomainModel.Application.ResourceManager != null)
                {
                    this.Text = DomainModel.Application.ResourceManager.GetText(this.textResourceName);
                }
            }
        }
    }
}
