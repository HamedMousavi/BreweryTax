using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    class TourMembersRelation
    {

        protected QueryHelper query;


        public TourMembersRelation(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.Tour tour, Entities.TourMember member)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@PersonId", member.Id));
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourMembersAdd", out id);
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


        internal bool Delete(Entities.Tour tour, Entities.TourMember member)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@PersonId", member.Id));
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("TourMembersDeleteById", out affected);
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
