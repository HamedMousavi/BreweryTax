

using System;
namespace DomainModel
{

    public class TourEmployees
    {
        private static Repository.Sql.TourEmployees empRepo;


        public static void Init(string sqlConnectionString)
        {
            empRepo = new Repository.Sql.TourEmployees(sqlConnectionString);
        }


        internal static bool Save(Entities.Tour tour)
        {
            bool res = true;
            /*
            foreach(Entities.Employee emp in tour.Employees)
            {
                if (!empRepo.Insert(tour, emp))
                {
                    res = false;
                    break;
                }
            }*/
            /*
            foreach(Entities.Employee emp in tour.DeletedEmployees)
            {
                if (!empRepo.Delete(tour, emp))
                {
                    res = false;
                    break;
                }
            }
            */
            return res;
        }


        internal static void Load(Entities.Tour tour)
        {
            try
            {
                empRepo.GetByTour(tour);
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
