using System;


namespace Entities
{

    public class Role
    {
        public string Name { get; set; }
        public Int32 Id { get; set; }
        public Int32 Priority { get; set; }
        public TaskCollection Tasks { get; set; }


        public Role()
        {
            this.Id = -1;
            this.Tasks = new TaskCollection();
        }

        
        public void Copy(Role role)
        {
            this.Priority = role.Priority;
            this.Name = role.Name;
            this.Id = role.Id;

            this.Tasks.Copy(role.Tasks);
        }
    }
}
