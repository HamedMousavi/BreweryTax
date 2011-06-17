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
        protected TourStatus status;
        protected EmployeeCollection employees;
        protected TourMemberCollection members;
        protected TourCostDetailCollection costDetails;
        protected TourPaymentCollection payments;
        protected string comments;
        protected Int32 id;

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

        public TourStatus Status
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

        #endregion Properties


        public Tour()
        {
            this.status = new TourStatus();
            this.time = new Datetime("HH:mm");

            this.employees = new Entities.EmployeeCollection();
            this.members = new TourMemberCollection();
            this.costDetails = new TourCostDetailCollection();
            this.payments = new TourPaymentCollection();

            this.tourType = new GeneralType();
            this.signUpType = new GeneralType();
            this.id = -1;
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
            this.Status.CopyTo(tour.Status);

            tour.SignUpType = this.SignUpType;
            tour.TourType = this.TourType;
            tour.Comments = this.Comments;

            tour.Id = this.Id;
        }
    }
}
