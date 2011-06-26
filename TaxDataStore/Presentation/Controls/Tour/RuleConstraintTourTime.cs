using Entities;
using DomainModel.Tour.Payment;
using System.ComponentModel;


namespace TaxDataStore.Presentation.Controls
{

    public partial class RuleConstraintTourTime : RuleConstraintBaseUserControl
    {

        private FormLabel lblAfter;
        private FormLabel lblBefore;


        protected Entities.ConstraintTourTime time;


        public RuleConstraintTourTime(Entities.TourCostRuleConstraint constraint)
            : base(constraint)
        {
            InitializeComponent();

            CreateControls();

            this.ConstraintMapper = new TourTimeConstraintMapper();
            this.time = new ConstraintTourTime();
        }


        private void CreateControls()
        {
            this.lblAfter = new FormLabel(0, "lblAfter", false, "Any time after");
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
