using Entities.Abstract;
using DomainModel.Tour.Payment;


namespace DomainModel
{

    public class TourDateValidator : ITourRuleConstraintValidator
    {
        protected TourDateConstraintMapper mapper;


        public TourDateValidator()
        {
            this.mapper = new TourDateConstraintMapper();
        }


        public bool Matches(Entities.Tour tour, Entities.TourCostRuleConstraint constraint)
        {
            bool res = false;

            Entities.ConstraintTourDate date =
                (Entities.ConstraintTourDate)this.mapper.GetDisplayObject(constraint.Properties);

            if (date != null)
            {
                if (date.StartDate.Year >= 0)
                {
                    if (tour.Time.Date.Year < date.StartDate.Year)
                    {
                        // Hour value of tour is 
                        // less than min of the rule
                        return res;
                    }
                    else if (tour.Time.Date.Year == date.StartDate.Year)
                    {
                        if (date.StartDate.Month >= 0)
                        {
                            if (date.StartDate.Month > tour.Time.Date.Month)
                            {
                                return res;
                            }
                            else if (date.StartDate.Month == tour.Time.Date.Month)
                            {
                                if (date.StartDate.Day >= 0 &&
                                    date.StartDate.Day > tour.Time.Date.Day)
                                {
                                    return res;
                                }
                            }/*
                            else if (date.StartDate.Day >= 0 &&
                                    date.StartDate.Day > tour.Time.Date.Day)
                            {
                                return res;
                            }*/
                        }
                        else if (date.StartDate.Day >= 0 &&
                                date.StartDate.Day > tour.Time.Date.Day)
                        {
                            return res;
                        }
                    }
                }
                else if (date.StartDate.Month >= 0)
                {
                    if (date.StartDate.Month > tour.Time.Date.Month)
                    {
                        return res;
                    }
                    else if (date.StartDate.Month == tour.Time.Date.Month)
                    {
                        if (date.StartDate.Day >= 0 &&
                            date.StartDate.Day > tour.Time.Date.Day)
                        {
                            return res;
                        }
                    }
                }
                else if (date.StartDate.Day >= 0 &&
                        date.StartDate.Day > tour.Time.Date.Day)
                {
                    return res;
                }


                if (date.EndDate.Year >= 0)
                {
                    if (tour.Time.Date.Year > date.EndDate.Year)
                    {
                        return res;
                    }
                    else if (tour.Time.Date.Year == date.EndDate.Year)
                    {
                        if (date.EndDate.Month >= 0)
                        {
                            if (date.EndDate.Month < tour.Time.Date.Month)
                            {
                                return res;
                            }
                            else if (date.EndDate.Month == tour.Time.Date.Month)
                            {
                                if (date.EndDate.Day >= 0 &&
                                    date.EndDate.Day < tour.Time.Date.Day)
                                {
                                    return res;
                                }
                            }
                        }
                        else if (date.EndDate.Day >= 0 &&
                                date.EndDate.Day < tour.Time.Date.Day)
                        {
                            return res;
                        }
                    }
                }
                else if (date.EndDate.Month >= 0)
                {
                    if (date.EndDate.Month < tour.Time.Date.Month)
                    {
                        return res;
                    }
                    else if (date.EndDate.Month == tour.Time.Date.Month)
                    {
                        if (date.EndDate.Day >= 0 &&
                            date.EndDate.Day < tour.Time.Date.Day)
                        {
                            return res;
                        }
                    }
                }
                else if (date.EndDate.Day >= 0 &&
                        date.EndDate.Day < tour.Time.Date.Day)
                {
                    return res;
                }

                res = true;
            }

            return res;
        }
    }
}
