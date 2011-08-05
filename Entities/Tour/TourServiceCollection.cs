using System.ComponentModel;
using Entities.Abstract;
using System;


namespace Entities
{

    public class TourServiceCollection : BindingList<ITourService>
    {

        internal void CopyTo(TourServiceCollection services)
        {
            services.Clear();

            foreach (ITourService service in this)
            {
                services.Add(service.Clone());
            }
        }


        public int ClientCount
        {
            get
            {
                Int32 sum = 0;

                foreach (ITourService service in this)
                {
                    sum += service.ClientCount;
                }

                return sum;
            }
        }


        internal int GetClientCountExcept(GeneralType serviceType)
        {
            Int32 sum = 0;

            foreach (ITourService service in this)
            {
                if (service.Detail.ServiceType.Id != serviceType.Id)
                {
                    sum += service.ClientCount;
                }
            }

            return sum;
        }
    }
}
