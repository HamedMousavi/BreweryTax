using System;
using System.ComponentModel;


namespace Entities
{

    public class TaskCollection : BindingList<Task>
    {

        public  TaskCollection this[string name]
        {
            get
            {
                TaskCollection res = new TaskCollection();

                foreach (Task task in this)
                {
                    if (task.Name.Equals(name, StringComparison.InvariantCulture))
                    {
                        res.Add(task);
                    }
                }

                return res;
            }
        }


        public  void Copy(TaskCollection taskCollection)
        {
            foreach (Task task in taskCollection)
            {
                if (!this.Contains(task))
                {
                    this.Add(task);
                }
            }
        }


        public  Task FindById(Int32 taskId)
        {
            foreach (Task task in this)
            {
                if (task.Id == taskId)
                {
                    return task;
                }
            }

            return null;
        }
    }
}
