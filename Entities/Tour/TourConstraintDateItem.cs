

namespace Entities
{

    public class TourConstraintDateItem
    {

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }


        public TourConstraintDateItem()
        {
            this.Year = -1;
            this.Month = -1;
            this.Day = -1;
        }


        public void CopyTo(TourConstraintDateItem date)
        {
            date.Year = this.Year;
            date.Month = this.Month;
            date.Day = this.Day;
        }
    }
}
