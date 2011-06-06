using System;


namespace Entities
{

    public class TourStatus
    {
        public string Name { get; set; }
        public Int32 Id { get; set; }


        internal void CopyTo(TourStatus status)
        {
            status.Id = Id;
            status.Name = status.Name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
