

namespace TaxDataStore.Presentation.Controls
{

    public class TourBasePriceGridView : FlatGridView
    {
        public TourBasePriceGridView()
            : base()
        {
            GeneralTypeDataGridViewColumn col = 
                new GeneralTypeDataGridViewColumn(
                    DomainModel.TourTypes.GetAll(),
                    false,
                    "TourType",
                    "TourType");

            this.Columns.Add(col);

            this.ColumnHeadersVisible = false;

            this.DataSource = DomainModel.TourBasePrices.GetAll();
        }
    }
}
