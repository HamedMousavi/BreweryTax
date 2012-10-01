using System;
using System.Transactions;
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
            bool res;

            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    // Insert mail
                    res = _mailsRepo.InsertMail(mail);

                    // Insert Send event
                    if (res)
                    {
                        var me = new MailEvent
                        {
                            EventTime = DateTime.Now,
                            EventUser = DomainModel.Application.User,
                            EventType = MailEventTypes.GetById(21) // Send
                        };

                        res = _mailsRepo.InsertEvent(mail, me);
                        if (res)
                        {
                            mail.EventLog.Add(me);
                        }
                    }

                    // Insert Receieve events
                    foreach (User user in recipients)
                    {
                        var me = new MailEvent
                        {
                            EventTime = DateTime.Now,
                            EventUser = user,
                            EventType = MailEventTypes.GetById(22) // Receive
                        };

                        if (!(res = _mailsRepo.InsertEvent(mail, me)))
                        {
                            break;
                        }

                        mail.EventLog.Add(me);
                    }

                    if (res)
                    {
                        ts.Complete();

                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                res = false;

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
    }
}
