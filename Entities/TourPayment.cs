using System;
using System.ComponentModel;


namespace Entities
{

    public class TourPayment
    {
        public Money Amount { get; set; }
        public GeneralType Type { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }


        public TourPayment()
        {
            this.Type = new GeneralType();

            this.Amount = new Money(0.0M, null);

            this.Id = -1;
        }


        internal void CopyTo(TourPayment payment)
        {
            payment.Id = this.Id;
            payment.Type = this.Type;
            payment.Amount = this.Amount;
        }
    }
}
