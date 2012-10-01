using Entities;


namespace DomainModel
{

    public static class MailEventTypes
    {

        private static Repository.Sql.Types _repo;
        private static GeneralTypeCollection _cache;


        public static void Init(string sqlConnectionString, Entities.Culture culture)
        {
            _repo = new Repository.Sql.Types(sqlConnectionString);

            LoadAll(culture);
        }


        private static void LoadAll(Culture culture)
        {
            _cache = _repo.GetByName("MailEventTypes", culture.Id);
        }


        public static GeneralTypeCollection GetAll()
        {
            return _cache;
        }


        internal static GeneralType GetById(int tourTypeId)
        {
            return _cache.GetById(tourTypeId);
        }
    }
}
