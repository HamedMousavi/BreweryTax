using System;


namespace Entities
{

    public class Mail
    {
        public Int32 Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public MailEventCollection EventLog  { get; set; }

        public bool IsSent
        {
            get
            {
                return true;
            }
        }

        public Mail()
        {
            this.Id = -1;
            this.EventLog = new MailEventCollection();
        }
    }
}
