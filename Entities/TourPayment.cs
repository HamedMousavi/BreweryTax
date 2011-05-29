using System;
using System.ComponentModel;


namespace Entities
{

    public class TourPayment
    {

        public Money PricePerPerson { get; set; }
        public GeneralType PaymentType { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }


        public TourPayment()
        {
            this.PaymentType = new GeneralType();

            this.PricePerPerson = new Money(0.0M, null);

            this.Id = -1;
        }


        internal void CopyTo(TourPayment payment)
        {
            payment.Id = this.Id;
            payment.PaymentType = this.PaymentType;
            payment.PricePerPerson = this.PricePerPerson;
        }
    }
}
