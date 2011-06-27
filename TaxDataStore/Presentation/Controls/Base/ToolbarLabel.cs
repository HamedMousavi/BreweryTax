using System.Drawing;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class ToolbarLabel : Label
    {

        protected string textResourceName;


        public ToolbarLabel(int tabIndex, string name, string textResourceName)
            : base()
        {
            this.SuspendLayout();


            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;


            this.textResourceName = textResourceName;
            this.Name = name;
            this.TabIndex = tabIndex;

            this.Location = new Point(0, 0);
            this.Size = new Size(50, 15);

            this.AutoSize = true;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.TextAlign = ContentAlignment.MiddleLeft;

            if (Presentation.View.Theme != null)
            {
                this.Font = Presentation.View.Theme.GroupPanelTitleFont;
                this.ForeColor = Presentation.View.Theme.GroupPanelTitleColor;
            }
            else
            {
                this.ForeColor = Color.DimGray;
            }

            if (!string.IsNullOrWhiteSpace(this.textResourceName) &&
                DomainModel.Application.ResourceManager != null)
            {
                this.Text = DomainModel.Application.ResourceManager.GetText(
                    this.textResourceName);

                if (string.IsNullOrWhiteSpace(this.Text))
                {
                    this.Text = this.textResourceName;
                }
            }

            this.ResumeLayout();
        }
    }
}
