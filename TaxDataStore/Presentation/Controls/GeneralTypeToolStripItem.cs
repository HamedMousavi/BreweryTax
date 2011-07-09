using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class GeneralTypeToolStripItem : ToolStripMenuItem
    {

        protected GeneralType type;


        public GeneralType GeneralType
        {
            get
            {
                return this.type;
            }
        }


        public GeneralTypeToolStripItem(GeneralType type)
            : base()
        {
            this.type = type;
            this.Text = type.Name;
            this.Image = null;
            this.Visible = true;
            this.ForeColor = System.Drawing.Color.Black;
        }
    }
}
