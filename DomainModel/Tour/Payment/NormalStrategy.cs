using System;
using System.ComponentModel;
using Entities;
using Entities.Abstract;


namespace DomainModel.PaymentStrategies
{

    public class NormalStrategy : ITourPaymentStrategy
    {

        public PaymentStrategyInfo StrategyInfo { get; set; }
        private PaymentStrategyInfoCollection services;
        private PaymentRuleValidator ruleValidator;


        public NormalStrategy(PaymentStrategyInfo info)
        {
            this.StrategyInfo = info;
            this.services = new PaymentStrategyInfoCollection();
            this.ruleValidator = new PaymentRuleValidator();
        }


        public bool UpdateReceipt()
        {
            bool res = true;

            // Prevent event firing again while changing list
            Detach();

            try
            {

                // Clear old items
                int count = this.StrategyInfo.Service.Bill.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    TourReceiptItem item = this.StrategyInfo.Service.Bill.Items[0];

                    if (!item.IsCustom)
                    {
                        res = this.StrategyInfo.Service.Bill.Delete(item);
                        if (!res) break;
                    }
                }

                // recalculate
                if (res)
                {
                    CreateReceipt();
                }

                CalculateTotal();
            }
            catch (Exception ex)
            {
            }

            // attach back to tour
            Attach();

            return res;
        }


        private void CalculateTotal()
        {
            this.StrategyInfo.Service.Bill.Total.Value = 0.00M;

            foreach (TourReceiptItem item in this.StrategyInfo.Service.Bill.Items)
            {
                this.StrategyInfo.Service.Bill.Total.Value += item.Total.Value;
                if (this.StrategyInfo.Service.Bill.Total.Currency == null)
                {
                    this.StrategyInfo.Service.Bill.Total.Currency = item.Total.Currency;
                }
            }
        }


        private void CreateReceipt()
        {
            Money tourBasePPS = this.StrategyInfo.Service.Detail.PricePerPerson;

            int index = 0;
            if (tourBasePPS != null)
            {
                foreach (TourCostDetail detail in this.StrategyInfo.Service.CostDetails)
                {
                    this.StrategyInfo.CostDetail = detail;
                    TourReceiptItem item = new TourReceiptItem();
                    Int32 quantity = detail.Count;

                    item.Index = index;
                    item.ParentIndex = -1;
                    item.PricePerPerson = tourBasePPS;
                    item.Quantity = quantity;
                    item.Description = detail.CostGroup.Name;
                    if (item.Total.Value != 0.0M) this.StrategyInfo.Service.Bill.Items.Add(item);
                    
                    foreach(TourCostRule rule in detail.CostGroup.Rules)
                    {
                        this.StrategyInfo.Rule = rule;
                        if (this.ruleValidator.Matches(this.StrategyInfo))
                        {
                            item = new TourReceiptItem();

                            item.ParentIndex = index;
                            item.Index = ++index;
                            item.Description = rule.Name + " (" + rule.Formula.ToString() + ")";
                            item.Quantity = rule.IsPerPerson ? quantity : 1;
                            item.PricePerPerson = rule.GetTotal(tourBasePPS);
                            if (item.Total.Value != 0.0M) this.StrategyInfo.Service.Bill.Items.Add(item);
                        }
                    }

                    index++;
                }
            }
        }


        public void Register()
        {
            if (!this.services.Contains(this.StrategyInfo))
            {
                this.services.Add(this.StrategyInfo);
                Attach();
            }
        }


        public void UnRegister()
        {
            if (this.services.Contains(this.StrategyInfo))
            {
                Detach();

                this.services.Remove(this.StrategyInfo);
            }
        }


        private void Attach()
        {
            this.StrategyInfo.Attach();
            this.StrategyInfo.PropertyChanged += new
                PropertyChangedEventHandler(info_PropertyChanged);
        }


        private void Detach()
        {
            this.StrategyInfo.Detach();
            this.StrategyInfo.PropertyChanged -= new
                PropertyChangedEventHandler(info_PropertyChanged);
        }


        void info_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateReceipt();
        }
    }
}
