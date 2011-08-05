using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourGroupEmployees : TourBaseControl
    {

        private EditToolbar etbButtons;
        private FlatGridView fgvEmployees;
        private BindingSource bstEmployees;
        private EmployeesMenu mnuEmployees;

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
            : base()
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

            this.mnuEmployees = new EmployeesMenu();
            this.mnuEmployees.ClickAction = OnMenuItemClicked;

            if (DomainModel.Application.ResourceManager != null)
            {
                string title = DomainModel.Application.ResourceManager.GetText("lbl_employees");
                this.etbButtons = new TaxDataStore.EditToolbar(title, true, false, true);
                this.etbButtons.Location = new System.Drawing.Point(0, 0);
                this.etbButtons.Name = "etbButtons";
                this.etbButtons.TabIndex = 0;
                this.etbButtons.Anchor = AnchorStyles.Left |
                    AnchorStyles.Top | AnchorStyles.Right;
                this.etbButtons.AddContextMenu = this.mnuEmployees;

                this.tlpMain.Controls.Add(this.etbButtons, 0, 0);
            }

            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.TourGroupItemBackColor;
                this.etbButtons.BackColor = this.BackColor;

                this.fgvEmployees.Font = Presentation.View.Theme.FormLabelFont;
            }

            this.tlpMain.Controls.Add(this.fgvEmployees, 0, 1);

            this.etbButtons.DeleteButtonClick += new System.EventHandler(etbButtons_DeleteButtonClick);
        }


        private void BindControls()
        {
            this.bstEmployees.DataSource = this.group;
            this.bstEmployees.DataMember = "Employees";
            this.bstEmployees.ResetBindings(true);
        }


        public void OnMenuItemClicked(string itemName)
        {
            Entities.Employee emp = DomainModel.Employees.GetByName(itemName);
            if (emp != null)
            {
                if (!this.group.Employees.Contains(emp))
                {
                    if (DomainModel.TourGroupEmployees.Add(this.group, emp))
                    {   
                    }
                }
            }
        }


        void etbButtons_DeleteButtonClick(object sender, System.EventArgs e)
        {
            Entities.Employee emp = (Entities.Employee)
                this.fgvEmployees.SelectedItem;

            if (emp != null)
            {
                if (DomainModel.TourGroupEmployees.Delete(this.group, emp))
                {
                    group.Employees.Remove(emp);
                }
            }
        }
    }
}
