using Entities;
using System;
using System.Transactions;


namespace DomainModel
{

    public class Tours
    {

        private static string cnnString;
        private static TourCollection cache;
        private static Repository.Sql.Tours toursRepo;


        public static void Init(string sqlConnectionString)
        {
            cnnString = sqlConnectionString;
            cache = new TourCollection();

            toursRepo = new Repository.Sql.Tours(sqlConnectionString);
        }


        public static bool Save(Entities.Tour tour)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (!SaveTour(tour)) return false;
                    if (!DomainModel.TourMembers.Save(tour)) return false;
                    if (!DomainModel.TourPayments.Save(tour)) return false;
                    if (!DomainModel.TourCosts.Save(tour)) return false;
                    if (!DomainModel.TourEmployees.Save(tour)) return false;

                    ts.Complete();

                    if (!cache.Contains(tour))
                    {
                        cache.Add(tour);
                    }
                }


                return true;
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


        private static bool SaveTour(Tour tour)
        {
            bool res = false;

            if (tour.IsDirty)
            {
                if (tour.Id < 0)
                {
                    res = toursRepo.Insert(tour);
                }
                else
                {
                    res = toursRepo.Update(tour);
                }

                if (res)
                {
                    tour.IsDirty = false;
                }
            }
            else
            {
                res = true;
            }

            return res;
        }


        public static void Delete(Tour tour)
        {
            cache.Remove(tour);
        }


        public static void LoadByDate(DateTime date, TourCollection tours)
        {
            try
            {
                tours.Clear();
                toursRepo.GetByDate(tours, date);

                foreach (Entities.Tour tour in tours)
                {
                    DomainModel.TourMembers.Load(tour);
                    DomainModel.TourPayments.Load(tour);
                    DomainModel.TourCosts.Load(tour);
                    DomainModel.TourEmployees.Load(tour);
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
    }
}
