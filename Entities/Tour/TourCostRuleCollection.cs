using System.ComponentModel;

namespace Entities
{
    public class TourCostRuleCollection : BindingList<TourCostRule>
    {
        public TourCostRule FindById(int id)
        {
            foreach (TourCostRule rule in this)
            {
                if (rule.Id == id) return rule;
            }

            return null;
        }
    }
}
