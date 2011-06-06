using Entities;


namespace DomainModel
{

    public class Currencies
    {
        private static MoneyCurrencyCollection cache;


        public static void Init(string sqlConnectionString)
        {
            LoadCache();
        }


        private static void LoadCache()
        {
            cache = new MoneyCurrencyCollection();

            cache.Add(new MoneyCurrency(1, "EUR", "€"));
            cache.Add(new MoneyCurrency(2, "USD", "$"));
        }


        public static MoneyCurrencyCollection GetAll()
        {
            return cache;
        }


        internal static MoneyCurrency GetById(int currencyId)
        {
            return cache.GetById(currencyId);
        }
    }
}
