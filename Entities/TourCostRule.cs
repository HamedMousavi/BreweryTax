using System;
using System.ComponentModel;
using Entities.Abstract;


namespace Entities
{

    public class TourCostRule : EntityBase
    {

        #region Fields

        protected string name;
        protected TourCostFormula formula;
        protected Int32 id;
        protected TourCostRuleConstraintCollection constraints;

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

        [BrowsableAttribute(false)]
        public TourCostRuleConstraintCollection Constraints
        {
            get
            {
                return this.constraints;
            }

            set
            {
                if (this.constraints != value)
                {
                    this.constraints = value;
                    RaisePropertyChanged("Constraints");
                }
            }
        }


        #endregion Properties


        public TourCostRule()
        {
            this.constraints = new TourCostRuleConstraintCollection();

            this.IsPerPerson = true;
            this.id = -1;
            this.formula = new TourCostFormula();
        }


        public void CopyTo(TourCostRule rule)
        {
            rule.Id = this.Id;
            rule.Name = this.Name;
            rule.IsPerPerson = this.IsPerPerson;

            this.constraints.CopyTo(rule.Constraints);
            this.Formula.CopyTo(rule.Formula);
        }


        public bool IsPerPerson 
        { 
            get; 
            set; 
        }


        public Money GetTotal(Money tourBasePPS)
        {
            // UNDONE: Currency coversion is ignored

            decimal total;

            if (this.formula.ValueOperation == TourCostFormula.ValueOperations.Percent)
            {
                total = tourBasePPS.Value * (this.formula.Value / 100.00M);
            }
            else
            {
                total = this.formula.Value;
            }

            switch (this.formula.PriceOperation)
            {
                case TourCostFormula.PriceOperations.Add:
                    return new Money(total, tourBasePPS.Currency);

                case TourCostFormula.PriceOperations.Subtract:
                    return new Money(-total, tourBasePPS.Currency);
            }

            return null;
        }
    }
}
