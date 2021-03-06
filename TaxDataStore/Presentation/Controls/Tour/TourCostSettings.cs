﻿using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class TourCostSettings : UserControl
    {
        private ToolbarLabel lblCostRules;
        private ToolbarLabel lblGroup;
        private ToolbarLabel lblGroupRules;

        private FlatButton btnAddRule;
        private FlatButton btnEditRule;
        private FlatButton btnRemoveRule;
        private FlatButton btnAddGroup;
        private FlatButton btnEditGroup;
        private FlatButton btnRemoveGroup;

        protected TourCostRulesGridView dgvRules;
        protected TourCostGroupsGridView dgvGroups;
        protected RulesCheckedListBox clbRules;

        protected ServiceSettings serviceSettings;

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
            this.serviceSettings = new ServiceSettings();

            this.lblGroup = new ToolbarLabel(0, "lblGroup", "lbl_group");
            this.lblGroupRules = new ToolbarLabel(1, "lblGroupRules", "lbl_group_rules");
            this.lblCostRules = new ToolbarLabel(3, "lblCostRules", "lbl_cost_rules");
            
            this.btnAddGroup = new FlatButton(4, "add", "add", "add");
            this.btnEditGroup = new FlatButton(5, "edit", "pencil", "edit");
            this.btnRemoveGroup = new FlatButton(6, "delete", "delete", "delete");
            this.btnAddRule = new FlatButton(8, "add", "add", "add");
            this.btnEditRule = new FlatButton(9, "edit", "pencil", "edit");
            this.btnRemoveRule = new FlatButton(10, "delete", "delete", "delete");

            this.tlpCostGroupButtons.Controls.Add(this.btnAddGroup, 1, 0);
            this.tlpCostGroupButtons.Controls.Add(this.btnEditGroup, 2, 0);
            this.tlpCostGroupButtons.Controls.Add(this.btnRemoveGroup, 3, 0);
            this.tlpCostRuleButtons.Controls.Add(this.btnAddRule, 1, 0);
            this.tlpCostRuleButtons.Controls.Add(this.btnEditRule, 2, 0);
            this.tlpCostRuleButtons.Controls.Add(this.btnRemoveRule, 3, 0);

            this.tlpCostGroups.Controls.Add(this.lblGroupRules, 1, 0);
            this.tlpCostGroupButtons.Controls.Add(this.lblGroup, 0, 0);
            this.tlpCostRuleButtons.Controls.Add(this.lblCostRules, 0, 0);

            this.tlpMain.Controls.Add(this.serviceSettings, 0, 0);

            this.btnAddGroup.Click += new System.EventHandler(btnAddGroup_Click);
            this.btnAddRule.Click += new System.EventHandler(btnAddRule_Click);
            this.btnEditGroup.Click += new System.EventHandler(btnEditGroup_Click);
            this.btnEditRule.Click += new System.EventHandler(btnEditRule_Click);
            this.btnRemoveGroup.Click += new System.EventHandler(btnRemoveGroup_Click);
            this.btnRemoveRule.Click += new System.EventHandler(btnRemoveRule_Click);
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
