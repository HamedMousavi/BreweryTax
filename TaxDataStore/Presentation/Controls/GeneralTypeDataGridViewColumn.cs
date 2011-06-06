using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class GeneralTypeDataGridViewColumn : DataGridViewComboBoxColumn
    {

        public GeneralTypeDataGridViewColumn(object dataSource, bool editable, string dataPropertyName, string headerText = "")
            :base()
        {
            this.DataSource = dataSource;
            this.DataPropertyName = dataPropertyName;

            this.DisplayMember = "Name";
            this.ValueMember = "This";

            if (!string.IsNullOrWhiteSpace(headerText))
            {
                this.HeaderText = headerText;
            }

            if (!editable)
            {
                this.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            }
            else
            {
                this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            }
        }


        public GeneralTypeDataGridViewColumn()
            : base()
        {
        }
    }
}
