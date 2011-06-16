using System.ComponentModel;


namespace Entities
{

    public class TourCostDetailCollection : BindingList<TourCostDetail>
    {
        internal void CopyTo(TourCostDetailCollection details)
        {
            details.Clear();

            foreach (TourCostDetail detail in this)
            {
                TourCostDetail detailCopy = new TourCostDetail();
                detail.CopyTo(detailCopy);

                details.Add(detailCopy);
            }
        }
    }
}
