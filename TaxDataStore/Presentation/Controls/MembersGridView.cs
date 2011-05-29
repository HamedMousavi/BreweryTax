using System.Linq;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{
    public class MembersGridView : FlatGridView
    {

        public MembersGridView(TourMemberCollection members)
            : base()
        {
            this.ColumnHeadersVisible = false;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            this.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(EmployeesGridView_DataBindingComplete);
            this.SetDataSource(members);
        }


        void EmployeesGridView_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            //this.Columns["PaymentType"].HeaderText = Resources.Texts.grid_title_payment_type;

            string[] invisibles = new string[] { "Title", "Contacts", "MemberShip"};
            foreach (DataGridViewColumn column in this.Columns)
            {
                if (invisibles.Contains(column.Name)) column.Visible = false;
            }

            AdjustColumns();
        }
    }}
