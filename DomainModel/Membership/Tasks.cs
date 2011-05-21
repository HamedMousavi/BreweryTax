using System;
using Entities;

namespace DomainModel.Membership
{
    public class Tasks
    {

        private static Entities.Abstract.Repository.ITask repo;
        private static TaskCollection cache;


        public static void Init(string sqlCnnStr)
        {
            repo = new Repository.Sql.Tasks(sqlCnnStr);

            cache = repo.GetAll();
        }


        public static TaskCollection GetAll()
        {
            return cache;
        }


        public static Task GetById(Int32 roleId)
        {
            return cache.FindById(roleId);
        }


        public static TaskCollection GetByName(string roleName)
        {
            return cache[roleName];
        }
    }
}
