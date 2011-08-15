using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class ContactToolStripItem : ToolStripMenuItem
    {

        public ContactToolStripItem(TourMember person): base()
        {
            this.person = person;
            this.Text = person.FormattedValue;
        }


        public ContactToolStripItem(string text)
        {
            this.person = null;
            this.Text = text;
        }


        protected TourMember person;


        public TourMember Person
        {
            get
            {
                return this.person;
            }
        }
    }
}
