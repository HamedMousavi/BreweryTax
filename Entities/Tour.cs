using System;
using System.ComponentModel;


namespace Entities
{

    public class Tour : EntityBase
    {

        #region Fields

        protected Datetime time;
        protected GeneralType tourType;
        protected GeneralType signUpType;
        protected GeneralType status;
        protected EmployeeCollection employees;
        protected TourMemberCollection members;
        protected TourCostDetailCollection costDetails;
        protected TourPaymentCollection payments;
        protected string comments;
        protected Int32 id;

        public Abstract.ITourPaymentStrategy paymentStrategy;

        #endregion Fields


        #region Properties

        public Datetime Time 
        {
            get
            {
                return this.time;
            }

            set
            {
                if (this.time != value)
                {
                    this.time = value;
                    RaisePropertyChanged("Time");
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

        public GeneralType SignUpType
        {
            get
            {
                return this.signUpType;
            }

            set
            {
                if (this.signUpType != value)
                {
                    this.signUpType = value;
                    RaisePropertyChanged("SignUpType");
                }
            }
        }

        public GeneralType Status
        {
            get
            {
                return this.status;
            }

            set
            {
                if (this.status != value)
                {
                    this.status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }

        public EmployeeCollection Employees
        {
            get
            {
                return this.employees;
            }

            set
            {
                if (this.employees != value)
                {
                    this.employees = value;
                    RaisePropertyChanged("Employees");
                }
            }
        }

        public TourMemberCollection Members
        {
            get
            {
                return this.members;
            }

            set
            {
                if (this.members != value)
                {
                    this.members = value;
                    RaisePropertyChanged("Members");
                }
            }
        }

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
        
        public string Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                if (this.comments != value)
                {
                    this.comments = value;
                    RaisePropertyChanged("Comments");
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

        public TourReceipt Receipt { get; private set; }

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

        public EmployeeCollection DeletedEmployees { get; set; }
        public TourMemberCollection DeletedMembers { get; set; }
        public TourPaymentCollection DeletedPayments { get; set; }

        #endregion Properties


        public Tour()
        {
            this.time = new Datetime("HH:mm");
            this.time.PropertyChanged += new 
                PropertyChangedEventHandler(time_PropertyChanged);

            this.employees = new Entities.EmployeeCollection();
            this.members = new TourMemberCollection();
            this.costDetails = new TourCostDetailCollection();
            this.payments = new TourPaymentCollection();

            this.DeletedEmployees = new Entities.EmployeeCollection();
            this.DeletedMembers = new TourMemberCollection();
            this.DeletedPayments = new TourPaymentCollection();
            this.Receipt = new TourReceipt();
            
            this.status = new GeneralType();
            this.tourType = new GeneralType();
            this.signUpType = new GeneralType();
            this.id = -1;
        }


        void time_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Time.value changes and thus it doesn't directly updates
            // To understand time updates we must listen to it's changes
            RaisePropertyChanged("Time");
        }


        public Tour(TourCostGroupCollection CostGroups)
            : this()
        {
            foreach (TourCostGroup group in CostGroups)
            {
                TourCostDetail detail = new TourCostDetail();
                detail.CostGroup = group;

                this.CostDetails.Add(detail);
            }
        }


        public void CopyTo(Tour tour)
        {
            this.Time.CopyTo(tour.Time);
            this.Employees.CopyTo(tour.Employees);
            this.Members.CopyTo(tour.Members);
            this.CostDetails.CopyTo(tour.CostDetails);
            this.Payments.CopyTo(tour.Payments);

            this.DeletedEmployees.CopyTo(tour.DeletedEmployees);
            this.DeletedMembers.CopyTo(tour.DeletedMembers);
            this.DeletedPayments.CopyTo(tour.DeletedPayments);
            this.Receipt.CopyTo(tour.Receipt);

            tour.Status = this.Status;
            tour.SignUpType = this.SignUpType;
            tour.TourType = this.TourType;
            tour.Comments = this.Comments;

            tour.Id = this.Id;
            

            if (tour.SignUpType != null) tour.SignUpType.IsDirty    = this.SignUpType.IsDirty;
            if (tour.Time != null) tour.Time.IsDirty                = this.Time.IsDirty;
            if (tour.TourType != null) tour.TourType.IsDirty        = this.TourType.IsDirty;
            if (tour.Status != null) tour.Status.IsDirty            = this.Status.IsDirty;

            tour.IsDirty = this.IsDirty;
        }
    }
}
