using System;
using System.ComponentModel;
using Entities.Abstract;


namespace Entities
{

    public abstract class TourServiceBase : EntityBase, ITourService
    {

        #region Fields

        protected Int32 id;
        protected GeneralType type;
        protected TourCostDetailCollection costDetails;
        protected TourPaymentCollection payments;
        protected Abstract.ITourPaymentStrategy paymentStrategy;

        #endregion Fields


        #region Properties

        public TourReceipt Bill { get; private set; }

        public TourCostDetailCollection CostDetails
        {
            get
            {
                return this.costDetails;
            }

            set
            {
                if (this.costDetails != value)
                {
                    this.costDetails = value;
                    RaisePropertyChanged("CostDetails");
                }
            }
        }

        public TourPaymentCollection Payments
        {
            get
            {
                return this.payments;
            }

            set
            {
                if (this.payments != value)
                {
                    this.payments = value;
                    RaisePropertyChanged("Payments");
                }
            }
        }

        [BrowsableAttribute(false)]
        public Abstract.ITourPaymentStrategy PaymentStrategy
        {
            get { return this.paymentStrategy; }
            set
            {
                if (this.paymentStrategy != value)
                {
                    if (this.paymentStrategy != null)
                    {
                        this.paymentStrategy.UnRegister(this);
                    }

                    this.paymentStrategy = value;
                    this.paymentStrategy.Register(this);
                }
            }
        }

        public TourPaymentCollection DeletedPayments { get; set; }

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


        public TourServiceBase()
        {
            this.id = -1;
            this.costDetails = new TourCostDetailCollection();
            this.payments = new TourPaymentCollection();
            this.Bill = new TourReceipt();

            this.DeletedPayments = new TourPaymentCollection();

            this.CostDetails.ListChanged += new ListChangedEventHandler(CostDetails_ListChanged);
            this.Payments.ListChanged += new ListChangedEventHandler(Payments_ListChanged);
        }


        void Payments_ListChanged(object sender, ListChangedEventArgs e)
        {
            RaisePropertyChanged("Payments");
        }


        void CostDetails_ListChanged(object sender, ListChangedEventArgs e)
        {
            RaisePropertyChanged("CostDetails");
        }


        protected void CopyTo(TourServiceBase service)
        {
            service.id = this.id;
            
            this.costDetails.CopyTo(service.costDetails);
            this.payments.CopyTo(service.payments);
            this.Bill.CopyTo(service.Bill);
            this.DeletedPayments.CopyTo(service.DeletedPayments);

            service.IsDirty = this.IsDirty;
        }


        public int ClientCount
        {
            get 
            {
                return 1000;
                /*
                if (IsConfirmed)
                {
                    return costDetails.ParticipantsCount;
                }
                else
                {
                    return costDetails.SignUpCount;
                }*/
            }
        }


        public abstract ITourService Clone();
        
        public abstract string Name { get; }
    }
}
