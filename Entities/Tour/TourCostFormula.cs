using System;


namespace Entities
{

    public class TourCostFormula
    {

        protected readonly string[] priceOpSymbols = new string[] { "+", "-" };
        protected readonly string[] valueOpSymbols = new string[] { "%" };


        public enum PriceOperations
        {
            Add = 0,
            Subtract = 1
        }


        public enum ValueOperations
        {
            Percent = 0,
            Currency = 1
        }


        //public Int32 Id { get; set; }
        public PriceOperations PriceOperation { get; set; } // + or -
        public decimal Value { get; set; }
        public ValueOperations ValueOperation { get; set; } // % or currency
        public MoneyCurrency Currency { get; set; }

        
        internal void CopyTo(TourCostFormula formula)
        {
            //formula.Id = this.Id;
            formula.PriceOperation = this.PriceOperation;
            formula.Value = this.Value;
            formula.ValueOperation = this.ValueOperation;
            formula.Currency = this.Currency;
        }


        public override string ToString()
        {
            string valSymbol;
            if (this.ValueOperation == ValueOperations.Currency)
            {
                valSymbol = Currency.Symbol;
            }
            else
            {
                valSymbol = this.valueOpSymbols[(Int32)this.ValueOperation];
            }

            return string.Format(
                "{0}{1:0.00}{2, 3}",
                this.priceOpSymbols[(Int32)this.PriceOperation],
                this.Value,
                valSymbol);
        }
    }
}
