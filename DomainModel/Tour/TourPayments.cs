using System;


namespace DomainModel
{

    public class TourPayments
    {

        private static Repository.Sql.TourPayments repo;
        private static Repository.Sql.TourPaymentsRelation repoRelate;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourPayments(sqlConnectionString);
            repoRelate = new Repository.Sql.TourPaymentsRelation(sqlConnectionString);
        }
        
        
        internal static bool Save(Entities.Tour tour)
        {
            bool res = true;

            foreach (Entities.TourPayment pay in tour.Payments)
            {
                if (pay.IsDirty)
                {
                    if (pay.Id < 0)
                    {
                        if (!(res = repo.Insert(pay))) break;
                        if (!(res = repoRelate.Insert(tour, pay))) break;
                    }
                    else
                    {
                        if (!(res = repo.Update(pay))) break;
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
