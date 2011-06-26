using System.Drawing;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class FormLabel : Label
    {

        protected string textResourceName;


        public FormLabel(int tabIndex, string name, bool useLightTheme, string textResourceName)
            :base()
        {
            this.SuspendLayout();

            this.textResourceName = textResourceName;
            this.Name = name;

            this.AutoSize = true;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ForeColor = Color.DimGray;
            this.TabIndex = tabIndex;

            this.Location = new Point(0, 0);
            this.Size = new Size(50, 15);

            if (Presentation.View.Theme != null)
            {
                this.Font = Presentation.View.Theme.FormLabelFont;

                if (useLightTheme)
                {
                    this.ForeColor = Presentation.View.Theme.FormLightLabelColor;
                }
                else
                {
                    this.ForeColor = Presentation.View.Theme.FormLabelColor;
                }
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
