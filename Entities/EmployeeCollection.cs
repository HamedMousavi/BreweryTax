using System;
using System.ComponentModel;


namespace Entities
{

    public class EmployeeCollection : BindingList<Employee>
    {

        public Employee this[string name]
        {
            get
            {
                foreach (Employee emp in this)
                {
                    if (string.Equals(emp.Name, name, StringComparison.InvariantCulture))
                    {
                        return emp;
                    }
                }

                return null;
            }
        }


        internal void CopyTo(EmployeeCollection employees)
        {
            employees.Clear();

            foreach (Employee emp in this)
            {
                employees.Add(emp);
            }
        }
    }
}
