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
        
        #endregion Fields


        #region Properties

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

        public TourMemberCollection DeletedMembers { get; set; }

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

        #endregion Properties


        public TourGroup()
        {
            this.id = -1;
            this.signUpType = new GeneralType();
            this.members = new TourMemberCollection();
            this.services = new TourServiceCollection();

            this.DeletedMembers = new TourMemberCollection();
        }


        public void CopyTo(TourGroup group)
        {
            this.Members.CopyTo(group.Members);
            this.DeletedMembers.CopyTo(group.DeletedMembers);
            this.services.CopyTo(group.services);
            this.SignUpType.CopyTo(group.SignUpType);

            group.Id = this.Id;
            group.name = this.name;
            group.IsDirty = this.IsDirty;
        }
    }
}
