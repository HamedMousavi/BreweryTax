using System;
using System.Collections.Generic;
using System.Transactions;
using Entities;


namespace DomainModel
{

    public class TourCostRules
    {

        private static TourCostRuleCollection rules;
        private static Repository.Sql.TourCostRules repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourCostRules(sqlConnectionString);

            LoadRules();
        }


        private static void LoadRules()
        {
            rules = new TourCostRuleCollection();

            // Load rules
            repo.LoadAll(rules);

            // Load rule constraints
            foreach(TourCostRule rule in rules)
            {
                DomainModel.TourRuleConstraints.Load(rule);
            }
        }


        public static TourCostRuleCollection GetAll()
        {
            return rules;
        }


        public static bool Save(Entities.TourCostRule rule)
        {
            bool res;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (rule.Id >= 0)
                    {
                        res = repo.Update(rule);
                    }
                    else
                    {
                        res = repo.Insert(rule);
                        if (res)
                        {
                            rules.Add(rule);
                        }
                    }

                    // Load rule constraint properties
                    res = DomainModel.TourRuleConstraints.Save(rule);

                    if (res)
                    {
                        ts.Complete();
                        rule.DeletedConstraints.Clear();
                    }
                    else
                    {
                        rule.DeletedConstraints.UndoDelet(rule.Constraints);
                    }

                }
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }

                res = false;
            }

            return res;
        }


        public static bool Delete(Entities.TourCostRule rule)
        {
            try
            {

                using (TransactionScope ts = new TransactionScope())
                {
                    if (repo.Delete(rule))
                    {
                        ts.Complete();
                        rules.Remove(rule);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return false;
        }


        internal static void LoadGroupRules(TourCostGroup group)
        {
            List<Int32> grpRules = new List<int>();

            repo.LoadByGroupId(group.Id, grpRules);

            foreach (Int32 id in grpRules)
            {
                TourCostRule rule = rules.FindById(id);
                if (rule != null)
                {
                    group.Rules.Add(rule);
                }
            }
        }
    }
}
