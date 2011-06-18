using System;
using System.Data.SqlClient;
using StatusController.Abstract;


namespace DomainModel.Repository.Sql
{

    class PersonContacts
    {

        protected QueryHelper query;


        public PersonContacts(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.Contact contact)
        {
            bool res = false;

            try
            {
                if (contact.Id >= 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_already_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@ContactMediaId", contact.Media.Id));
                this.query.Parameters.Add(new SqlParameter("@ContactValue", contact.Value));
                int id;
                res = this.query.ExecuteInsertProc("PersonContactAdd", out id);
                contact.Id = id;
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


        internal bool Update(Entities.Contact contact)
        {
            bool res = false;

            try
            {
                if (contact.Id < 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_not_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@ContactMediaId", contact.Media.Id));
                this.query.Parameters.Add(new SqlParameter("@ContactValue", contact.Value));
                this.query.Parameters.Add(new SqlParameter("@ContactId", contact.Id));

                res = this.query.ExecuteUpdateProc("PersonContactUpdateById");
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


        internal bool GetByMember(Entities.TourMember member)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@MemberId", member.Id));

                res = this.query.ExecuteReader("ContactsGetByMemberId", MapContactToObject, member);
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


        protected void MapContactToObject(SqlDataReader reader, object userData)
        {
            Entities.Contact contact = new Entities.Contact();

            contact.Id = Utils.GetSafeInt32(reader, "ContactId");
            contact.Media = DomainModel.ContactMediaTypes.GetById(
                Utils.GetSafeInt32(reader, "ContactMediaId"));
            contact.Value = Utils.GetSafeString(reader, "ContactValue");

            Entities.TourMember member = (Entities.TourMember)userData;
            member.Contacts.Add(contact);
        }
    }
}
