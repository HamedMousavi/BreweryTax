using System;
using System.ComponentModel;


namespace Entities
{

    public class Tour
    {

        public Datetime Time { get; set; }
        public GeneralType TourType { get; set; }
        public GeneralType SignUpType { get; set; }
        public TourStatus Status { get; set; }
        public EmployeeCollection Employees { get; set; }
        public TourMemberCollection Members { get; set; }
        public TourCostDetailCollection CostDetails { get; set; }
        public TourPaymentCollection Payments { get; set; }


        public string Comments { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }

        
        public Tour()
        {
            this.Status = new TourStatus();
            this.Time = new Datetime("HH:mm");

            this.Employees = new Entities.EmployeeCollection();
            this.Members = new TourMemberCollection();
            this.CostDetails = new TourCostDetailCollection();
            this.Payments = new TourPaymentCollection();

            this.TourType = new GeneralType();
            this.SignUpType = new GeneralType();
            this.Id = -1;
        }


        public Tour(TourCostGroupCollection CostGroups)
            : this()
        {
            foreach (TourCostGroup group in CostGroups)
            {
                TourCostDetail detail = new TourCostDetail();
                detail.CostGroup = group;

                this.CostDetails.Add(detail);
            }
        }


        public void CopyTo(Tour tour)
        {
            this.Time.CopyTo(tour.Time);
            this.Employees.CopyTo(tour.Employees);
            this.Members.CopyTo(tour.Members);
            this.CostDetails.CopyTo(tour.CostDetails);
            this.Payments.CopyTo(tour.Payments);
            this.Status.CopyTo(tour.Status);

            tour.SignUpType = this.SignUpType;
            tour.TourType = this.TourType;
            tour.Comments = this.Comments;

            tour.Id = this.Id;
        }
    }
}
