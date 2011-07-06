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

        public ContactCollection DeletedContacts { get; set; }

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
            member.IsDirty = this.IsDirty;

            this.Contacts.CopyTo(member.Contacts);
            this.DeletedContacts.CopyTo(member.DeletedContacts);
        }
    }
}
