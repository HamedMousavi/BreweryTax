using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class EmployeesGridView : FlatGridView
    {

        public EmployeesGridView(EmployeeCollection employees)
            : base()
        {
            this.ColumnHeadersVisible = false;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            this.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(EmployeesGridView_DataBindingComplete);
            this.SetDataSource(employees);
        }


        void EmployeesGridView_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            AdjustColumns();
        }
    }
}
