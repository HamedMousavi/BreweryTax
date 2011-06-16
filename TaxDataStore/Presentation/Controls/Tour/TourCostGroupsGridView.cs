

namespace TaxDataStore.Presentation.Controls
{

    public class TourCostGroupsGridView : FlatGridView
    {
        public TourCostGroupsGridView()
            : base()
        {
            this.hiddenColumnNames.Add("Id");

            this.ColumnHeadersVisible = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
        }
    }
}
