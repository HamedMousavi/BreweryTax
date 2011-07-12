using System;
using System.Transactions;



namespace DomainModel
{

    public class TourGroupServicePayments
    {

        private static Repository.Sql.TourGroupServicePayments repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourGroupServicePayments(sqlConnectionString);
        }


        internal static bool Save(Entities.TourServiceBase service)
        {
            bool res = true;

            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    foreach (Entities.TourPayment payment in service.Payments)
                    {
                        if (payment.IsDirty)
                        {
                            if (payment.Id < 0)
                            {
                                if (!(res = repo.Insert(service, payment))) break;
                            }
                            else
                            {
                                if (!(res = repo.Update(service, payment))) break;
                            }
                        }
                    }

                    foreach (Entities.TourPayment payment in service.DeletedPayments)
                    {
                        if (!(res = repo.Delete(payment))) break;
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
