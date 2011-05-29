using System;
using System.ComponentModel;


namespace Entities
{

    public class Tour
    {

        public Datetime Time { get; set; }

        public GeneralType TourType { get; set; }

        public GeneralType SignUpType { get; set; }
        public Int32 SignUpCount { get; set; }
        public Int32 ParticipantsCount { get; set; }

        public string Comments { get; set; }
        
        public TourStatus Status { get; set; }
        public EmployeeCollection Employees { get; set; }
        public TourMemberCollection Members { get; set; }
        public TourPaymentCollection Payments { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }

        
        public Tour()
        {
            this.Status = new TourStatus();
            this.Time = new Datetime("hh:mm");

            this.Employees = new Entities.EmployeeCollection();
            this.Members = new TourMemberCollection();
            this.Payments = new TourPaymentCollection();

            this.TourType = new GeneralType();
            this.SignUpType = new GeneralType();
            this.Id = -1;
        }


        public void CopyTo(Tour tour)
        {
            this.Time.CopyTo(tour.Time);
            this.Employees.CopyTo(tour.Employees);
            this.Payments.CopyTo(tour.Payments);
            this.Status.CopyTo(tour.Status);

            tour.SignUpType = this.SignUpType;
            tour.TourType = this.TourType;
            tour.Comments = this.Comments;
            tour.SignUpCount = this.SignUpCount;
            tour.ParticipantsCount = this.ParticipantsCount;
            tour.Id = this.Id;
        }
    }
}
