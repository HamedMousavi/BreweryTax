using Entities;
using System;
using System.Collections.Generic;


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
            repo.LoadAll(rules);
        }


        public static TourCostRuleCollection GetAll()
        {
            return rules;
        }

        public static bool Save(Entities.TourCostRule rule)
        {
            bool res;

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

            return res;
        }

        public static bool Delete(Entities.TourCostRule rule)
        {

            if (repo.Delete(rule))
            {
                rules.Remove(rule);

                return true;
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
