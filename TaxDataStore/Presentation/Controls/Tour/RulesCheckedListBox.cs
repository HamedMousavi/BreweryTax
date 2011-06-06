using System.Windows.Forms;
using System;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class RulesCheckedListBox : CheckedListBox
    {

        public Entities.TourPaymentGroup Group { get; set; }
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

            BindData();

            this.ItemCheck += new ItemCheckEventHandler(OnItemCheck);
        }


        private void BindData()
        {
            this.DataSource = DomainModel.TourPaymentRules.GetAll();
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
            TourPaymentRuleCollection rules = DomainModel.TourPaymentRules.GetAll();
            foreach (TourPaymentRule rule in rules)
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
            TourPaymentRule item = (TourPaymentRule)this.Items[e.Index];

            if (item != null)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (DomainModel.TourPaymentGroups.AddRuleToGroup(this.Group, item))
                    {
                        this.Group.Rules.Add(item);
                    }
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    if (DomainModel.TourPaymentGroups.RemoveRuleFromGroup(this.Group, item))
                    {
                        this.Group.Rules.Remove(item);
                    }
                }
            }
        }
   }
}
