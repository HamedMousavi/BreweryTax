using Entities;
using System.Drawing;


namespace TaxDataStore.Presentation.Controls
{

    public class TourPaymentDetailsGridView : FlatGridView
    {

        public TourPaymentDetailsGridView(TourPaymentDetailCollection paymentDetails)
            : base(false, true)
        {
            this.hiddenColumnNames.Add("Id");
            this.readonlyColumnNames.Add("PaymentGroup");

            //this.ColumnHeadersVisible = false;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            this.ForeColor = Color.Black;

            this.SetDataSource(paymentDetails);
        }
    }
}
