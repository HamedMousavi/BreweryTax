using Entities;
using DomainModel.Tour.Payment;
using System.ComponentModel;


namespace TaxDataStore.Presentation.Controls
{

    public partial class RuleConstraintTourTime : RuleConstraintBaseUserControl
    {

        protected Entities.ConstraintTourTime time;


        public RuleConstraintTourTime(Entities.TourCostRuleConstraint constraint)
            : base(constraint)
        {
            this.label1 = new FormLabel("");
            this.label5 = new FormLabel("");

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

            if (time != null)
            {
                time.StartTime.CopyTo(this.ftsStartTime.Time);
                time.EndTime.CopyTo(this.ftsEndTime.Time);

                this.ftsStartTime.UpdateControlData();
                this.ftsEndTime.UpdateControlData();
            }
        }


        private void UpdateConstraintData()
        {
            this.ftsStartTime.Time.CopyTo(this.time.StartTime);
            this.ftsEndTime.Time.CopyTo(this.time.EndTime);

            this.ConstraintMapper.GetProperties(this.time, this.constraint);
        }
    }
}
