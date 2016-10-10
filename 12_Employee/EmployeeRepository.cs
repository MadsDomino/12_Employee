using System;

using System.Collections.Generic;

namespace _12_Employee
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> EmployeeList = new List<Employee>();

        private int Id = 1;

        public int CountEmployees()
        {
            return EmployeeList.Count;
        }

        public Employee CreateEmployee(string Name, string Occupation)
        {
            Employee NextEmployee = new Employee();
            NextEmployee.Name = Name;
            NextEmployee.Type = Occupation;
            NextEmployee.Id = Id;
            Id++;

            EmployeeList.Add(NextEmployee);
            return NextEmployee;
        }

        public void Clear()
        {
            EmployeeList.Clear();
        }

        public void SaveEmployee(Employee Employee)
        {

        }

        public Employee LoadEmployee(int Id)
        {
            foreach(var item in EmployeeList)
            {
                if (item.Id == Id)
                    return item;
            }
            return null;
        }

        public List<Employee> FindAllEmployees()
        {
            return EmployeeList;
        }
    }
}