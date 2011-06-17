using System;
using System.ComponentModel;


namespace Entities
{

    public class TourPayment : EntityBase
    {
        #region Fields

        protected Money amount;
        protected GeneralType type;
        protected Int32 id;

        #endregion Fields


        #region Properties

        public Money Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                if (this.amount != value)
                {
                    this.amount = value;
                    RaisePropertyChanged("Amount");
                }
            }
        }

        public GeneralType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (this.type != value)
                {
                    this.type = value;
                    RaisePropertyChanged("Type");
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


        public TourPayment()
        {
            this.type = new GeneralType();
            this.amount = new Money(0.0M, null);
            this.id = -1;
        }


        public void CopyTo(TourPayment payment)
        {
            payment.Id = this.Id;
            payment.Type = this.Type;
            payment.Amount = this.Amount;
        }
    }
}
