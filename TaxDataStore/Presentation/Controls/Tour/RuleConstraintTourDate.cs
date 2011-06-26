using DomainModel.Tour.Payment;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public partial class RuleConstraintTourDate : RuleConstraintBaseUserControl
    {
        private FormLabel lblAfter;
        private FormLabel lblBefore;

        protected Entities.ConstraintTourDate date;


        public RuleConstraintTourDate(Entities.TourCostRuleConstraint constraint)
            : base(constraint)
        {
            InitializeComponent();

            CreateControls();

            this.ConstraintMapper = new TourDateConstraintMapper();
            this.date = new ConstraintTourDate();
        }


        private void CreateControls()
        {
            this.lblAfter = new FormLabel(0, "lblAfter", false, "Any day after");
            this.lblBefore = new FormLabel(2, "lblBefore", false, "And before"); 
            
             this.tableLayoutPanel1.Controls.Add(this.lblAfter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBefore, 0, 2);
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
            Entities.ConstraintTourDate date = (Entities.ConstraintTourDate)
                this.ConstraintMapper.GetDisplayObject(this.constraint.Properties);

            if (date != null)
            {
                date.StartDate.CopyTo(this.fdsStartDate.Date);
                date.EndDate.CopyTo(this.fdsEndDate.Date);

                this.fdsStartDate.UpdateControlData();
                this.fdsEndDate.UpdateControlData();
            }
        }


        private void UpdateConstraintData()
        {
            this.fdsStartDate.Date.CopyTo(this.date.StartDate);
            this.fdsEndDate.Date.CopyTo(this.date.EndDate);

            this.ConstraintMapper.GetProperties(this.date, this.constraint);
        }
    }
}
