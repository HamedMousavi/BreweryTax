using System.ComponentModel;


namespace Entities
{

    public class TourBasePriceCollection : BindingList<TourBasePrice>
    {
        internal void CopyTo(TourBasePriceCollection Costs)
        {
            Costs.Clear();

            foreach (TourBasePrice Cost in this)
            {
                // UNDONE: SHALL WE DUPLICATE DETAILS OR JUST A REFRENCE IS ENOUGH?!
                TourBasePrice newCost = new TourBasePrice();
                Cost.CopyTo(newCost);

                Costs.Add(newCost);
            }
        }
    }
}
