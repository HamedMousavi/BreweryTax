using System.Windows.Forms;

namespace TaxDataStore.Presentation.Controls
{
    public class ContactMediaTypeCbxColumn : DataGridViewComboBoxColumn
    {
        public ContactMediaTypeCbxColumn()
        {
            this.DataSource = DomainModel.ContactMediaTypes.GetAll();
            this.DisplayMember = "Name";
            this.ValueMember = "This";

            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        }
    }
}
