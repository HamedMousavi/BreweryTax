using Entities;
using DomainModel.Tour.Payment;
using System.ComponentModel;


namespace TaxDataStore.Presentation.Controls
{

    public partial class RuleConstraintTourDate : RuleConstraintBaseUserControl
    {

        protected Entities.ConstraintTourDate date;


        public RuleConstraintTourDate(Entities.TourCostRuleConstraint constraint)
            : base(constraint)
        {
            this.label1 = new FormLabel("");
            this.label5 = new FormLabel(""); 
            
            InitializeComponent();

            this.ConstraintMapper = new TourDateConstraintMapper();
            this.date = new ConstraintTourDate();
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
