

namespace TaxDataStore.Presentation.Controls
{

    public class TourCostRulesGridView : FlatGridView
    {

        public TourCostRulesGridView()
        {
            this.hiddenColumnNames.Add("Id");
            this.hiddenColumnNames.Add("IsPerPerson");

            this.ColumnHeadersVisible = false;
            this.Font = Presentation.View.Theme.FormLabelFont;
        }
    }
}
