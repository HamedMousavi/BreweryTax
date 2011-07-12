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
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridColor = System.Drawing.Color.Silver;
            this.ColumnHeadersBorderStyle = 
                System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            if (CostDetails != null) this.SetDataSource(CostDetails);
        }
    }
}
