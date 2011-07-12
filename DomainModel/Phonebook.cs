using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class Phonebook
    {
        public static Entities.TourMemberCollection GetAll()
        {
            return new Entities.TourMemberCollection();
        }
    }
}
