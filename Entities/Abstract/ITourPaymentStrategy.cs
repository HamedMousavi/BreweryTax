

namespace Entities.Abstract
{

    public interface ITourPaymentStrategy
    {

        bool UpdateReceipt(ITourService tour);

        void Register(ITourService tour);

        void UnRegister(ITourService tour);
    }
}
