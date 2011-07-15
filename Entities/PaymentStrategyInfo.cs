using Entities.Abstract;
using System.ComponentModel;

namespace Entities
{
    public class PaymentStrategyInfo : EntityBase
    {
        public Tour Tour { get; set; }
        public TourGroup Group { get; set; }
        public ITourService Service { get; set; }
        public TourCostRule Rule  { get; set; }
        public TourCostDetail CostDetail { get; set; }


        public PaymentStrategyInfo(Tour tour, TourGroup group, ITourService service)
        {
            this.Tour = tour;
            this.Group = group;
            this.Service = service;
        }


        public void Attach()
        {
            Tour.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
            Service.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
            Group.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
        }


        public void Detach()
        {
            Tour.PropertyChanged -= new PropertyChangedEventHandler(OnPropertyChanged);
            Service.PropertyChanged -= new PropertyChangedEventHandler(OnPropertyChanged);
            Group.PropertyChanged -= new PropertyChangedEventHandler(OnPropertyChanged);
        }


        void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RaisePropertyChanged(e.PropertyName);
        }

    }
}
