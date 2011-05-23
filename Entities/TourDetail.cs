using System;
using System.ComponentModel;


namespace Entities
{

    public class TourDetail
    {

        public string GuestName { get; set; }
        public string SignupType { get; set; }
        public Int32  SignedupCount { get; set; }
        public Int32  ParticipantCount { get; set; }
        public string TourType { get; set; }
        public string PaymentType { get; set; }
        public Money  PricePerPerson { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }


        public TourDetail()
        {
            this.PricePerPerson = new Money(0.00M, Money.Currencies.Eur);
        }


        public void CopyTo(TourDetail detail)
        {
            detail.GuestName =          this.GuestName;
            detail.SignupType =         this.SignupType;
            detail.SignedupCount =      this.SignedupCount;
            detail.ParticipantCount =   this.ParticipantCount;
            detail.TourType =           this.TourType;
            detail.PaymentType =        this.PaymentType;
            detail.PricePerPerson =     this.PricePerPerson;
            detail.Id = this.Id;
        }
    }
}
