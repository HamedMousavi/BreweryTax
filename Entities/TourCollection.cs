using System;
using System.ComponentModel;


namespace Entities
{

    public class TourCollection : BindingList<Tour>
    {
        public DateTime Time { get; set; }
    }
}
