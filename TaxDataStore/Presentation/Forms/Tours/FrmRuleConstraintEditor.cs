using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmRuleConstraintEditor : BaseForm
    {

        protected List<UserControl> clients;
        protected RuleConstraintBaseUserControl currentClient;
        protected RuleConstraintBaseUserControl ctrlTourDate;
        protected RuleConstraintBaseUserControl ctrlTourTime;
        private Entities.TourCostRule rule;
        private Entities.TourCostRuleConstraint editConstraint;
        private Entities.TourCostRuleConstraint constraint;


        public FrmRuleConstraintEditor()
        {

            this.clients = new List<UserControl>();
            this.constraint = new Entities.TourCostRuleConstraint();

            this.clients.Add(new RuleConstraintTypeSelector(this.constraint));

            this.ctrlTourTime = new RuleConstraintTourTime(this.constraint);
            this.ctrlTourDate = new RuleConstraintTourDate(this.constraint);

            InitializeComponent();

            MoveClientForm(0);
        }


        public FrmRuleConstraintEditor(Entities.TourCostRule rule)
            : this()
        {
            this.rule = rule;
        }

        
        public FrmRuleConstraintEditor(Entities.TourCostRule rule, Entities.TourCostRuleConstraint constraintToEdit)
            : this(rule)
        {
            this.editConstraint = constraintToEdit;
            this.editConstraint.CopyTo(this.constraint);
            PrepareForEdit();
        }


        private void PrepareForEdit()
        {
            RuleConstraintBaseUserControl control = 
                GetSelectedUserControl(this.constraint.ConstraintType.Id);

            if (control != null)
            {
                if (this.clients.Count > 1) this.clients.RemoveAt(1);
                this.clients.Insert(1, control);
                this.tlpMain.Controls.Remove(this.currentClient);
                this.currentClient = control;
                this.tlpMain.Controls.Add(this.currentClient, 0, 0);
                AdjustButtons(1);

                control.Constraint = this.constraint;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            MoveClientForm(1);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            MoveClientForm(-1);
        }


        private void MoveClientForm(int pageCount)
        {
            if (this.currentClient == null)
            {
                AdjustPage(0, 0);
                ShowClient(0);
                AdjustButtons(0);
            }
            else
            {
                int index = this.clients.IndexOf(this.currentClient);
                AdjustPage(index, index + pageCount);
                ShowClient(index + pageCount);
                AdjustButtons(index + pageCount);
            }
        }


        private void AdjustButtons(int pageIndex)
        {
            if (pageIndex <= 0)
            {
                this.btnNext.Enabled = true;
                this.btnSave.Enabled = false;
                this.btnBack.Enabled = false;
            }
            else if (pageIndex == this.clients.Count - 1)
            {
                this.btnNext.Enabled = false;
                this.btnSave.Enabled = true;
                this.btnBack.Enabled = true;
            }
            else
            {
                this.btnNext.Enabled = false;
                this.btnSave.Enabled = false;
                this.btnBack.Enabled = true;
            }
        }


        private void ShowClient(int index)
        {
            if (index < this.clients.Count && index >= 0)
            {
                this.tlpMain.Controls.Remove(this.currentClient);
                this.currentClient = (RuleConstraintBaseUserControl)this.clients[index];
                this.tlpMain.Controls.Add(this.currentClient, 0, 0);
            }
        }


        private void AdjustPage(int oldIndex, int newIndex)
        {
            // First page decides which control to have
            // on next page
            if (newIndex > 0 && oldIndex == 0)
            {
                UserControl control = GetSelectedUserControl();
                if (control != null)
                {
                    if (this.clients.Count > 1) this.clients.RemoveAt(1);
                    this.clients.Insert(1, control);
                }
            }
        }


        private RuleConstraintBaseUserControl GetSelectedUserControl(int typeId = -1)
        {
            if (typeId < 0)
            {
                if (this.constraint.ConstraintType != null)
                {
                    typeId = this.constraint.ConstraintType.Id;
                }
            }

            switch (typeId)
            {
                case 17: // TourDate
                    return this.ctrlTourDate;

                case 18: // TourTime
                    return this.ctrlTourTime;
            }


            return null;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.constraint != null)
            {
                this.constraint = this.currentClient.Constraint;

                if (this.editConstraint == null)
                {
                    this.rule.Constraints.Add(this.constraint);
                }
                else
                {
                    this.constraint.CopyTo(this.editConstraint);
                }
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
