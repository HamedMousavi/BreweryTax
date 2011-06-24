using Entities;
using DomainModel.Tour.Payment;


namespace TaxDataStore.Presentation.Controls
{

    public partial class RuleConstraintTourTime : RuleConstraintBaseUserControl
    {

        protected Entities.ConstraintTourTime time;


        public RuleConstraintTourTime(Entities.TourCostRuleConstraint constraint)
            : base(constraint)
        {
            InitializeComponent();

            this.ConstraintMapper = new TourTimeConstraintMapper();
            this.time = new ConstraintTourTime();
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
            Entities.ConstraintTourTime time = (Entities.ConstraintTourTime)
                this.ConstraintMapper.GetDisplayObject(this.constraint.Properties);

            time.StartTime.CopyTo(this.ftsStartTime.Time);
            time.EndTime.CopyTo(this.ftsEndTime.Time);

            this.ftsStartTime.UpdateControlData();
            this.ftsEndTime.UpdateControlData();
        }


        private void UpdateConstraintData()
        {
            this.ftsStartTime.Time.CopyTo(this.time.StartTime);
            this.ftsEndTime.Time.CopyTo(this.time.EndTime);

            TourCostRuleConstraintPropertyCollection properties;

            this.ConstraintMapper.GetProperties(this.time, out properties);

            this.constraint.Properties = properties;
        }
    }
}
