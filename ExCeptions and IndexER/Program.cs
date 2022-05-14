using System;

namespace ExCeptions_and_IndexER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Vahid", 20, 2000);
            Employee employee1 = new Employee("Fazil", 21, 3000);
            Department department = new Department("AP204", 2);
            department.AddEmployee(employee);
            department.AddEmployee(employee1);
            foreach (var item in department.employees)
            {
                Console.WriteLine(item.Showinfo());
            }
            Console.WriteLine(department[2]);
           
        }
    }
}
