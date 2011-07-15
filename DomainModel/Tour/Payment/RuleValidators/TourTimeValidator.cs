using System;
using Entities.Abstract;
using DomainModel.Tour.Payment;


namespace DomainModel
{

    public class TourTimeValidator : ITourRuleConstraintValidator
    {
        protected TourTimeConstraintMapper mapper;


        public TourTimeValidator()
        {
            this.mapper = new TourTimeConstraintMapper();
        }


        public bool Matches(Entities.Tour tour, ITourService service, Entities.TourCostDetail detail, Entities.TourCostRuleConstraint constraint)
        {
            bool res = false;

            Entities.ConstraintTourTime time =
                (Entities.ConstraintTourTime)this.mapper.GetDisplayObject(constraint.Properties);

            if (time != null)
            {
                if (time.StartTime.Hour >= 0)
                {
                    if (tour.Time.Time.Hour < time.StartTime.Hour)
                    {
                        // Hour value of tour is 
                        // less than min of the rule
                        return res;
                    }
                    else if (tour.Time.Time.Hour == time.StartTime.Hour)
                    {
                        if (time.StartTime.Minute >= 0 &&
                            time.StartTime.Minute > tour.Time.Time.Minute)
                        {
                            // hours value are equal but
                            // minutes value of tour is
                            // less than min of rule
                            return res;
                        }
                    }
                }
                else if (time.StartTime.Minute >= 0)
                {
                    if (time.StartTime.Minute > tour.Time.Time.Minute)
                    {
                        // hours value are equal but
                        // minutes value of tour is
                        // less than min of rule
                        return res;
                    }
                }

                if (time.EndTime.Hour >= 0)
                {
                    if (tour.Time.Time.Hour > time.EndTime.Hour)
                    {
                        // Hour value of tour is 
                        // after max of the rule
                        return res;
                    }
                    else if (tour.Time.Time.Hour == time.EndTime.Hour)
                    {
                        if (time.EndTime.Minute >= 0 &&
                            time.EndTime.Minute > tour.Time.Time.Minute)
                        {
                            // hours value are equal but
                            // minutes value of tour is
                            // less than min of rule
                            return res;
                        }
                    }
                }
                else if (time.EndTime.Minute >= 0)
                {
                    if (time.EndTime.Minute > tour.Time.Time.Minute)
                    {
                        // hours value are equal but
                        // minutes value of tour is
                        // less than min of rule
                        return res;
                    }
                }

                res = true;
            }

            return res;
        }
    }
}
