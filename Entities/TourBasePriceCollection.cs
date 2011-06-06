using System.ComponentModel;


namespace Entities
{

    public class TourBasePriceCollection : BindingList<TourBasePrice>
    {
        internal void CopyTo(TourBasePriceCollection payments)
        {
            payments.Clear();

            foreach (TourBasePrice payment in this)
            {
                // UNDONE: SHALL WE DUPLICATE DETAILS OR JUST A REFRENCE IS ENOUGH?!
                TourBasePrice newpayment = new TourBasePrice();
                payment.CopyTo(newpayment);

                payments.Add(newpayment);
            }
        }
    }
}
