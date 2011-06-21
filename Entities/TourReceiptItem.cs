using System;


namespace Entities
{

    public class TourReceiptItem : EntityBase
    {

        protected string description;
        protected Money pricePerPerson;
        protected Int32 quantity;
        protected Int32 id;


        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                if (this.description != value)
                {
                    this.description = value;
                    RaisePropertyChanged("Description");
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

        public Int32 Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (this.quantity != value)
                {
                    this.quantity = value;
                    RaisePropertyChanged("Quantity");
                }
            }
        }

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
        
        public Money Total
        {
            get
            {
                return new Money(
                    PricePerPerson.Value * Quantity,
                    PricePerPerson.Currency);
            }
        }

        
        public Int32 Index { get; set; }
        public Int32 ParentIndex { get; set; }
        public bool IsCustom { get; set; }


        public TourReceiptItem()
        {
            this.pricePerPerson = new Money(0, null);
        }


        internal void CopyTo(TourReceiptItem item)
        {
            item.Description = this.Description;
            item.Quantity = this.Quantity;
            item.Id = this.Id;
            this.PricePerPerson.CopyTo(item.PricePerPerson);

            item.IsDirty = this.IsDirty;
        }
    }
}
