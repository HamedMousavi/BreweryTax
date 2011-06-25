

namespace Entities.Abstract
{

    public interface ITourRuleConstraintValidator
    {
        bool Matches(Tour tour, TourCostRuleConstraint constraint);
    }
}
