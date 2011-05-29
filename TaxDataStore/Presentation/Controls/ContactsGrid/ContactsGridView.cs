using System.Windows.Forms;
using Entities;
using System.Drawing;


namespace TaxDataStore.Presentation.Controls
{
    public class ContactsGridView : FlatGridView
    {

        public ContactsGridView(ContactCollection contacts)
            : base(false, false)
        {
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //this.ColumnHeadersVisible = false;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridColor = Color.Gray;

            ContactMediaTypeCbxColumn col = new ContactMediaTypeCbxColumn();
            col.DataPropertyName = "Media";
            col.HeaderText = "Media";
            this.Columns.Add(col);
            
            this.SetDataSource(contacts);
        }


        public ContactsGridView(BindingSource dataSource, string dataMember)
            : base(false, false)
        {
            this.ColumnHeadersVisible = false;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            //this.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(EmployeesGridView_DataBindingComplete);

            ContactMediaTypeCbxColumn col = new ContactMediaTypeCbxColumn();
            col.DataPropertyName = "Media";
            col.HeaderText = "Media";
            this.Columns.Add(col);

            this.hiddenColumnNames.Add("Id");
            this.bs.DataSource = dataSource;
            this.bs.DataMember = dataMember;
        }

        /*
        void EmployeesGridView_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            //this.Columns["PaymentType"].HeaderText = Resources.Texts.grid_title_payment_type;

            string[] invisibles = new string[] { "Id" };
            foreach (DataGridViewColumn column in this.Columns)
            {
                if (invisibles.Contains(column.Name)) column.Visible = false;
            }

            AdjustColumns();
        }*/
    }
}
