

namespace Entities.Abstract
{

    public interface ITourRuleConstraintValidator
    {
        bool Matches(Entities.Tour tour, ITourService service, TourCostDetail detail, TourCostRuleConstraint constraint);
    }
}
