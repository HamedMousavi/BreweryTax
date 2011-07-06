using System;
using System.ComponentModel;


namespace Entities
{

    public class TourCostRuleConstraint : EntityBase
    {

        protected Int32 id;
        protected string name;
        protected GeneralType constraintType;
        protected TourCostRuleConstraintPropertyCollection properties;


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


        public GeneralType ConstraintType
        {
            get
            {
                return this.constraintType;
            }

            set
            {
                if (this.constraintType != value)
                {
                    this.constraintType = value;
                    RaisePropertyChanged("ConstraintType");
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


        [BrowsableAttribute(false)]
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


        public TourCostRuleConstraint()
        {
            this.id = -1;
            this.properties = new TourCostRuleConstraintPropertyCollection();
        }


        public void CopyTo(TourCostRuleConstraint constraint)
        {
            constraint.Id = this.id;
            constraint.Name = this.name;
            constraint.ConstraintType = this.ConstraintType;
            this.properties.CopyTo(constraint.Properties);

            constraint.IsDirty = this.IsDirty;
        }
    }
}
