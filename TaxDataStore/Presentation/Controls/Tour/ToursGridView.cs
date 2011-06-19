using System.Windows.Forms;
using System.Drawing;


namespace TaxDataStore.Presentation.Controls
{

    public class ToursGridView : FlatGridView
    {

        public ToursGridView(BindingSource tours)
            : base()
        {
            this.hiddenColumnNames.Add("Comments");

            this.headerColumnNames.Add("Time", Resources.Texts.grid_title_time);
            this.headerColumnNames.Add("TourType", Resources.Texts.grid_title_tour_type);
            this.headerColumnNames.Add("SignUpType", Resources.Texts.grid_title_signup_type);

            this.DataSource = tours;

            this.ColumnHeadersVisible = false;
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 175, 160, 100);
            //this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.Font = Presentation.View.Theme.FormLabelFont;
        }
    }
}
