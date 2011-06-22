

namespace TaxDataStore.Presentation.Controls
{

    public class TourCostGroupsGridView : FlatGridView
    {
        public TourCostGroupsGridView()
            : base()
        {
            this.hiddenColumnNames.Add("Id");

            this.ColumnHeadersVisible = false;
            this.Font = Presentation.View.Theme.FormLabelFont;
        }
    }
}
