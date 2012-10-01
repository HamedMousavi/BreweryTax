using System;


namespace Entities
{

    public class MailEvent
    {
        public Int32 Id { get; set; }
        public GeneralType EventType { get; set; }
        public DateTime EventTime { get; set; }
        public User EventUser { get; set; }
    }
}
