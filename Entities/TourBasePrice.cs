using System;
using System.ComponentModel;


namespace Entities
{

    public class TourBasePrice
    {

        public Money PricePerPerson { get; set; }
        public GeneralType TourType { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }


        public TourBasePrice()
        {
            this.TourType = new GeneralType();

            this.PricePerPerson = new Money(0.0M, null);

            this.Id = -1;
        }


        internal void CopyTo(TourBasePrice Cost)
        {
            Cost.Id = this.Id;
            Cost.TourType = this.TourType;
            Cost.PricePerPerson = this.PricePerPerson;
        }
    }
}
