using System.ComponentModel;


namespace Entities
{

    public class ServiceCollection : BindingList<Service>
    {
        public Service GetById(int serviceId)
        {
            foreach (Service service in this)
            {
                if (service.Id == serviceId) return service;
            }

            return null;
        }
    }
}
