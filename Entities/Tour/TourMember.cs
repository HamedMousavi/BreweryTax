using System;
using System.ComponentModel;


namespace Entities
{

    public class TourMember : EntityBase
    {

        #region Fields

        protected GeneralType title;
        protected string firstName;
        protected string lastName;
        protected ContactCollection contacts;
        protected GeneralType memberShip;
        protected Int32 id;
        protected bool isInPhonebook;
        protected bool isEmployee;

        #endregion Fields


        #region Properties

        public GeneralType Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (this.title != value)
                {
                    this.title = value;
                    RaisePropertyChanged("Title");
                    RaisePropertyChanged("FormattedValue");
                }
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (this.firstName != value)
                {
                    this.firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FormattedValue");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (this.lastName != value)
                {
                    this.lastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FormattedValue");
                }
            }
        }

        public ContactCollection Contacts
        {
            get
            {
                return this.contacts;
            }

            set
            {
                if (this.contacts != value)
                {
                    this.contacts = value;
                    RaisePropertyChanged("Contacts");
                }
            }
        }

        public GeneralType MemberShip
        {
            get
            {
                return this.memberShip;
            }

            set
            {
                if (this.memberShip != value)
                {
                    this.memberShip = value;
                    RaisePropertyChanged("MemberShip");
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

        [BrowsableAttribute(false)]
        public ContactCollection DeletedContacts { get; set; }

        public string FormattedValue
        {
            get
            {
                return this.ToString();
            }
        }

        public bool IsInPhonebook
        {
            get
            {
                return this.isInPhonebook;
            }

            set
            {
                if (this.isInPhonebook != value)
                {
                    this.isInPhonebook = value;
                    RaisePropertyChanged("IsInPhonebook");
                }
            }
        }

        public bool IsEmployee
        {
            get
            {
                return this.isEmployee;
            }

            set
            {
                if (this.isEmployee != value)
                {
                    this.isEmployee = value;
                    RaisePropertyChanged("IsEmployee");
                }
            }
        }

        #endregion Properties


        public TourMember()
        {
            this.title = new GeneralType();
            this.memberShip = new GeneralType();
            this.contacts = new ContactCollection();
            this.id = -1;

            this.DeletedContacts = new ContactCollection();
        }


        public void CopyTo(TourMember member)
        {
            member.FirstName = this.FirstName;
            member.LastName = this.LastName;
            member.Title = this.Title;
            member.MemberShip = this.MemberShip;
            member.Id = this.Id;
            member.IsEmployee = this.IsEmployee;
            member.IsInPhonebook = this.IsInPhonebook;
            member.IsDirty = this.IsDirty;

            this.Contacts.CopyTo(member.Contacts);
            this.DeletedContacts.CopyTo(member.DeletedContacts);
        }


        public override string ToString()
        {
            //return base.ToString();

            return string.Format(
                "{0} {1} {2}",
                this.title == null ? "" : this.title.Name,
                this.firstName,
                this.lastName);
        }
    }
}