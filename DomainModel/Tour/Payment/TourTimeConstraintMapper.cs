using System;
using Entities.Abstract;


namespace DomainModel.Tour.Payment
{

    public class TourTimeConstraintMapper : ITourConstraintMapper
    {

        protected enum TypeIds
        {
            StartHour = 0,
            StartMinute,
            EndHour,
            EndMinute
        }


        public bool GetProperties(object displayObject, out Entities.TourCostRuleConstraintPropertyCollection properties)
        {
            Entities.ConstraintTourTime time = (Entities.ConstraintTourTime)displayObject;
            properties = new Entities.TourCostRuleConstraintPropertyCollection();

            Entities.TourCostRuleConstraintProperty property;

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartHour;
            property.Value = time.StartTime.Hour;
            properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartMinute;
            property.Value = time.StartTime.Minute;
            properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndHour;
            property.Value = time.EndTime.Hour;
            properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndMinute;
            property.Value = time.EndTime.Minute;
            properties.Add(property);

            return true;

            return false;
        }


        public object GetDisplayObject(Entities.TourCostRuleConstraintPropertyCollection properties)
        {
            Entities.ConstraintTourTime time = new Entities.ConstraintTourTime();

            foreach (Entities.TourCostRuleConstraintProperty property in properties)
            {
                TypeIds type = (TypeIds)property.TypeId;
                switch (type)
                {
                    case TypeIds.StartHour:
                        time.StartTime.Hour = (int)property.Value;
                        break;
                    case TypeIds.StartMinute:
                        time.StartTime.Minute = (int)property.Value;
                        break;
                    case TypeIds.EndHour:
                        time.EndTime.Hour = (int)property.Value;
                        break;
                    case TypeIds.EndMinute:
                        time.EndTime.Minute = (int)property.Value;
                        break;
                }
            }

            return time;
        }
    }
}
