

namespace Entities.Abstract
{

    public interface ITourConstraintMapper
    {
        bool GetProperties(object displayObject, out TourCostRuleConstraintPropertyCollection properties);
        object GetDisplayObject(TourCostRuleConstraintPropertyCollection properties);
    }
}
