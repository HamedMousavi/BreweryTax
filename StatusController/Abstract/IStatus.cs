using System;



namespace StatusController.Abstract
{


    // WARNING: THESE TYPES ARE USED AS INDEXES
    //          REMAIN INDEXES AS IS
    public enum StatusTypes
    {
        Error = 0,
        Success = 1,
        Warning,
        Info,
        None
    }

    public interface IStatus
    {
        Int16 AssemblyId { get; set; }
        Int16 SectionId { get; set; }
        Int32 Code { get; set; }
        StatusTypes Type { get; set; }
        DateTime TimeStamp { get; set; }

        object UserData { get; set; }
        string Message { get; set; }
    }
}
