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
                // UNDONE: SHALL WE DUPLICATE DETAILS OR JUST A REFRENCE IS ENOUGH?!
                TourPayment newpayment = new TourPayment();
                payment.CopyTo(newpayment);

                payments.Add(newpayment);
            }
        }
    }
}
