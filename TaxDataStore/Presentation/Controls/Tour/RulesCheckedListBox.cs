using System.Windows.Forms;
using System;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class RulesCheckedListBox : CheckedListBox
    {

        public Entities.TourCostGroup Group { get; set; }
        protected bool checking;


        public RulesCheckedListBox()
        {
            this.checking = false;

            this.Dock = DockStyle.Fill;
            this.CheckOnClick = true;
            this.FormattingEnabled = true;
            this.Name = "chlbxRules";
            this.IntegralHeight = false;
            this.BorderStyle = BorderStyle.None;
            this.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Font = Presentation.View.Theme.FormLabelFont;

            BindData();

            this.ItemCheck += new ItemCheckEventHandler(OnItemCheck);
        }


        private void BindData()
        {
            this.DataSource = DomainModel.TourCostRules.GetAll();
            this.DisplayMember = "Name";
            this.ValueMember = "Id";
        }


        internal void UpdateBinding()
        {
            BindData();
            MarkSelectedItems();
        }


        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible)
            {
                MarkSelectedItems();
            }
        }


        private void MarkSelectedItems()
        {
            if (this.Group == null) return;

            this.ItemCheck -= new ItemCheckEventHandler(OnItemCheck);

            int index = 0;
            TourCostRuleCollection rules = DomainModel.TourCostRules.GetAll();
            foreach (TourCostRule rule in rules)
            {
                if (this.Group.Rules.Contains(rule))
                {
                    SetItemCheckState(index, CheckState.Checked);
                }
                else
                {
                    SetItemCheckState(index, CheckState.Unchecked);
                }

                index++;
            }

            this.ItemCheck += new ItemCheckEventHandler(OnItemCheck);
        }


        protected void OnItemCheck(object sender, ItemCheckEventArgs e)
        {
            TourCostRule item = (TourCostRule)this.Items[e.Index];

            if (item != null)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (DomainModel.TourCostGroups.AddRuleToGroup(this.Group, item))
                    {
                        this.Group.Rules.Add(item);
                    }
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    if (DomainModel.TourCostGroups.RemoveRuleFromGroup(this.Group, item))
                    {
                        this.Group.Rules.Remove(item);
                    }
                }
            }
        }
   }
}
