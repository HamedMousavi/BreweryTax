using System.ComponentModel;


namespace Entities
{

    public class TourPaymentDetailCollection : BindingList<TourPaymentDetail>
    {
        internal void CopyTo(TourPaymentDetailCollection details)
        {
            details.Clear();

            foreach (TourPaymentDetail detail in this)
            {
                TourPaymentDetail detailCopy = new TourPaymentDetail();
                detail.CopyTo(detailCopy);

                details.Add(detailCopy);
            }
        }
    }
}
