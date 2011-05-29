using System;
using System.ComponentModel;


namespace Entities
{

    public class Contact
    {
        public GeneralType Media { get; set; }
        public string Value { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }

        public Contact()
        {
            //this.Media = new GeneralType();
            this.Id = -1;
        }
    }
}
