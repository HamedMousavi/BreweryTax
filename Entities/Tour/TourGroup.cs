using System;
using System.ComponentModel;


namespace Entities
{

    public class TourGroup : EntityBase
    {

        #region Fields
        
        protected Int32 id;
        protected string name;
        protected GeneralType signUpType;
        protected TourMemberCollection members;
        protected TourServiceCollection services;
        protected EmployeeCollection employees;
        protected GeneralType status;
        protected Tour baseTour;
        
        #endregion Fields


        #region Properties

        public Tour BaseTour
        {
            get
            {
                return this.baseTour;
            }

            set
            {
                if (this.baseTour != value)
                {
                    this.baseTour = value;
                    RaisePropertyChanged("BaseTour");
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

        //public TourMemberCollection DeletedMembers { get; set; }

        public TourServiceCollection Services
        {
            get
            {
                return this.services;
            }

            set
            {
                if (this.services != value)
                {
                    this.services = value;
                    RaisePropertyChanged("Services");
                }
            }
        }

        public TourGroup Self
        {
            get
            {
                return this;
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

        // If a tour is confirmed, real participant count 
        // will be used to calculate receipt
        [BrowsableAttribute(false)]
        public bool IsConfirmed
        {
            get
            {
                return this.Status.Id >= 15;
            }
        }

        public EmployeeCollection DeletedEmployees { get; set; }

        #endregion Properties


        public TourGroup()
        {
            this.id = -1;
            this.signUpType = new GeneralType();
            this.members = new TourMemberCollection();
            this.services = new TourServiceCollection();
            this.employees = new Entities.EmployeeCollection();
            this.status = new GeneralType();

            this.DeletedEmployees = new Entities.EmployeeCollection();
        }


        public void CopyTo(TourGroup group)
        {
            this.Members.CopyTo(group.Members);
            //this.DeletedMembers.CopyTo(group.DeletedMembers);
            this.services.CopyTo(group.services);
            this.SignUpType.CopyTo(group.SignUpType);

            this.Employees.CopyTo(group.Employees);
            this.DeletedEmployees.CopyTo(group.DeletedEmployees);
            group.Status = this.Status;

            if (group.Status != null)
            {
                group.Status.IsDirty = this.Status.IsDirty;
            }
            
            group.Id = this.Id;
            group.name = this.name;
            group.IsDirty = this.IsDirty;
        }
    }
}
