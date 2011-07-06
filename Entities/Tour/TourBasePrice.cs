using System;
using System.ComponentModel;


namespace Entities
{

    public class TourBasePrice : EntityBase
    {

        #region Fields

        protected Money pricePerPerson;
        protected GeneralType tourType;
        protected Int32 id;

        #endregion Fields

       
        #region Properties

        public Money PricePerPerson
        {
            get
            {
                return this.pricePerPerson;
            }

            set
            {
                if (this.pricePerPerson != value)
                {
                    this.pricePerPerson = value;
                    RaisePropertyChanged("PricePerPerson");
                }
            }
        }

        public GeneralType TourType
        {
            get
            {
                return this.tourType;
            }

            set
            {
                if (this.tourType != value)
                {
                    this.tourType = value;
                    RaisePropertyChanged("TourType");
                }
            }
        }

        [BrowsableAttribute(false)]
        public Int32 Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        #endregion Properties


        public TourBasePrice()
        {
            this.tourType = new GeneralType();

            this.pricePerPerson = new Money(0.0M, null);
            this.pricePerPerson.PropertyChanged += new 
                PropertyChangedEventHandler(pricePerPerson_PropertyChanged);

            this.id = -1;
        }


        void pricePerPerson_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RaisePropertyChanged("PricePerPerson");
        }


        internal void CopyTo(TourBasePrice Cost)
        {
            Cost.Id = this.Id;
            Cost.TourType = this.TourType;
            Cost.PricePerPerson = this.PricePerPerson;
        }
    }
}
