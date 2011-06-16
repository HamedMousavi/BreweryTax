using Entities;


namespace DomainModel
{

    public class Categories
    {

        private static CategoryClassCollection classes;
        private static Repository.Sql.Categories categoriesRepo;


        public static void Init(string sqlConnectionString)
        {
            categoriesRepo = new Repository.Sql.Categories(sqlConnectionString);

            BuildCache();
        }


        private static void BuildCache()
        {
            classes = new CategoryClassCollection();
            categoriesRepo.LoadAll(classes);

            foreach (Entities.CategoryClass cat in classes)
            {
                foreach (Culture culture in DomainModel.Cultures.GetAll())
                {
                    GeneralTypeCollection types = Types.GetByName(cat.Name, culture);

                    CategorySub sub = new CategorySub();
                    sub.Language = culture;
                    sub.Types = types;

                    cat.SubCategories.Add(sub);
                }
            }
        }


        public static CategoryClassCollection GetAll()
        {
            return classes;
        }
    }
}
