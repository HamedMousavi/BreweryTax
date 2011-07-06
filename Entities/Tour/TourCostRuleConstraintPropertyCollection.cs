using System.ComponentModel;


namespace Entities
{

    public class TourCostRuleConstraintPropertyCollection : BindingList<TourCostRuleConstraintProperty>
    {
        internal void CopyTo(TourCostRuleConstraintPropertyCollection properties)
        {
            properties.Clear();

            foreach (TourCostRuleConstraintProperty property in this)
            {
                TourCostRuleConstraintProperty newprop =
                    new TourCostRuleConstraintProperty();

                property.CopyTo(newprop);

                properties.Add(property);
            }
        }
    }
}
