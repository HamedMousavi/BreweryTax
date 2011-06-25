using Entities.Abstract;


namespace DomainModel.Tour.Payment
{

    public class TourDateConstraintMapper : ITourConstraintMapper
    {

        protected enum TypeIds
        {
            StartYear = 0,
            StartMonth,
            StartDay,
            EndYear,
            EndMonth,
            EndDay
        }


        public bool GetProperties(object displayObject, Entities.TourCostRuleConstraint con)
        {
            Entities.ConstraintTourDate date = (Entities.ConstraintTourDate)displayObject;
            con.Properties.Clear();

            Entities.TourCostRuleConstraintProperty property;

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartYear;
            property.Value = date.StartDate.Year;
            con.Properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartMonth;
            property.Value = date.StartDate.Month;
            con.Properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartDay;
            property.Value = date.StartDate.Day;
            con.Properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndYear;
            property.Value = date.EndDate.Year;
            con.Properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndMonth;
            property.Value = date.EndDate.Month;
            con.Properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndDay;
            property.Value = date.EndDate.Day;
            con.Properties.Add(property);

            con.Name = GenerateName(date);

            return true;

            return false;
        }


        private string GenerateName(Entities.ConstraintTourDate date)
        {
            return string.Format("Tour date:   [{0}/{1}/{2}] to [{3}/{4}/{5}]",
                date.StartDate.Year == -1 ? "Year" : date.StartDate.Year.ToString(),
                date.StartDate.Month == -1 ? "Month" : date.StartDate.Month.ToString(),
                date.StartDate.Day == -1 ? "Day" : date.StartDate.Day.ToString(),
                date.EndDate.Year == -1 ? "Year" : date.EndDate.Year.ToString(),
                date.EndDate.Month == -1 ? "Month" : date.EndDate.Month.ToString(),
                date.EndDate.Day == -1 ? "Day" : date.EndDate.Day.ToString()
                );
        }


        public object GetDisplayObject(Entities.TourCostRuleConstraintPropertyCollection properties)
        {
            Entities.ConstraintTourDate date = new Entities.ConstraintTourDate();

            foreach (Entities.TourCostRuleConstraintProperty property in properties)
            {
                TypeIds type = (TypeIds)property.TypeId;
                switch (type)
                {
                    case TypeIds.StartYear:
                        date.StartDate.Year = (int)property.Value;
                        break;
                    case TypeIds.StartMonth:
                        date.StartDate.Month = (int)property.Value;
                        break;
                    case TypeIds.StartDay:
                        date.StartDate.Day = (int)property.Value;
                        break;
                    case TypeIds.EndYear:
                        date.EndDate.Year = (int)property.Value;
                        break;
                    case TypeIds.EndMonth:
                        date.EndDate.Month = (int)property.Value;
                        break;
                    case TypeIds.EndDay:
                        date.EndDate.Day = (int)property.Value;
                        break;
                }
            }

            return date;
        }
    }
}
