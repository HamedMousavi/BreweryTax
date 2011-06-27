using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class TourCostSettings : UserControl
    {
        private ToolbarLabel lblTourPrices;
        private ToolbarLabel lblCostRules;
        private ToolbarLabel lblGroup;
        private ToolbarLabel lblGroupRules;

        protected TourBasePriceGridView dgvTourPrices;
        protected TourCostRulesGridView dgvRules;
        protected TourCostGroupsGridView dgvGroups;
        protected RulesCheckedListBox clbRules;


        public TourCostSettings()
        {
            InitializeComponent();

            CreateControls();

            this.Dock = DockStyle.Fill;

            this.btnAddGroup.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnEditGroup.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            this.btnRemoveGroup.Image = DomainModel.Application.ResourceManager.GetImage("delete");

            this.btnAddRule.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnEditRule.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            this.btnRemoveRule.Image = DomainModel.Application.ResourceManager.GetImage("delete");

            this.btnEditTourPrice.Image = DomainModel.Application.ResourceManager.GetImage("pencil");

            this.dgvTourPrices = new TourBasePriceGridView();
            this.tlpTourPriceContainer.Controls.Add(this.dgvTourPrices, 0, 1);

            this.dgvRules = new TourCostRulesGridView();
            this.dgvRules.SetDataSource(DomainModel.TourCostRules.GetAll());
            this.tlpCostRules.Controls.Add(this.dgvRules, 0, 1);

            this.dgvGroups = new TourCostGroupsGridView();
            this.dgvGroups.SetDataSource(DomainModel.TourCostGroups.GetAll());
            this.dgvGroups.SelectionChanged += new System.EventHandler(dgvGroups_SelectionChanged);
            this.tlpCostGroups.Controls.Add(this.dgvGroups, 0, 1);

            this.clbRules = new RulesCheckedListBox();
            this.tlpCostGroups.Controls.Add(this.clbRules, 1, 1);
        }


        private void CreateControls()
        {
            this.lblGroup = new ToolbarLabel(0, "lblGroup", "lbl_group");
            this.lblGroupRules = new ToolbarLabel(1, "lblGroupRules", "lbl_group_rules");
            this.lblTourPrices = new ToolbarLabel(2, "lblTourPrices", "lbl_tour_prices");
            this.lblCostRules = new ToolbarLabel(3, "lblCostRules", "lbl_cost_rules");


            this.tlpCostGroups.Controls.Add(this.lblGroupRules, 1, 0);
            this.tlpCostGroupButtons.Controls.Add(this.lblGroup, 0, 0);
            this.tlpCostRuleButtons.Controls.Add(this.lblCostRules, 0, 0);
            this.tlpButtons.Controls.Add(this.lblTourPrices, 0, 0);
        }


        void dgvGroups_SelectionChanged(object sender, System.EventArgs e)
        {
            if (this.dgvGroups.SelectedItem != null)
            {
                Entities.TourCostGroup group = 
                    (Entities.TourCostGroup)dgvGroups.SelectedItem;
                if (group == null)
                {
                }
                else
                {
                    if (this.clbRules.Group != group)
                    {
                        this.clbRules.Group = group;
                    }

                    this.clbRules.UpdateBinding();
                }
            }        
        }


        private void btnEditTourPrice_Click(object sender, System.EventArgs e)
        {
            Entities.TourBasePrice price = (Entities.TourBasePrice)
                this.dgvTourPrices.SelectedItem;

            if (price != null)
            {
                Presentation.Controllers.TourFinance.EditBasePrice(price);
            }
        }


        private void btnAddRule_Click(object sender, System.EventArgs e)
        {
            Presentation.Controllers.TourFinance.AddRule();
        }


        private void btnEditRule_Click(object sender, System.EventArgs e)
        {
            Entities.TourCostRule rule =
                (Entities.TourCostRule)dgvRules.SelectedItem;
            if (rule != null)
            {
                Presentation.Controllers.TourFinance.EditRule(rule);
            }
        }


        private void btnRemoveRule_Click(object sender, System.EventArgs e)
        {
            Entities.TourCostRule rule =
                (Entities.TourCostRule)dgvRules.SelectedItem;
            if (rule != null)
            {
                Presentation.Controllers.TourFinance.DeleteRule(rule);
            }
        }


        private void btnAddGroup_Click(object sender, System.EventArgs e)
        {
            Presentation.Controllers.TourFinance.AddGroup();
        }


        private void btnEditGroup_Click(object sender, System.EventArgs e)
        {
            Entities.TourCostGroup group =
                (Entities.TourCostGroup)dgvGroups.SelectedItem;
            if (group != null)
            {
                Presentation.Controllers.TourFinance.EditGroup(group);
            }
        }


        private void btnRemoveGroup_Click(object sender, System.EventArgs e)
        {
            Entities.TourCostGroup group =
                (Entities.TourCostGroup)dgvGroups.SelectedItem;
            if (group != null)
            {
                Presentation.Controllers.TourFinance.DeleteGroup(group);
            }
        }
    }
}
