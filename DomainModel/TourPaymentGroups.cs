using System;
using Entities;


namespace DomainModel
{

    public class TourPaymentGroups
    {

        private static TourPaymentGroupCollection groups;
        private static Repository.Sql.TourPaymentGroups repo;


        public static Int32 Count
        {
            get
            {
                return groups.Count;
            }
        }


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourPaymentGroups(sqlConnectionString);

            LoadAll();
        }


        private static void LoadAll()
        {
            groups = new TourPaymentGroupCollection();
            repo.LoadAll(groups);
            LoadGroupsRules(groups);
        }


        private static void LoadGroupsRules(TourPaymentGroupCollection groups)
        {
            foreach (TourPaymentGroup group in groups)
            {
                DomainModel.TourPaymentRules.LoadGroupRules(group);
            }
        }


        public static TourPaymentGroupCollection GetAll()
        {
            return groups;
        }


        public static bool Save(Entities.TourPaymentGroup group)
        {
            bool res;

            if (group.Id >= 0)
            {
                res = repo.Update(group);
            }
            else
            {
                res = repo.Insert(group);
                if (res)
                {
                    groups.Add(group);
                }
            }

            return res;
        }


        public static bool Delete(Entities.TourPaymentGroup group)
        {

            if (repo.Delete(group))
            {
                groups.Remove(group);

                return true;
            }

            return false;
        }


        public static bool AddRuleToGroup(TourPaymentGroup group, TourPaymentRule rule)
        {
            return repo.AddRuleToGroup(group.Id, rule.Id);
        }


        public static bool RemoveRuleFromGroup(TourPaymentGroup group, TourPaymentRule rule)
        {
            return repo.RemoveRuleFromGroup(group.Id, rule.Id);
        }
    }
}
