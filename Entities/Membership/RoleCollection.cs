using System;
using System.ComponentModel;

namespace Entities
{
    public class RoleCollection : BindingList<Role>
    {
        public Role this[string name]
        {
            get
            {
                foreach (Role role in this)
                {
                    if (role.Name.Equals(name, StringComparison.InvariantCulture))
                    {
                        return role;
                    }
                }

                return null;
            }
        }


        public Role FindById(int roleId)
        {
            foreach (Role role in this)
            {
                if (role.Id == roleId)
                {
                    return role;
                }
            }

            return null;
        }


        public void Sort()
        {
            Role temp;
            Int32 count = this.Count;

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (this[i].Priority > this[j].Priority)
                    {
                        temp = this[i];
                        this[i] = this[j];
                        this[j] = temp;
                    }
                }
            }
        }


        public Role FindByPriority(int priority)
        {
            foreach (Role role in this)
            {
                if (role.Priority == priority)
                {
                    return role;
                }
            }

            return null;
        }
    }
}
