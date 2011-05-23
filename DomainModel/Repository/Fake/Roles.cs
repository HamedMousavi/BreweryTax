using System;
using Entities.Abstract.Repository;
using Entities;


namespace DomainModel.Repository.Fake
{

    public class Roles : IRole
    {

        public Entities.RoleCollection GetAll()
        {
            RoleCollection roles = new Entities.RoleCollection();
            Role role = new Role();
            role.Id = 1;
            role.Name = "Administrator";
            role.Priority = 1;

            roles.Add(role);

            return roles;
        }

        public bool AddTaskToRole(Entities.Role role, Entities.Task task)
        {
            return true;
        }

        public bool RemoveTaskFromRole(Entities.Role role, Entities.Task task)
        {
            return true;
        }

        public void LoadTasks(Entities.RoleCollection roles)
        {/*
            role.Tasks = new TaskCollection();

            foreach (Role role in roles)
            {
                foreach (Task task in Membership.Tasks.GetAll())
                {
                    if (
                }

                role.Tasks.Add(task);
            }

            for (int i = 1; i < 5; i++)
            {

            }

            Task task;
            task = new Task();
            task.Id = 1;
            task.Name = "User management";
            role.Tasks.Add(task);

            task = new Task();
            task.Id = 2;
            task.Name = "Role management";
            role.Tasks.Add(task);

            task = new Task();
            task.Id = 3;
            task.Name = "View daily tours";
            role.Tasks.Add(task);

            task = new Task();
            task.Id = 4;
            task.Name = "View staff presence";
            role.Tasks.Add(task);*/
        }

        public bool Insert(Entities.Role role)
        {
            return true;
        }

        public bool Update(Entities.Role role)
        {
            return true;
        }

        public bool Delete(Entities.Role role)
        {
            return true;
        }
    }
}
