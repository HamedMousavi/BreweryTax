

namespace Entities
{

    public class ConstraintTourTime
    {

        public TourConstraintTimeItem StartTime { get; set; }
        public TourConstraintTimeItem EndTime { get; set; }


        public ConstraintTourTime()
        {
            this.StartTime = new TourConstraintTimeItem();
            this.EndTime = new TourConstraintTimeItem();
        }


        public void CopyTo(ConstraintTourTime tourTime)
        {
            this.EndTime.CopyTo(tourTime.EndTime);
            this.StartTime.CopyTo(tourTime.StartTime);
        }
    }
}
