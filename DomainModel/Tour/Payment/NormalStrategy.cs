using System;
using System.ComponentModel;
using Entities;
using Entities.Abstract;


namespace DomainModel.PaymentStrategies
{

    public class NormalStrategy : ITourPaymentStrategy
    {

        private TourCollection tours;
        private PaymentRuleValidator ruleValidator;


        public NormalStrategy()
        {
            this.tours = new TourCollection();
            this.ruleValidator = new PaymentRuleValidator();
        }


        public bool UpdateReceipt(Entities.Tour tour)
        {
            bool res = true;

            // Prevent event firing again while changing list
            Detach(tour);

            try
            {

                // Clear old items
                int count = tour.Receipt.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    TourReceiptItem item = tour.Receipt.Items[0];

                    if (!item.IsCustom)
                    {
                        res = tour.Receipt.Delete(item);
                        if (!res) break;
                    }
                }

                // recalculate
                if (res)
                {
                    CreateReceipt(tour);
                }

                CalculateTotal(tour);
            }
            catch (Exception ex)
            {
            }

            // attach back to tour
            Attach(tour);

            return res;
        }


        private void CalculateTotal(Entities.Tour tour)
        {
            tour.Receipt.Total.Value = 0.00M;

            foreach (TourReceiptItem item in tour.Receipt.Items)
            {
                tour.Receipt.Total.Value += item.Total.Value;
                if (tour.Receipt.Total.Currency == null)
                {
                    tour.Receipt.Total.Currency = item.Total.Currency;
                }
            }
        }


        private void CreateReceipt(Entities.Tour tour)
        {
            Money tourBasePPS = DomainModel.TourBasePrices.GetByType(tour.TourType);

            int index = 0;
            if (tourBasePPS != null)
            {
                foreach (TourCostDetail detail in tour.CostDetails)
                {
                    TourReceiptItem item = new TourReceiptItem();
                    Int32 quantity = tour.IsConfirmed ? detail.ParticipantsCount : detail.SignUpCount;

                    item.Index = index;
                    item.ParentIndex = -1;
                    item.PricePerPerson = tourBasePPS;
                    item.Quantity = quantity;
                    item.Description = detail.CostGroup.Name;
                    if (item.Total.Value != 0.0M) tour.Receipt.Items.Add(item);
                    
                    foreach(TourCostRule rule in detail.CostGroup.Rules)
                    {
                        if (this.ruleValidator.Matches(rule, detail, tour))
                        {
                            item = new TourReceiptItem();

                            item.ParentIndex = index;
                            item.Index = ++index;
                            item.Description = rule.Name + " (" + rule.Formula.ToString() + ")";
                            item.Quantity = rule.IsPerPerson ? quantity : 1;
                            item.PricePerPerson = rule.GetTotal(tourBasePPS);
                            if (item.Total.Value != 0.0M) tour.Receipt.Items.Add(item);
                        }
                    }

                    index++;
                }
            }
        }


        public void Register(Entities.Tour tour)
        {
            if (!this.tours.Contains(tour))
            {
                this.tours.Add(tour);
                Attach(tour);
            }
        }


        public void UnRegister(Entities.Tour tour)
        {
            if (this.tours.Contains(tour))
            {
                Detach(tour);
                this.tours.Remove(tour);
            }
        }


        private void Detach(Entities.Tour tour)
        {
            tour.PropertyChanged -= new PropertyChangedEventHandler(tour_PropertyChanged);
        }


        private void Attach(Entities.Tour tour)
        {
            tour.PropertyChanged += new PropertyChangedEventHandler(tour_PropertyChanged);
        }


        void tour_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, "TourType", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "CostDetails", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "Status", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "Payments", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "Time", System.StringComparison.InvariantCulture))
            {
                UpdateReceipt((Entities.Tour)sender);
            }
        }


    }
}
