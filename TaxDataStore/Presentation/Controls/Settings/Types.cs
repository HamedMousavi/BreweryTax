using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls.Settings
{

    public partial class Types : UserControl
    {

        private FlatGridView flvclasses;
        private CategoryListView clvTypes;
        private ToolbarLabel lblCategory;
        private ToolbarLabel lblTypes;
        private FlatButton btnAddType;
        private FlatButton btnDeleteType;


        public Types()
        {
            InitializeComponent();

            CreateControls();


            this.Dock = DockStyle.Fill;

            this.panelCategory.Controls.Add(this.flvclasses);
            this.tlpMain.Controls.Add(this.clvTypes, 1, 0);

            this.flvclasses.SelectionChanged += new 
                System.EventHandler(flvclasses_SelectionChanged);

            this.panelCategory.BackColor = Presentation.View.Theme.GroupPanelBackColor;
        }


        private void CreateControls()
        {
            this.lblCategory = new ToolbarLabel(0, "lblCategory", "lbl_category");
            this.lblTypes = new ToolbarLabel(1, "lblTypes", "lbl_types");

            this.btnAddType = new TaxDataStore.Presentation.Controls.FlatButton(2, "btnAdd", "add", "add");
            this.btnDeleteType = new TaxDataStore.Presentation.Controls.FlatButton(3, "btnDelete", "delete", "delete");

            this.tlpButtons.Controls.Add(this.btnDeleteType, 2, 0);
            this.tlpButtons.Controls.Add(this.btnAddType, 1, 0);

            this.tlpToolbar.Controls.Add(this.lblCategory, 0, 0);
            this.tlpButtons.Controls.Add(this.lblTypes, 0, 0);


            this.flvclasses = new FlatGridView();
            this.flvclasses.ColumnHeadersVisible = false;
            this.flvclasses.Margin = new Padding(0, 0, 0, 0);
            this.flvclasses.DataSource = DomainModel.Categories.GetAll();

            this.clvTypes = new CategoryListView();
        }


        void flvclasses_SelectionChanged(object sender, System.EventArgs e)
        {
            Entities.CategoryClass cat = (Entities.CategoryClass)
                this.flvclasses.SelectedItem;

            if (cat != null)
            {
                this.clvTypes.DataSource = cat;
            }
        }


        private void btnAddType_Click(object sender, System.EventArgs e)
        {
            this.clvTypes.InsertNewRow();
        }


        private void btnDeleteType_Click(object sender, System.EventArgs e)
        {
            this.clvTypes.DeleteSelected();
        }
    }
}
