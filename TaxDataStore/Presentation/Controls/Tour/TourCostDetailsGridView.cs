using Entities;
using System.Drawing;


namespace TaxDataStore.Presentation.Controls
{

    public class TourCostDetailsGridView : FlatGridView
    {

        public TourCostDetailsGridView(TourCostDetailCollection CostDetails)
            : base(false, true)
        {
            this.hiddenColumnNames.Add("Id");
            this.readonlyColumnNames.Add("CostGroup");

            //this.ColumnHeadersVisible = false;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            this.ForeColor = Color.Black;

            if (CostDetails != null) this.SetDataSource(CostDetails);
        }
    }
}
