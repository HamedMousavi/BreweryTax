using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class TourPaymentsRelation
    {

        protected QueryHelper query;


        public TourPaymentsRelation(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.Tour tour, Entities.TourPayment pay)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));
                this.query.Parameters.Add(new SqlParameter("@PaymentId", pay.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourPaymentsAdd", out id);
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
