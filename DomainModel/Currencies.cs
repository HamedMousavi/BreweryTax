using Entities;


namespace DomainModel
{

    public class Currencies
    {
        private static MoneyCurrencyCollection cache;


        private static void LoadCache()
        {
            cache = new MoneyCurrencyCollection();

            cache.Add(new MoneyCurrency(0, "EUR", "€"));
            cache.Add(new MoneyCurrency(0, "USD", "$"));
        }


        public static MoneyCurrencyCollection GetAll()
        {
            if (cache == null) LoadCache();
            
            return cache;
        }
    }
}
