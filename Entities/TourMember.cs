using System;
using System.ComponentModel;


namespace Entities
{

    public class TourMember
    {
        public GeneralType Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactCollection Contacts { get; set; }

        public GeneralType MemberShip { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }


        public TourMember()
        {
            this.Title = new GeneralType();
            this.MemberShip = new GeneralType();
            this.Contacts = new ContactCollection();
            this.Id = -1;
        }
    }
}
