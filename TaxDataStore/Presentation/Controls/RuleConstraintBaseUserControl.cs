using System.Windows.Forms;
using Entities.Abstract;


namespace TaxDataStore.Presentation.Controls
{

    public abstract class RuleConstraintBaseUserControl : UserControl
    {

        protected Entities.TourCostRuleConstraint constraint;

        public RuleConstraintBaseUserControl(Entities.TourCostRuleConstraint constraint)
            : base()
        {
            this.constraint = constraint;
        }


        public ITourConstraintMapper ConstraintMapper{ get; set; }

        public abstract Entities.TourCostRuleConstraint Constraint { get; set; }
    }
}
