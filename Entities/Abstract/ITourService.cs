using System;
using System.ComponentModel;


namespace Entities.Abstract
{

    public interface ITourService : INotifyPropertyChanged
    {

        Int32 ClientCount { get; }
        TourCostDetailCollection CostDetails { get; set; }
        TourPaymentCollection Payments { get; set; }
        TourReceipt Bill { get; }
        GeneralType Type { get; }
        string Name { get; }

        ITourService Clone();
    }
}
