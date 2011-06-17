using System.ComponentModel;

namespace Entities
{
    public class Employee : EntityBase
    {

        public string Name { get { return this.user.Name; } }


        [BrowsableAttribute(false)]
        public User User { get { return this.user; } }
        private User user;
        
        
        public Employee(User user)
        {
            this.user = user;
        }


        public Employee(Employee emp)
        {
            this.user = emp.user;
        }
    }
}
