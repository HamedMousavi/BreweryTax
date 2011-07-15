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
        Service Detail { get; }
        string Name { get; }
        Int32 Id { get; set; }
        TourGroup BaseGroup { get; set; }

        ITourService Clone();
        bool IsDirty { get; set; }
        TourPaymentCollection DeletedPayments { get; set; }
    }
}
