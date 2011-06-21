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


        public static bool Update(CategorySub sub, GeneralType type, string name)
        {
            return repo.Update(sub.Language.Id, type.Id, name);
        }


        public static bool Insert(CategoryClass category, CategorySub sub, GeneralType type)
        {
            return repo.Insert(category.Id, sub.Language.Id, type);
        }


        public static bool DeleteById(int typeId)
        {
            return repo.DeleteById(typeId);
        }
    }
}
