using Entities.Abstract;


namespace DomainModel.PaymentStrategies
{

    public class NormalStrategy : ITourPaymentStrategy
    {
        public bool UpdateReceipt(Entities.Tour tour)
        {
            throw new System.NotImplementedException();
        }

        public void Register(Entities.Tour tour)
        {
            throw new System.NotImplementedException();
        }

        public void UnRegister(Entities.Tour tour)
        {
            throw new System.NotImplementedException();
        }
    }
}
