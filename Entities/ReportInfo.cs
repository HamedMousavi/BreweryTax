using System;


namespace Entities
{

    public class ReportInfo
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Path { get; set; }


        public ReportInfo()
        {
            this.StartTime = DateTime.Now;
            this.EndTime = DateTime.Now;
        }
    }
}
