using System;
using System.ComponentModel;


namespace Entities
{

    public class Tour
    {
        public Datetime Time { get; set; }
        public EmployeeCollection Employees { get; set; }
        public TourDetailCollection Details { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }

        
        public Tour()
        {
            this.Time = new Datetime("hh:mm");
            this.Employees = new Entities.EmployeeCollection();
            this.Details = new Entities.TourDetailCollection();
        }


        public void CopyTo(Tour tour)
        {
            this.Time.CopyTo(tour.Time);
            this.Employees.CopyTo(tour.Employees);
            this.Details.CopyTo(tour.Details);
        }
    }
}
