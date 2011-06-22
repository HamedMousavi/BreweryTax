using System;


namespace Entities
{

    public class TourCostRuleConstraint : EntityBase
    {

        public Int32 id;
        public string name;
        public TourCostRuleConstraintPropertyCollection properties;


        public Int32 Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }


        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }


        public TourCostRuleConstraintPropertyCollection Properties
        {
            get
            {
                return this.properties;
            }

            set
            {
                if (this.properties != value)
                {
                    this.properties = value;
                    RaisePropertyChanged("Properties");
                }
            }
        }


        public TourCostRuleConstraint()
        {
            this.id = -1;
            this.properties = new TourCostRuleConstraintPropertyCollection();
        }


        public void CopyTo(TourCostRuleConstraint constraint)
        {
            constraint.Id = this.id;
            constraint.Name = this.name;
            this.properties.CopyTo(constraint.Properties);

            constraint.IsDirty = this.IsDirty;
        }
    }
}
