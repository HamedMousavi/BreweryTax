using System;
using Entities;


namespace DomainModel
{

    public static class Mails
    {

        private static Repository.Sql.Mails _mailsRepo;


        public static void Init(string sqlConnectionString)
        {
            _mailsRepo = new Repository.Sql.Mails(sqlConnectionString);
        }


        public static void LoadByDate(DateTime date, MailCollection mails)
        {
            try
            {
                MailCollection newMails;
                _mailsRepo.GetByDate(date, out newMails);

                Sync(mails, newMails);
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
        }


        private static void Sync(MailCollection mails, MailCollection newMails)
        {
            MailCollection remove = new MailCollection();

            foreach (Mail mail in mails)
            {
                if (!newMails.Contains(mail))
                {
                    remove.Add(mail);
                }
            }

            foreach (Mail mail in remove)
            {
                mails.Remove(mail);
            }

            foreach(Mail mail in newMails)
            {
                if (!mails.Contains(mail))
                {
                    mails.Add(mail);
                }
            }
        }


        public static bool Send(Mail mail, UserCollection recipients)
        {
            throw new NotImplementedException();
        }
    }
}
