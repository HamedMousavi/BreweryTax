using System;
using System.ComponentModel;


namespace Entities
{

    public class Service : EntityBase
    {

        #region Fields

        protected Money pricePerPerson;
        protected GeneralType serviceType;
        protected Int32 id;
        protected string name;

        #endregion Fields


        #region Properties

        public GeneralType ServiceType
        {
            get
            {
                return this.serviceType;
            }

            set
            {
                if (this.serviceType != value)
                {
                    this.serviceType = value;
                    RaisePropertyChanged("ServiceType");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

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


        public Service()
        {
            this.serviceType = new GeneralType();

            this.pricePerPerson = new Money(0.0M, null);
            this.pricePerPerson.PropertyChanged += new 
                PropertyChangedEventHandler(pricePerPerson_PropertyChanged);

            this.id = -1;
        }


        void pricePerPerson_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RaisePropertyChanged("PricePerPerson");
        }


        internal void CopyTo(Service service)
        {
            service.Name = this.name;
            service.Id = this.Id;
            service.ServiceType = this.serviceType;
            service.PricePerPerson = this.PricePerPerson;

            service.IsDirty = this.IsDirty;
        }
    }
}
