using System;


namespace Entities
{

    public class TourCostGroup : EntityBase
    {

        #region Fields

        protected string name;
        protected TourCostRuleCollection rules;
        protected Int32 id;
       
        #endregion Fields


        #region Properties

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

        public TourCostRuleCollection Rules
        {
            get
            {
                return this.rules;
            }

            set
            {
                if (this.rules != value)
                {
                    this.rules = value;
                    RaisePropertyChanged("Rules");
                }
            }
        }

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

        #endregion Properties


        public TourCostGroup()
        {
            this.id = -1;
            this.rules = new TourCostRuleCollection();
        }


        public void CopyTo(TourCostGroup group)
        {
            group.Name = this.Name;
            group.Id = this.Id;
        }


        public override string ToString()
        {
            return this.Name;
        }
    }
}
