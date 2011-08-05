using Entities;


namespace DomainModel
{

    public class Employees
    {

        protected static EmployeeCollection cache;
        

        public static void Init(string sqlCnnStr)
        {
            cache = new EmployeeCollection();
            UserCollection users = Membership.Users.GetAll();

            foreach (User user in users)
            {
                if (user.IsEmployee) cache.Add(new Employee(user));
            }
        }


        public static EmployeeCollection GetAll()
        {
            return cache;
        }


        public static Employee GetByName(string name)
        {
            return cache[name];
        }
    }
}
