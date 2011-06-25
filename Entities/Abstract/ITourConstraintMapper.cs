

namespace Entities.Abstract
{

    public interface ITourConstraintMapper
    {
        bool GetProperties(
            object displayObject,
            Entities.TourCostRuleConstraint constraint);

        object GetDisplayObject(
            TourCostRuleConstraintPropertyCollection properties);
    }
}
