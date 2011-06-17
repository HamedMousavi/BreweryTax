using System;


namespace Entities
{

    public class TourCostRule : EntityBase
    {

        #region Fields

        protected string name;
        protected TourCostFormula formula;
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

        public TourCostFormula Formula
        {
            get
            {
                return this.formula;
            }

            set
            {
                if (this.formula != value)
                {
                    this.formula = value;
                    RaisePropertyChanged("Formula");
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


        public TourCostRule()
        {
            this.id = -1;
            this.formula = new TourCostFormula();
        }


        public void CopyTo(TourCostRule rule)
        {
            rule.Id = this.Id;
            rule.Name = this.Name;

            this.Formula.CopyTo(rule.Formula);
        }
    }
}
