using System;
using System.Transactions;
using Entities.Abstract;


namespace DomainModel
{

    public class TourGroupServices
    {

        private static Repository.Sql.TourGroupServices repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourGroupServices(sqlConnectionString);
        }


        public static bool Save(Entities.TourGroup group, Entities.TourServiceBase service)
        {
            bool res = false;
            try
            {
                if (service.IsDirty)
                {
                    if (service.Id < 0)
                    {
                        using (TransactionScope ts = new TransactionScope())
                        {
                            res = repo.Insert(group, service);
                            if (res) res = DomainModel.TourGroupServicePayments.Save(service);
                            if (res) res = DomainModel.TourGroupServiceCosts.Save(service);

                            if (res) ts.Complete();
                        }

                        if (!group.Services.Contains(service))
                        {
                            group.Services.Add(service);
                        }
                    }
                    else
                    {
                        res = repo.Update(group, service);
                    }

                    if (res)
                    {
                        service.IsDirty = false;
                    }
                }
                else
                {
                    res = true;
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


        internal static bool Load(Entities.TourGroup group)
        {
            bool res = false;
            try
            {
                res = repo.Load(group);

                foreach (ITourService service in group.Services)
                {
                    if (!(res = DomainModel.TourGroupServicePayments.Load(service))) break;
                    if (!(res = DomainModel.TourGroupServiceCosts.Load(service))) break;
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
    }
}
