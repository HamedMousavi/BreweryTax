

namespace Entities
{

    public class TourConstraintTimeItem
    {

        public int Hour { get; set; }
        public int Minute { get; set; }


        public TourConstraintTimeItem()
        {
            this.Hour = -1;
            this.Minute = -1;
        }


        public void CopyTo(TourConstraintTimeItem date)
        {
            date.Hour = this.Hour;
            date.Minute = this.Minute;
        }
    }
}
