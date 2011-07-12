using System;


namespace DomainModel
{

    public class TourGroups
    {

        private static Repository.Sql.TourGroups groups;


        public static void Init(string sqlConnectionString)
        {
            groups = new Repository.Sql.TourGroups(sqlConnectionString);
        }


        public static void Load(Entities.Tour tour)
        {
            try
            {
                // Load group info
                groups.GetByTour(tour);

                // load group members
                foreach (Entities.TourGroup group in tour.Groups)
                {
                    DomainModel.TourGroupMembers.Load(group);

                    DomainModel.TourGroupEmployees.Load(group);

                    DomainModel.TourGroupServices.Load(group);
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
        }


        public static bool Save(Entities.Tour tour)
        {
            bool res = true;

            foreach (Entities.TourGroup group in tour.Groups)
            {
                if (group.IsDirty)
                {
                    if (group.Id < 0)
                    {
                        if (!(res = groups.Insert(tour, group))) break;
                    }
                    else
                    {
                        if (!(res = groups.Update(tour, group))) break;
                    }
                }
            }

            return res;
        }


        public static bool Delete(Entities.TourGroup group)
        {
            bool res = true;

            try
            {
                groups.Delete(group);
            }
            catch (Exception)
            {
            }

            return res;

        }


        public static bool Save(Entities.TourGroup group)
        {
            bool res = true;

            try
            {
                if (group.IsDirty)
                {
                    res = groups.Update(group);
                }
            }
            catch (Exception)
            {
                res = false;
            }

            return res;
        }
    }
}
