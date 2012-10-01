using System;
using System.Data.SqlClient;
using Entities;


namespace DomainModel.Repository.Sql
{

    public class Mails
    {

        private readonly QueryHelper _query;


        public Mails(string sqlConnectionString)
        {
            _query = new QueryHelper(sqlConnectionString);
        }


        internal bool GetByDate(System.DateTime date, out MailCollection mails)
        {
            mails = null;
            bool res = false;

            try
            {
                mails = new MailCollection();
                _query.Parameters.Clear();
                _query.Parameters.Add(new SqlParameter("@SendTime", Utils.GetDbTime(date)));

                res = _query.ExecuteReader("MailsGetByDate", MapMailToObject, mails);
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
                catch (Exception)
                { }
            }

            return res;
        }


        private void MapMailToObject(SqlDataReader reader, object userData)
        {
            MailCollection mails = (MailCollection)userData;
            Mail mail = new Mail();

            mail.Id = Utils.GetSafeInt32(reader, "MailId");
            mail.Title = Utils.GetSafeString(reader, "MailTitle");
            mail.Text = Utils.GetSafeString(reader, "MailText");

            //mail.IsDirty = false;

            mails.Add(mail);
        }


        internal bool InsertMail(Mail mail)
        {
            bool res = false;

            try
            {
                _query.Parameters.Clear();

                _query.Parameters.Add(new SqlParameter("@MailTitle", mail.Title));
                _query.Parameters.Add(new SqlParameter("@MailText", mail.Text));

                int id;
                res = _query.ExecuteInsertProc("MailsAdd", out id);
                mail.Id = id;
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


        internal bool InsertEvent(Mail mail, MailEvent mailEvent)
        {
            bool res = false;

            try
            {
                _query.Parameters.Clear();

                _query.Parameters.Add(new SqlParameter("@MailId", mail.Id));
                _query.Parameters.Add(new SqlParameter("@UserId", mailEvent.EventUser.Id));
                _query.Parameters.Add(new SqlParameter("@EventTypeId", mailEvent.EventType.Id));
                _query.Parameters.Add(new SqlParameter("@EventTime",  Utils.GetDbTime(mailEvent.EventTime)));

                int id;
                res = _query.ExecuteInsertProc("MailEventsAdd", out id);
                mailEvent.Id = id;
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
