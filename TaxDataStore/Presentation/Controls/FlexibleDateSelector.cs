using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public partial class ConstraintDateSelector : UserControl
    {

        public TourConstraintDateItem Date { get; set; }


        public ConstraintDateSelector()
        {
            InitializeComponent();
            this.Date = new TourConstraintDateItem();
        }


        private void cbxYear_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = ((ComboBox) sender).SelectedIndex;
            this.Date.Year = index - 1;
        }


        private void cbxMonths_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            this.Date.Month = index - 1;
        }


        private void cbxDay_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            this.Date.Day = index - 1;
        }


        internal void UpdateControlData()
        {
            this.cbxDay.SelectedIndex = this.Date.Day;
            this.cbxMonths.SelectedIndex = this.Date.Month;
            this.cbxYear.SelectedIndex = this.Date.Year;
        }
    }
}
