using System;

namespace Entities
{
    public class TourPaymentDetail
    {
        public TourPaymentGroup PaymentGroup { get; set; }
        public Int32 SignUpCount { get; set; }
        public Int32 ParticipantsCount { get; set; }
        public Int32 Id { get; set; }

        public TourPaymentDetail()
        {
            this.Id = -1;
        }


        public void CopyTo(TourPaymentDetail detail)
        {
            detail.SignUpCount = this.SignUpCount;
            detail.ParticipantsCount = this.ParticipantsCount;
            detail.Id = this.Id;
            detail.PaymentGroup = this.PaymentGroup;
        }
    }
}
