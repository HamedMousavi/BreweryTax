

namespace Entities.Abstract
{

    public interface ITourPaymentStrategy
    {
        PaymentStrategyInfo StrategyInfo { get; set; }

        bool UpdateReceipt();

        void Register();

        void UnRegister();
    }
}
