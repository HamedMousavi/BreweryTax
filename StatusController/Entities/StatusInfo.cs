using System;
using StatusController.Abstract;



namespace StatusController.Entities
{
    public class StatusInfo : IStatus
    {
        public Int16 AssemblyId { get; set; }
        public Int16 SectionId { get; set; }
        public Int32 Code { get; set; }
        public Int16 MessageId { get; set; }
        public StatusTypes Type { get; set; }
        public object UserData { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }


        public StatusInfo(Int16 assemblyId, Int16 sectionId, StatusTypes type, Int32 code, object userData, string message = "")
        {
            this.AssemblyId = assemblyId;
            this.SectionId = sectionId;
            this.Type = type;
            this.Code = code;
            this.UserData = userData;
            this.TimeStamp = DateTime.Now;
            this.Message = message;
        }
    }
}
