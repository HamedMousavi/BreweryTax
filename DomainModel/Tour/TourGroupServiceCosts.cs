using System;
using System.Transactions;


namespace DomainModel
{

    public class TourGroupServiceCosts
    {

        private static Repository.Sql.TourGroupServiceCosts repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourGroupServiceCosts(sqlConnectionString);
        }


        internal static bool Save(Entities.TourServiceBase service)
        {
            bool res = true;

            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    foreach (Entities.TourCostDetail cost in service.CostDetails)
                    {
                        if (cost.IsDirty)
                        {
                            if (cost.Id < 0)
                            {
                                if (!(res = repo.Insert(service, cost))) break;
                            }
                            else
                            {
                                if (!(res = repo.Update(service, cost))) break;
                            }
                        }
                    }

                    if (res) ts.Complete();
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

            return res;
        }


        internal static bool Load(Entities.Abstract.ITourService service)
        {
            return repo.Load(service);
        }
    }
}
