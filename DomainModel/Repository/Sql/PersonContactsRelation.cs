using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    class PersonContactsRelation
    {

        protected QueryHelper query;


        public PersonContactsRelation(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.TourMember member, Entities.Contact contact)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@PersonId", member.Id));
                this.query.Parameters.Add(new SqlParameter("@ContactId", contact.Id));

                int id;
                res = this.query.ExecuteInsertProc("PersonContactsAdd", out id);
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
