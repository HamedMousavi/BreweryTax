using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourGroupEmployees : UserControl
    {
        
        private EditToolbar etbButtons;
        private FlatGridView fgvEmployees;
        private BindingSource bstEmployees;

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


        public TourGroupEmployees()
        {
            InitializeComponent();

            SetupControls();
        }


        private void SetupControls()
        {
            this.bstEmployees = new BindingSource();

            this.fgvEmployees = new FlatGridView();
            this.fgvEmployees.ColumnHeadersVisible = false;
            this.fgvEmployees.DataSource = this.bstEmployees;

            if (DomainModel.Application.ResourceManager != null)
            {
                string title = DomainModel.Application.ResourceManager.GetText("lbl_employees");
                this.etbButtons = new TaxDataStore.EditToolbar(title, true, false, true);
                this.etbButtons.Location = new System.Drawing.Point(0, 0);
                this.etbButtons.Name = "etbButtons";
                this.etbButtons.TabIndex = 0;
                this.etbButtons.Anchor = AnchorStyles.Left | 
                    AnchorStyles.Top | AnchorStyles.Right;

                this.tlpMain.Controls.Add(this.etbButtons, 0, 0);
            }

            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.TourGroupItemBackColor;
                this.etbButtons.BackColor = this.BackColor;

                this.fgvEmployees.Font = Presentation.View.Theme.FormLabelFont;
            }

            this.tlpMain.Controls.Add(this.fgvEmployees, 0, 1);
        }


        private void BindControls()
        {
            this.bstEmployees.DataSource = this.group;
            this.bstEmployees.DataMember = "Employees";
            this.bstEmployees.ResetBindings(true);
        }
    }
}
