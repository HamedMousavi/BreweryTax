using System;


namespace Entities
{

    public class TourCostRuleConstraintProperty : EntityBase
    {

        protected Int32 id;
        protected Int32 typeId;
        protected object value;


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


        public Int32 TypeId
        {
            get
            {
                return this.typeId;
            }

            set
            {
                if (this.typeId != value)
                {
                    this.typeId = value;
                    RaisePropertyChanged("TypeId");
                }
            }
        }


        public object Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    RaisePropertyChanged("Value");
                }
            }
        }


        public TourCostRuleConstraintProperty()
        {
            this.id = -1;
            this.typeId = -1;
            this.value = null;
        }


        public void CopyTo(TourCostRuleConstraintProperty property)
        {
            property.Id = this.id;
            property.TypeId = this.TypeId;
            property.Value = this.Value;
            property.IsDirty = this.IsDirty;
        }
    }
}
