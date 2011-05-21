using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract.Repository
{
    public interface IRole
    {
        RoleCollection GetAll();

        bool AddTaskToRole(Role role, Task task);
        bool RemoveTaskFromRole(Role role, Task task);
        void LoadTasks(RoleCollection cache);
        bool Insert(Role role);
        bool Update(Role role);
        bool Delete(Role role);
    }
}
