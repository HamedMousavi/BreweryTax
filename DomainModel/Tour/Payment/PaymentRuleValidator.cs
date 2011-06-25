using System.Collections.Generic;
using Entities;
using Entities.Abstract;


namespace DomainModel
{

    public class PaymentRuleValidator
    {

        protected Dictionary<int, ITourRuleConstraintValidator> validators;


        public PaymentRuleValidator()
        {
            this.validators = new Dictionary<int, ITourRuleConstraintValidator>();

            GeneralTypeCollection types = DomainModel.TourCostConstraintTypes.GetAll();
            foreach (GeneralType type in types)
            {
                this.validators.Add(type.Id, GetValidator(type.Id));
            }
        }


        private ITourRuleConstraintValidator GetValidator(int typeid)
        {
            switch (typeid)
            {
                case 17: // TourDate
                    return new TourDateValidator();

                case 18: // TourTime
                    return new TourTimeValidator();
            }

            return null;
        }


        internal bool Matches(Entities.TourCostRule rule, Entities.Tour tour)
        {
            bool res = true;

            foreach (Entities.TourCostRuleConstraint con in rule.Constraints)
            {
                if (validators.ContainsKey(con.ConstraintType.Id))
                {
                    ITourRuleConstraintValidator validator =
                        validators[con.ConstraintType.Id];
                    if (!validator.Matches(tour, con))
                    {
                        res = false;
                        break;
                    }

                    res = true;
                }
                else
                {
                    res = false;
                    break;
                }
            }
            
            return res;
        }
    }
}
