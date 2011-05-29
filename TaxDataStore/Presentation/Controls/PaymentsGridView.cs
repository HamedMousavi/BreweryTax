using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class PaymentsGridView : FlatGridView
    {

        public PaymentsGridView(TourPaymentCollection payments)
            : base()
        {
            this.ColumnHeadersVisible = false;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            //this.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(EmployeesGridView_DataBindingComplete);
            this.SetDataSource(payments);
        }

        /*
        void EmployeesGridView_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            AdjustColumns();
        }*/
    }
}
