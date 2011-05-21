using System;

namespace Entities
{
    public class Task
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }


        public Task()
        {
        }


        public Task(Int32 id, string name)
        {
            this.Id = id;
            this.Name = name;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
