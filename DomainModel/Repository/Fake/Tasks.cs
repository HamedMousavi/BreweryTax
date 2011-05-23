using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract.Repository;
using Entities;


namespace DomainModel.Repository.Fake
{

    public class Tasks : ITask
    {
        protected TaskCollection tasks;

        public Entities.TaskCollection GetAll()
        {
            if (tasks == null)
            {
                tasks = new TaskCollection();

                Task task;
                task = new Task();
                task.Id = 1;
                task.Name = "User management";
                tasks.Add(task);

                task = new Task();
                task.Id = 2;
                task.Name = "Role management";
                tasks.Add(task);

                task = new Task();
                task.Id = 3;
                task.Name = "View daily tours";
                tasks.Add(task);

                task = new Task();
                task.Id = 4;
                task.Name = "View staff presence";
                tasks.Add(task);
            }

            return tasks;
        }
    }
}
