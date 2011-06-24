using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class FlexibleTimeSelector : UserControl
    {

        public Entities.TourConstraintTimeItem Time { get; set; }


        public FlexibleTimeSelector()
        {
            InitializeComponent();

            for (int i = 1; i < 25; i++)
            {
                this.cbxHour.Items.Add(i.ToString());
            }

            for (int i = 0; i < 60; i++)
            {
                this.cbxMinute.Items.Add(i.ToString());
            }

            this.Time = new Entities.TourConstraintTimeItem();
        }


        private void cbxHour_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            this.Time.Hour = index - 1;
        }


        private void cbxMinute_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            this.Time.Minute = index - 1;
        }


        internal void UpdateControlData()
        {
            this.cbxHour.SelectedIndex = this.Time.Hour;
            this.cbxMinute.SelectedIndex = this.Time.Minute;
        }
    }
}
