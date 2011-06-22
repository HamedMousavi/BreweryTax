using Entities;


namespace DomainModel
{

    public class TourBasePrices
    {
        private static TourBasePriceCollection prices;
        private static Repository.Sql.TourBasePrice repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.TourBasePrice(sqlConnectionString);

            LoadCultures();
        }


        private static void LoadCultures()
        {
            prices = new TourBasePriceCollection();
            repo.Load(prices);
        }


        public static TourBasePriceCollection GetAll()
        {
            return prices;
        }


        public static bool Save(int priceId, Money money)
        {
            return repo.Update(priceId, money);
        }


        internal static Money GetByType(GeneralType tourType)
        {
            foreach (TourBasePrice price in prices)
            {
                if (price.TourType.Id == tourType.Id)
                {
                    return price.PricePerPerson;
                }
            }

            return null;
        }
    }
}
