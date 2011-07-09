using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    class TourGroupMembersRelation
    {

        protected QueryHelper query;


        public TourGroupMembersRelation(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.TourGroup group, Entities.TourMember member)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@PersonId", member.Id));
                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourGroupMemberAdd", out id);
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


        internal bool Delete(Entities.TourGroup group, Entities.TourMember member)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@PersonId", member.Id));
                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupMemberDeleteById", out affected);
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
