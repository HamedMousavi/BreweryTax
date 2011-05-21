using System;



namespace StatusController.Abstract
{
    public interface IStatusMessage
    {
        Int16 Id { get; set; }
        string Text { get; set; }
    }
}
