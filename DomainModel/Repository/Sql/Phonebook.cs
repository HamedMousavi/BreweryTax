using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class Phonebook
    {

        protected QueryHelper query;


        public Phonebook(string sqlConnectionString)
        {
            this.query = new QueryHelper(sqlConnectionString);
        }


        internal bool LoadAll(Entities.TourMemberCollection persons)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                res = this.query.ExecuteReader("PhonebookGetAll", MapMemberToObject, persons);
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


        protected void MapMemberToObject(SqlDataReader reader, object userData)
        {
            Entities.TourMember member = new Entities.TourMember();

            member.Id = Utils.GetSafeInt32(reader, "MemberId");
            member.Title = DomainModel.PersonTitleTypes.GetById(
                Utils.GetSafeInt32(reader, "TitleId"));
            member.FirstName = Utils.GetSafeString(reader, "FirstName");
            member.LastName = Utils.GetSafeString(reader, "LastName");
            member.MemberShip = DomainModel.TourMembershipTypes.GetById(
                Utils.GetSafeInt32(reader, "MembershipType"));
            member.IsDirty = false;
            member.IsInPhonebook = true;
            Entities.TourMemberCollection persons = (Entities.TourMemberCollection)userData;
            persons.Add(member);
        }


        internal bool Insert(Entities.TourMember person)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@PersonId", person.Id));

                int id;
                res = this.query.ExecuteInsertProc("PhonebookAdd", out id);
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


        internal bool Delete(Entities.TourMember person)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@PersonId", person.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("PhonebookDeleteByPersonId", out affected);
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
