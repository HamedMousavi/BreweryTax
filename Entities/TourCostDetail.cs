using System;

namespace Entities
{
    public class TourCostDetail
    {
        public TourCostGroup CostGroup { get; set; }
        public Int32 SignUpCount { get; set; }
        public Int32 ParticipantsCount { get; set; }
        public Int32 Id { get; set; }

        public TourCostDetail()
        {
            this.Id = -1;
        }


        public void CopyTo(TourCostDetail detail)
        {
            detail.SignUpCount = this.SignUpCount;
            detail.ParticipantsCount = this.ParticipantsCount;
            detail.Id = this.Id;
            detail.CostGroup = this.CostGroup;
        }
    }
}
