using System;
using StatusController.Abstract;



namespace StatusController.Entities
{
    public class StatusMessage : IStatusMessage
    {
        public Int16 Id { get; set; }
        public string Text { get; set; }


        public StatusMessage(Int16 id, string text)
        {
            this.Text = text;
            this.Id = id;
        }
    }
}
