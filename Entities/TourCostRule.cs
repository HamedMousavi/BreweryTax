using System;


namespace Entities
{

    public class TourCostRule
    {
        public string Name { get; set; }
        public TourCostFormula Formula { get; set; }

        public Int32 Id { get; set; }


        public TourCostRule()
        {
            this.Id = -1;
            this.Formula = new TourCostFormula();
        }


        public void CopyTo(TourCostRule rule)
        {
            rule.Id = this.Id;
            rule.Name = this.Name;

            this.Formula.CopyTo(rule.Formula);
        }
    }
}
