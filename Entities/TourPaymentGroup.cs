using System;


namespace Entities
{

    public class TourPaymentGroup
    {

        public Int32 Id { get; set; }
        public string Name { get; set; }
        public TourPaymentRuleCollection Rules { get; set; }


        public TourPaymentGroup()
        {
            this.Id = -1;
            this.Rules = new TourPaymentRuleCollection();
        }


        public void CopyTo(TourPaymentGroup group)
        {
            group.Name = this.Name;
            group.Id = this.Id;
        }


        public override string ToString()
        {
            return this.Name;
        }
    }
}
