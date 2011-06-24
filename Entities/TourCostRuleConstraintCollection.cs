using System.ComponentModel;


namespace Entities
{

    public class TourCostRuleConstraintCollection : BindingList<TourCostRuleConstraint>
    {
        internal void CopyTo(TourCostRuleConstraintCollection constraints)
        {
            constraints.Clear();

            foreach(TourCostRuleConstraint constraint in this)
            {
                constraints.Add(constraint);
            }
        }
    }
}
