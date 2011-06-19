using System;

namespace DomainModel
{
    public class TourCosts
    {
        private static Repository.Sql.TourCosts repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourCosts(sqlConnectionString);
        }


        public static bool Save(Entities.Tour tour)
        {
            bool res = true;

            foreach (Entities.TourCostDetail cost in tour.CostDetails)
            {
                if (cost.IsDirty)
                {
                    if (cost.Id < 0)
                    {
                        if (!(res = repo.Insert(tour, cost))) break;
                    }
                    else
                    {
                        if (!(res = repo.Update(tour, cost))) break;
                    }
                }
            }

            return res;
        }


        internal static void Load(Entities.Tour tour)
        {
            try
            {
                repo.GetByTour(tour);
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
    }
}
