using System.ComponentModel;


namespace Entities
{

    public class TourPaymentCollection : BindingList<TourPayment>
    {
        internal void CopyTo(TourPaymentCollection payments)
        {
            payments.Clear();

            foreach (TourPayment payment in this)
            {
                TourPayment paymentCopy = new TourPayment();
                payment.CopyTo(paymentCopy);

                payments.Add(paymentCopy);
            }
        }


        public void UndoDelete(TourPaymentCollection originalList)
        {
            foreach (TourPayment payment in this)
            {
                originalList.Add(payment);
            }

            this.Clear();
        }
    }
}
