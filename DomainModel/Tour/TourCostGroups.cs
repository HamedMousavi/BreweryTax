using System;
using Entities;


namespace DomainModel
{

    public class TourCostGroups
    {

        private static TourCostGroupCollection groups;
        private static Repository.Sql.TourCostGroups repo;


        public static Int32 Count
        {
            get
            {
                return groups.Count;
            }
        }


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourCostGroups(sqlConnectionString);

            LoadAll();
        }


        private static void LoadAll()
        {
            groups = new TourCostGroupCollection();
            repo.LoadAll(groups);
            LoadGroupsRules(groups);
        }


        private static void LoadGroupsRules(TourCostGroupCollection groups)
        {
            foreach (TourCostGroup group in groups)
            {
                DomainModel.TourCostRules.LoadGroupRules(group);
            }
        }


        public static TourCostGroupCollection GetAll()
        {
            return groups;
        }


        public static bool Save(Entities.TourCostGroup group)
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


        public static bool Delete(Entities.TourCostGroup group)
        {

            if (repo.Delete(group))
            {
                groups.Remove(group);

                return true;
            }

            return false;
        }


        public static bool AddRuleToGroup(TourCostGroup group, TourCostRule rule)
        {
            return repo.AddRuleToGroup(group.Id, rule.Id);
        }


        public static bool RemoveRuleFromGroup(TourCostGroup group, TourCostRule rule)
        {
            return repo.RemoveRuleFromGroup(group.Id, rule.Id);
        }


        internal static TourCostGroup GetById(int id)
        {
            return groups.GetById(id);
        }
    }
}
