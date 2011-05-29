using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{
    public class ToursGridView : FlatGridView
    {

        public ToursGridView(BindingSource tours)
            : base()
        {
            BindDatasource(tours);
        }


        private void BindDatasource(BindingSource tours)
        {
            this.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(ToursGridView_DataBindingComplete);
            this.DataSource = tours;
        }


        void ToursGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.Columns["Time"].HeaderText = Resources.Texts.grid_title_time;
            this.Columns["TourType"].HeaderText = Resources.Texts.grid_title_tour_type;
            this.Columns["SignUpType"].HeaderText = Resources.Texts.grid_title_signup_type;
            this.Columns["SignUpCount"].HeaderText = Resources.Texts.grid_title_signup_count;
            this.Columns["ParticipantsCount"].HeaderText = Resources.Texts.grid_title_participants;
            //this.Columns["PricePerPerson"].HeaderText = Resources.Texts.grid_title_price_per_person;
            //this.Columns["PaymentType"].HeaderText = Resources.Texts.grid_title_payment_type;

            this.Columns["Comments"].Visible = false;
            //this.Columns["Employees"].Visible = false;
            //this.Columns["Members"].Visible = false;

            AdjustColumns();
        }
    }
}
