using System;
using System.ComponentModel;


namespace Entities
{

    public class UserCollection : BindingList<User>
    {

        public User this[string name]
        {
            get
            {
                foreach (User user in this)
                {
                    if (string.Equals(user.Name, name, StringComparison.InvariantCulture))
                    {
                        return user;
                    }
                }

                return null;
            }
        }


        public User GetById(int id)
        {
            foreach (User user in this)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null;
        }


        public bool IsAccessLevelInUse(Role acl)
        {
            foreach (User user in this)
            {
                if (user.Role == acl)
                {
                    return true;
                }
            }

            return false;
        }


        public bool IdExists(User newUser)
        {
            foreach (User user in this)
            {
                if (user.Id == newUser.Id && user != newUser)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
