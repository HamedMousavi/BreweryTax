using System;


namespace Entities
{

    public class TourCostGroup
    {

        public Int32 Id { get; set; }
        public string Name { get; set; }
        public TourCostRuleCollection Rules { get; set; }


        public TourCostGroup()
        {
            this.Id = -1;
            this.Rules = new TourCostRuleCollection();
        }


        public void CopyTo(TourCostGroup group)
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
