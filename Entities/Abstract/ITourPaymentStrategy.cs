

namespace Entities.Abstract
{

    public interface ITourPaymentStrategy
    {

        bool UpdateReceipt(Entities.Tour tour);

        void Register(Tour tour);

        void UnRegister(Tour tour);
    }
}
