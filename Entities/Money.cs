using System;
using System.ComponentModel;


namespace Entities
{

    public class Money : INotifyPropertyChanged
    {

        protected MoneyCurrency currency;
        protected decimal value;


        public decimal Value 
        {
            get { return this.value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    RaisePropertyChanged("Value");
                }
            }
        }
        public MoneyCurrency Currency
        {
            get { return this.currency; }
            set
            {
                if (this.currency != value)
                {
                    this.currency = value;
                    RaisePropertyChanged("Currency");
                }
            }
        }


        public Money(decimal value, MoneyCurrency currency)
        {
            this.value = value;
            this.currency = currency;
        }


        public override string ToString()
        {
            if (this.currency == null)
            {
                return string.Format("{0}", this.value);
            }
            else
            {
                return string.Format("{0:0.00} {1}", this.value, this.Currency.Symbol);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        internal void CopyTo(Money money)
        {
            money.Currency = this.currency;
            money.Value = this.value;
        }
    }
}
