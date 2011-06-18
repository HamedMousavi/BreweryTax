using System;
using System.Data.SqlClient;
using StatusController.Abstract;


namespace DomainModel.Repository.Sql
{

    public class TourCostsRelation
    {

        protected QueryHelper query;


        public TourCostsRelation(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.Tour tour, Entities.TourCostDetail cost)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));
                this.query.Parameters.Add(new SqlParameter("@TourCostId", cost.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourCostsAdd", out id);
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
