using System.ComponentModel;
using System;


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


        public int ServiceCount
        {
            get
            {
                Int32 sum = 0;

                foreach (TourCostDetail detail in this)
                {
                    sum += detail.Count;
                }

                return sum;
            }
        }
    }
}
