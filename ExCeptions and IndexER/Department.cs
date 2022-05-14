using System;
using System.Collections.Generic;
using System.Text;

namespace ExCeptions_and_IndexER
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public Employee[] employees = new Employee[0];

        public Department(string name, int employeelimit)
        {
            Name = name;
            EmployeeLimit = employeelimit;

        }
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
            if (employees.Length<EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
                
            }
            else
            {
                throw new CapacityLimitException("Capacity kecdiniz");
            }
            
        }
        public Department()
        {
            employees = new Employee[0];
        }
        public Employee this[int Index]
        {
            get
            {
                return employees[Index];
            }
            set
            {
               employees[Index] = value;
            }
        }
    }
    

	
}

