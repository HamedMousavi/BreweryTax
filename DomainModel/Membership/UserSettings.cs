

namespace DomainModel.Membership
{

    public static class UserSettings
    {
        private static Entities.Abstract.Repository.IUserSettings repo;


        public static void Init(string sqlCnnStr)
        {
            repo = new Repository.Sql.UserSettings(sqlCnnStr);
        }


        public static void Save(Entities.User user)
        {
            repo.Save(user);
        }


        internal static void LoadById(Entities.User user)
        {
            repo.LoadByUserId(user);
        }
    }
}
