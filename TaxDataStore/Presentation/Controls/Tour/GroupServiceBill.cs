using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class GroupServiceBill : UserControl
    {

        private Entities.TourServiceBase service;
        protected TourReceiptListView rlvBill;


        public GroupServiceBill(Entities.TourServiceBase service)
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            
            this.service = service;
            this.rlvBill = new TourReceiptListView();
            this.rlvBill.SetDataSource(this.service.Bill);

            this.tlpMain.Controls.Add(this.rlvBill, 0, 1);
            this.tlpMain.SetColumnSpan(this.rlvBill, 2);
        }
    }
}
