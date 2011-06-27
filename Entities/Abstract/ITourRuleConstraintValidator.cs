

namespace Entities.Abstract
{

    public interface ITourRuleConstraintValidator
    {
        bool Matches(Tour tour, TourCostDetail detail, TourCostRuleConstraint constraint);
    }
}
