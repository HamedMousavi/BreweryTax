using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class TourGroup : UserControl
    {

        protected Entities.TourGroup group;

        public Entities.TourGroup Group
        {
            get { return this.group; }
            set
            {
                if (this.group != value)
                {
                    this.group = value;
                    BindControls();
                }
            }
        }


        TourGroupDetails ctrlDetail;
        TourGroupContacts ctrlContacts;
        TourGroupServices ctrlServices;


        public TourGroup()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.BackColor = System.Drawing.Color.Gray;
            
            SetupControls();
        }


        public TourGroup(Entities.TourGroup group)
            : this()
        {
            this.Group = group;
        }


        private void SetupControls()
        {
            this.ctrlDetail = new TourGroupDetails();
            this.ctrlContacts = new TourGroupContacts();
            this.ctrlServices = new TourGroupServices();

            this.ctrlDetail.Dock = DockStyle.Fill;
            this.ctrlContacts.Dock = DockStyle.Fill;
            this.ctrlServices.Dock = DockStyle.Fill;

            this.tlpMain.Controls.Add(this.ctrlDetail, 0, 0);
            this.tlpMain.Controls.Add(this.ctrlContacts, 1, 0);
            this.tlpMain.Controls.Add(this.ctrlServices, 2, 0);
        }


        private void BindControls()
        {
            this.ctrlDetail.DataBindings.Clear();
            this.ctrlServices.DataBindings.Clear();
            this.ctrlContacts.DataBindings.Clear();

            this.ctrlDetail.DataBindings.Add(new Binding("Group", this, "Group"));
            this.ctrlServices.DataBindings.Add(new Binding("Group", this, "Group"));
            this.ctrlContacts.DataBindings.Add(new Binding("Group", this, "Group"));
        }
    }
}
