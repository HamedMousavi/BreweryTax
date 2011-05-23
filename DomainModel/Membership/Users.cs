using System;
using Entities;
using System.Transactions;


namespace DomainModel.Membership
{

    public class Users
    {

        private static Entities.Abstract.Repository.IUsers repo;
        private static Entities.Abstract.Repository.IUserSettings settingsRepo;
        private static UserCollection users;


        public static void Init(string sqlCnnStr, CultureCollection cultures)
        {
            repo = new Repository.Sql.Users(sqlCnnStr, cultures);
            settingsRepo = new Repository.Sql.UserSettings(sqlCnnStr);

            users = repo.GetAll();
        }


        public static bool Authenticate(Entities.User user)
        {
            foreach (User item in users)
            {
                if (string.Equals(item.Name, user.Name, StringComparison.InvariantCulture) && 
                    item.Password == user.Password)
                {
                    if (item.IsEnabled)
                    {
                        item.IsAuthenticated = true;
                        DomainModel.Application.User = item;
                        user.Copy(item);
                        //user.IsAuthenticated = true;
                    }

                    break;
                }
            }

            return user.IsAuthenticated;
        }
        

        public static UserCollection GetAll()
        {
            return users;
        }


        public static bool Authorise(string taskName, bool ignoreUserEnabled = false)
        {
            TaskCollection tasks =
                DomainModel.Membership.Tasks.GetByName(taskName);

            if (Application.User == null ||
                tasks == null ||
                tasks.Count <= 0 ||
                Application.User.Role == null) return false;

            if (!ignoreUserEnabled && !Application.User.IsEnabled) return false;

            foreach (Task task in tasks)
            {
                if (Application.User.Role.Tasks.Contains(task))
                {
                    return true;
                }
            }

            return false;
        }

        
        public static bool Save(User user)
        {
            if (user.Id < 0)
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    // Insert new user
                    bool userInserted = repo.Insert(user);

                    // Insert settings for the user
                    bool settingsInserted = settingsRepo.Insert(user);

                    // Complete transaction
                    if (userInserted && settingsInserted)
                    {
                        ts.Complete();

                        users.Add(user);
                        return true;
                    }
                    else
                    {
                        // Do nothing
                        // Transaction will be rolled back.
                    }
                }
            }
            else
            {
                return repo.Update(user);
            }

            return false;
        }


        public static void Delete(User user)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                settingsRepo.Delete(user);
                repo.Delete(user);
                ts.Complete();
                users.Remove(user);
            }
        }
    }
}
