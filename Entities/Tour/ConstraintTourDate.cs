

namespace Entities
{

    public class ConstraintTourDate
    {

        public TourConstraintDateItem StartDate { get; set; }
        public TourConstraintDateItem EndDate { get; set; }


        public ConstraintTourDate()
        {
            this.StartDate = new TourConstraintDateItem();
            this.EndDate = new TourConstraintDateItem();
        }


        public void CopyTo(ConstraintTourDate tourDate)
        {
            this.EndDate.CopyTo(tourDate.EndDate);
            this.StartDate.CopyTo(tourDate.StartDate);
        }
    }
}
