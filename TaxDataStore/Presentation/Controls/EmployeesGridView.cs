using System.Drawing;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class EmployeesGridView : FlatGridView
    {

        public EmployeesGridView(EmployeeCollection employees)
            : base()
        {
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridColor = Color.LightGray;

            this.SetDataSource(employees);
        }
    }
}
