using System.Windows.Forms;
using System.Drawing;


namespace TaxDataStore.Presentation.Controls
{

    public class ToursGridView : FlatGridView
    {

        public ToursGridView(BindingSource tours)
            : base(true, true, tours)
        {
            this.hiddenColumnNames.Add("Comments");
            this.hiddenColumnNames.Add("Receipt");

            this.headerColumnNames.Add("Time", Resources.Texts.grid_title_time);
            this.headerColumnNames.Add("TourType", Resources.Texts.grid_title_tour_type);
            this.headerColumnNames.Add("SignUpType", Resources.Texts.grid_title_signup_type);


            this.ColumnHeadersVisible = false;
            //this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 175, 160, 100);
            //this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.Font = Presentation.View.Theme.FormLabelFont;

            this.CellPainting += new DataGridViewCellPaintingEventHandler(ToursGridView_CellPainting);
        }


        void ToursGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = this.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell != null && cell.Value is Entities.GeneralType)
                {
                    Entities.GeneralType type = (Entities.GeneralType)cell.Value;
                    if (DomainModel.TourStates.Exists(type))
                    {
                        if (type.Id == 14/*Reserved*/)
                        {
                            //cell.Style.BackColor = Color.Gold;
                            cell.Style.ForeColor = Color.Orange;
                        }
                        else if (type.Id == 15/*Reserved*/)
                        {
                            //cell.Style.BackColor = Color.LightGreen;
                            cell.Style.ForeColor = Color.DarkGreen;
                        }
                    }
                }
            }
        }
    }
}
