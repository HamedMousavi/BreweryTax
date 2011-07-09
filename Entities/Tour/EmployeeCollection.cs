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


        public void UndoDelete(EmployeeCollection originalList)
        {
            foreach (Employee emp in this)
            {
                originalList.Add(emp);
            }

            this.Clear();
        }


        public new bool Contains(Employee employee)
        {
            foreach (Employee emp in this)
            {
                if (emp.User == employee.User)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
