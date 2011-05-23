using System;
using System.ComponentModel;


namespace Entities
{

    public class Money
    {

        [BrowsableAttribute(false)]
        public enum Currencies
        {
            Eur = 0,
            USD = 1
        }


        public Decimal Value { get; set; }


        public Currencies Currency { get; set; }


        public Money(Decimal value, Currencies currency)
        {
            this.Value = value;
            this.Currency = currency;
        }


        public override string ToString()
        {
            return string.Format("{0} {1}", this.Value, this.Currency);
        }
    }
}
