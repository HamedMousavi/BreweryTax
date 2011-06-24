using System;
using System.Windows.Forms;


namespace TaxDataStore
{

    public class BaseForm : Form
    {

        public BaseForm()
            : base()
        {
            this.Load += new EventHandler(BaseForm_Load);
        }


        void BaseForm_Load(object sender, EventArgs e)
        {
            if (Presentation.View.Theme != null)
            {
                if (this.BackColor != Presentation.View.Theme.FormBackColor)
                {
                    this.BackColor = Presentation.View.Theme.FormBackColor;
                }

                if (this.Font != Presentation.View.Theme.FormFont)
                {
                    this.Font = Presentation.View.Theme.FormFont;
                }
            }
        }
    }
}
