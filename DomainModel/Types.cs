using Entities;


namespace DomainModel
{

    public class Types
    {

        private static Repository.Sql.Types repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.Types(sqlConnectionString);
        }


        public static GeneralTypeCollection GetByName(string typeName, Culture culture)
        {
            return repo.GetByName(typeName, culture.Id);
        }
    }
}
