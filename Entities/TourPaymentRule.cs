using System;


namespace Entities
{

    public class TourPaymentRule
    {
        public string Name { get; set; }
        public TourPaymentFormula Formula { get; set; }

        public Int32 Id { get; set; }


        public TourPaymentRule()
        {
            this.Id = -1;
            this.Formula = new TourPaymentFormula();
        }


        public void CopyTo(TourPaymentRule rule)
        {
            rule.Id = this.Id;
            rule.Name = this.Name;

            this.Formula.CopyTo(rule.Formula);
        }
    }
}
