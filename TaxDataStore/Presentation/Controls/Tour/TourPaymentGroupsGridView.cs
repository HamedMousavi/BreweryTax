

namespace TaxDataStore.Presentation.Controls
{

    public class TourPaymentGroupsGridView : FlatGridView
    {
        public TourPaymentGroupsGridView()
            : base()
        {
            this.hiddenColumnNames.Add("Id");

            this.ColumnHeadersVisible = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
        }
    }
}
