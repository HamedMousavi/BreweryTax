using System.Windows.Forms;
using Entities;
using System.Drawing;


namespace TaxDataStore.Presentation.Controls
{
    public class ContactsGridView : FlatGridView
    {

        public ContactsGridView()
            : base(false, false)
        {
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridColor = Color.LightGray;

            GeneralTypeDataGridViewColumn col =
                new GeneralTypeDataGridViewColumn(
                    DomainModel.ContactMediaTypes.GetAll(),
                    true,
                    "Media",
                    "Media");
            this.Columns.Add(col);
        }

        public ContactsGridView(ContactCollection contacts)
            : this()
        {
            
            this.SetDataSource(contacts);
        }


        public ContactsGridView(BindingSource dataSource, string dataMember)
            : this()
        {
            this.hiddenColumnNames.Add("Id");
            this.bs.DataSource = dataSource;
            this.bs.DataMember = dataMember;
        }

        /*
        void EmployeesGridView_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            //this.Columns["CostType"].HeaderText = Resources.Texts.grid_title_Cost_type;

            string[] invisibles = new string[] { "Id" };
            foreach (DataGridViewColumn column in this.Columns)
            {
                if (invisibles.Contains(column.Name)) column.Visible = false;
            }

            AdjustColumns();
        }*/
    }
}
