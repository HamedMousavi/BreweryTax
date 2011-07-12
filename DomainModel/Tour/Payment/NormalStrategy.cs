using System;
using System.ComponentModel;
using Entities;
using Entities.Abstract;


namespace DomainModel.PaymentStrategies
{

    public class NormalStrategy : ITourPaymentStrategy
    {

        private TourServiceCollection services;
        private PaymentRuleValidator ruleValidator;


        public NormalStrategy()
        {
            this.services = new TourServiceCollection();
            this.ruleValidator = new PaymentRuleValidator();
        }


        public bool UpdateReceipt(ITourService service)
        {
            bool res = true;

            // Prevent event firing again while changing list
            Detach(service);

            try
            {

                // Clear old items
                int count = service.Bill.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    TourReceiptItem item = service.Bill.Items[0];

                    if (!item.IsCustom)
                    {
                        res = service.Bill.Delete(item);
                        if (!res) break;
                    }
                }

                // recalculate
                if (res)
                {
                    CreateReceipt(service);
                }

                CalculateTotal(service);
            }
            catch (Exception ex)
            {
            }

            // attach back to tour
            Attach(service);

            return res;
        }


        private void CalculateTotal(ITourService service)
        {
            service.Bill.Total.Value = 0.00M;

            foreach (TourReceiptItem item in service.Bill.Items)
            {
                service.Bill.Total.Value += item.Total.Value;
                if (service.Bill.Total.Currency == null)
                {
                    service.Bill.Total.Currency = item.Total.Currency;
                }
            }
        }


        private void CreateReceipt(ITourService service)
        {
            Money tourBasePPS = service.Detail.PricePerPerson;

            int index = 0;
            if (tourBasePPS != null)
            {
                foreach (TourCostDetail detail in service.CostDetails)
                {
                    TourReceiptItem item = new TourReceiptItem();
                    Int32 quantity = service.ClientCount;

                    item.Index = index;
                    item.ParentIndex = -1;
                    item.PricePerPerson = tourBasePPS;
                    item.Quantity = quantity;
                    item.Description = detail.CostGroup.Name;
                    if (item.Total.Value != 0.0M) service.Bill.Items.Add(item);
                    
                    foreach(TourCostRule rule in detail.CostGroup.Rules)
                    {
                        if (this.ruleValidator.Matches(rule, detail, service))
                        {
                            item = new TourReceiptItem();

                            item.ParentIndex = index;
                            item.Index = ++index;
                            item.Description = rule.Name + " (" + rule.Formula.ToString() + ")";
                            item.Quantity = rule.IsPerPerson ? quantity : 1;
                            item.PricePerPerson = rule.GetTotal(tourBasePPS);
                            if (item.Total.Value != 0.0M) service.Bill.Items.Add(item);
                        }
                    }

                    index++;
                }
            }
        }


        public void Register(ITourService service)
        {
            if (!this.services.Contains(service))
            {
                this.services.Add(service);
                Attach(service);
            }
        }


        public void UnRegister(ITourService service)
        {
            if (this.services.Contains(service))
            {
                Detach(service);
                this.services.Remove(service);
            }
        }


        private void Detach(ITourService service)
        {
            service.PropertyChanged -= new PropertyChangedEventHandler(tour_PropertyChanged);
        }


        private void Attach(ITourService service)
        {
            service.PropertyChanged += new PropertyChangedEventHandler(tour_PropertyChanged);
        }


        void tour_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, "VisitType", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "CostDetails", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "Status", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "Payments", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "Time", System.StringComparison.InvariantCulture))
            {
                UpdateReceipt((ITourService)sender);
            }
        }


    }
}
