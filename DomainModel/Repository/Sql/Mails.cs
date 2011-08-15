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


        protected void MapMailToObject(SqlDataReader reader, object userData)
        {
            MailCollection mails = (MailCollection)userData;
            Mail mail = new Mail();

            mail.Id = Utils.GetSafeInt32(reader, "MailId");
            mail.Title = Utils.GetSafeString(reader, "MailTitle");
            mail.Text = Utils.GetSafeString(reader, "MailText");

            //mail.IsDirty = false;

            mails.Add(mail);
        }
    }
}
