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


        public bool GetProperties(object displayObject, Entities.TourCostRuleConstraint con)
        {
            Entities.ConstraintTourTime time = (Entities.ConstraintTourTime)displayObject;
            con.Properties.Clear();

            Entities.TourCostRuleConstraintProperty property;

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartHour;
            property.Value = time.StartTime.Hour;
            con.Properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.StartMinute;
            property.Value = time.StartTime.Minute;
            con.Properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndHour;
            property.Value = time.EndTime.Hour;
            con.Properties.Add(property);

            property = new Entities.TourCostRuleConstraintProperty();
            property.TypeId = (int)TypeIds.EndMinute;
            property.Value = time.EndTime.Minute;
            con.Properties.Add(property);

            con.Name = GenerateName(time);

            return true;

            return false;
        }


        private string GenerateName(Entities.ConstraintTourTime time)
        {
            return string.Format("Tour time:   [{0}:{1}]  to  [{2}:{3}]",
                time.StartTime.Hour < 0 ? "Hour" : time.StartTime.Hour.ToString(),
                time.StartTime.Minute < 0 ? "Minute" : time.StartTime.Minute.ToString(),
                time.EndTime.Hour < 0 ? "Hour" : time.EndTime.Hour.ToString(),
                time.EndTime.Minute < 0 ? "Minute" : time.EndTime.Minute.ToString()
                );
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
