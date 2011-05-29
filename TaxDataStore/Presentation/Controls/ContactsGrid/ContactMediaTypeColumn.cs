using System.Windows.Forms;
using System;


namespace TaxDataStore.Presentation.Controls
{

    public class ContactMediaTypeColumn : DataGridViewColumn
    {

        public ContactMediaTypeColumn()
            : base(new ContactMediaTypeCell())
        {
        }


        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(ContactMediaTypeCell)))
                {
                    throw new InvalidCastException("Must be a ContactMediaTypeCell");
                }

                base.CellTemplate = value;
            }
        }

    }
}
