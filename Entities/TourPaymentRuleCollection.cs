using System.ComponentModel;

namespace Entities
{
    public class TourPaymentRuleCollection : BindingList<TourPaymentRule>
    {
        public TourPaymentRule FindById(int id)
        {
            foreach (TourPaymentRule rule in this)
            {
                if (rule.Id == id) return rule;
            }

            return null;
        }
    }
}
