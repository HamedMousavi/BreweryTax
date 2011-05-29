using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class ContactMediaTypeCell : DataGridViewComboBoxCell
    {

        public ContactMediaTypeCell()
            : base()
        {
        }


        protected override bool SetValue(int rowIndex, object value)
        {
            return base.SetValue(rowIndex, value);
        }

        
        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);

            ImageComboBox ctl =
                DataGridView.EditingControl as ImageComboBox;

            // Use the default row value when Value property is null.
            try
            {
                Entities.GeneralType value = (Entities.GeneralType)initialFormattedValue;
                ctl.SelectedItem = value;
            }
            catch (Exception)
            {
                ctl.SelectedItem = null;
            }
        }


        public override Type EditType
        {
            get
            {
                // Return the type of the editing control that CalendarCell uses.
                return typeof(ImageComboBox);
            }
        }


        public override Type ValueType
        {
            get
            {
                // Return the type of the value that CalendarCell contains.

                return typeof(Entities.GeneralType);
            }
        }


        public override object DefaultNewRowValue
        {
            get
            {
                // Use the current date and time as the default value.
                return new Entities.GeneralType();
            }
        }
    }
}
