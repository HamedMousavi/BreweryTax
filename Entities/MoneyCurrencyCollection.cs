using System.ComponentModel;


namespace Entities
{

    public class MoneyCurrencyCollection : BindingList<MoneyCurrency>
    {
        public MoneyCurrency GetById(int id)
        {
            foreach (MoneyCurrency money in this)
            {
                if (money.Id == id)
                {
                    return money;
                }
            }

            return null;
        }
    }
}
