using System;
using Entities;

namespace DomainModel.Membership
{
    public class Roles
    {

        private static Entities.Abstract.Repository.IRole repo;
        private static RoleCollection cache;


        public static void Init(string sqlCnnStr)
        {
            repo = new Repository.Sql.Roles(sqlCnnStr);

            cache = repo.GetAll();
            repo.LoadTasks(cache);

        }


        internal static Role GetById(Int32 aclId)
        {
            return cache.FindById(aclId);
        }


        public static RoleCollection GetAll()
        {
            return cache;
        }


        public static bool AddTaskToRole(Role role, Task task)
        {
            return repo.AddTaskToRole(role, task);
        }


        public static bool RemoveTaskFromRole(Role role, Task task)
        {
            return repo.RemoveTaskFromRole(role, task);
        }


        public static bool Delete(Role role)
        {
            if (repo.Delete(role))
            {
                cache.Remove(role);
                return true;
            }

            return false;
        }


        public static bool Save(Role role)
        {
            if (role.Id < 0)
            {
                // Complete transaction
                if (repo.Insert(role))
                {
                    cache.Add(role);
                    return true;
                }
                else
                {
                    // Do nothing
                    // Transaction will be rolled back.
                }

            }
            else
            {
                return repo.Update(role);
            }

            return false;
        }
    }
}
