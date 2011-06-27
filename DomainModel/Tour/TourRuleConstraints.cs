using System;
using System.Transactions;
using Entities;


namespace DomainModel
{

    public class TourRuleConstraints
    {
        private static Repository.Sql.TourCostRuleConstraints constraints;
        private static Repository.Sql.TourCostRuleConstraintProperties properties;


        public static void Init(string sqlConnectionString)
        {
            constraints = new Repository.Sql.TourCostRuleConstraints(sqlConnectionString);
            properties = new Repository.Sql.TourCostRuleConstraintProperties(sqlConnectionString);
        }


        internal static bool Save(Entities.TourCostRule rule)
        {
            bool res = true;
            try
            {
                // Note: Only is called from inside a transaction
                //using (TransactionScope ts = new TransactionScope())
                //{
                    foreach (TourCostRuleConstraint constraint in rule.Constraints)
                    {
                        if (constraint.IsDirty)
                        {
                            if (constraint.Id < 0)
                            {
                                if(!(res = constraints.Insert(rule, constraint))) break;
                            }
                            else
                            {
                                if(!(res = constraints.Update(rule, constraint))) break;
                            }
                        }

                        foreach (TourCostRuleConstraintProperty property in constraint.Properties)
                        {
                            if (property.IsDirty)
                            {
                                if (property.Id < 0)
                                {
                                    if(!(res = properties.Insert( constraint, property))) break;
                                }
                                else
                                {
                                    if(!(res = properties.Update( constraint, property))) break;
                                }
                            }
                        }

                        if (!res) break;
                    }

                    foreach (TourCostRuleConstraint constraint in rule.DeletedConstraints)
                    {
                        if (!(res = constraints.Delete(constraint))) break;
                    }

                /*
                    if (res)
                    {
                        ts.Complete();
                    }*/
                //}
            }
            catch (Exception ex)
            {
                res = false;
            }

            return res;
        }


        internal static void Load(Entities.TourCostRule rule)
        {
            // Load rule constraint properties
            constraints.LoadByRule(rule);
            foreach (TourCostRuleConstraint constraint in rule.Constraints)
            {
                properties.LoadByConstraint(constraint);
            }
        }
    }
}
