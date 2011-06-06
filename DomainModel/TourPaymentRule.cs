using Entities;
using System;
using System.Collections.Generic;


namespace DomainModel
{

    public class TourPaymentRules
    {

        private static TourPaymentRuleCollection rules;
        private static Repository.Sql.TourPaymentRules repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourPaymentRules(sqlConnectionString);
            LoadRules();
        }


        private static void LoadRules()
        {
            rules = new TourPaymentRuleCollection();
            repo.LoadAll(rules);
        }


        public static TourPaymentRuleCollection GetAll()
        {
            return rules;
        }

        public static bool Save(Entities.TourPaymentRule rule)
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

        public static bool Delete(Entities.TourPaymentRule rule)
        {

            if (repo.Delete(rule))
            {
                rules.Remove(rule);

                return true;
            }

            return false;
        }

        internal static void LoadGroupRules(TourPaymentGroup group)
        {
            List<Int32> grpRules = new List<int>();

            repo.LoadByGroupId(group.Id, grpRules);

            foreach (Int32 id in grpRules)
            {
                TourPaymentRule rule = rules.FindById(id);
                if (rule != null)
                {
                    group.Rules.Add(rule);
                }
            }
        }
    }
}
