using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace Entities
{

    public class TourDetailCollection : BindingList<TourDetail>
    {

        internal void CopyTo(TourDetailCollection tourDetails)
        {
            tourDetails.Clear();

            foreach(TourDetail detail in this)
            {
                // UNDONE: SHALL WE DUPLICATE DETAILS OR JUST A REFRENCE IS ENOUGH?!
                TourDetail newdetail = new TourDetail();
                detail.CopyTo(newdetail);

                tourDetails.Add(newdetail);
            }
        }
    }
}
