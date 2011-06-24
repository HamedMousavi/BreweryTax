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


        public bool GetProperties(object displayObject, out Entities.TourCostRuleConstraintPropertyCollection properties)
        {
            Entities.ConstraintTourDate date = (Entities.ConstraintTourDate)displayObject;
            properties = new Entities.TourCostRuleConstraintPropertyCollection();

            Entities.TourCostRuleConstraintProperty property;

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartYear;
            property.Value = date.StartDate.Year;
            properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartMonth;
            property.Value = date.StartDate.Month;
            properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartDay;
            property.Value = date.StartDate.Day;
            properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndYear;
            property.Value = date.EndDate.Year;
            properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndMonth;
            property.Value = date.EndDate.Month;
            properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndDay;
            property.Value = date.EndDate.Day;
            properties.Add(property);

            return true;

            return false;
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
