﻿using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public partial class RuleConstraintTypeSelector : RuleConstraintBaseUserControl
    {

        public RuleConstraintTypeSelector(Entities.TourCostRuleConstraint constraint)
            : base(constraint)
        {
            this.label1 = new FormLabel("");

            InitializeComponent();

            this.Dock = DockStyle.Fill;

            this.cbxConstraintTypes.SelectedIndexChanged += new
                System.EventHandler(cbxConstraintTypes_SelectedIndexChanged);

            this.cbxConstraintTypes.DataSource = DomainModel.TourCostConstraintTypes.GetAll();
        }
        

        void cbxConstraintTypes_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = this.cbxConstraintTypes.SelectedIndex;
            if (index >= 0 && index < DomainModel.TourCostConstraintTypes.GetAll().Count)
            {
                this.constraint.ConstraintType = 
                    DomainModel.TourCostConstraintTypes.GetAll()[index];
            }
        }


        public override TourCostRuleConstraint Constraint
        {
            get
            {
                UpdateConstraintData();
                return this.constraint;
            }
            set
            {
                this.constraint = value;
                UpdateControlData();
            }
        }


        private void UpdateControlData()
        {
            this.cbxConstraintTypes.SelectedItem =
                this.constraint.ConstraintType;
        }


        private void UpdateConstraintData()
        {
            this.constraint.ConstraintType =
                (GeneralType)this.cbxConstraintTypes.SelectedItem;
        }
    }
}