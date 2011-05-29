using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class TypeComboBox : ComboBox
    {

        public TypeComboBox(string typeName)
        {
            this.DataSource = DomainModel.Types.GetByName(
                typeName, 
                DomainModel.Application.User.Culture);

            this.DisplayMember = "Name";
        }
    }
}
