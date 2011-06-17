using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class FormLabel : Label
    {

        protected string textResourceName;


        public FormLabel(string textResourceName)
        {
            this.textResourceName = textResourceName;
            this.Text = string.Empty;

            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }


        protected override void OnVisibleChanged(System.EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible && Presentation.View.Theme != null)
            {
                if (this.Font != Presentation.View.Theme.FormLabelFont)
                {
                    this.Font = Presentation.View.Theme.FormLabelFont;
                }

                if (this.ForeColor != Presentation.View.Theme.FormLabelColor)
                {
                    this.ForeColor = Presentation.View.Theme.FormLabelColor;
                }
            }

            if (string.IsNullOrWhiteSpace(this.Text) &&
                !string.IsNullOrWhiteSpace(this.textResourceName) && 
                DomainModel.Application.ResourceManager != null)
            {
                this.Text = DomainModel.Application.ResourceManager.GetText(this.textResourceName);
            }
        }
    }
}
