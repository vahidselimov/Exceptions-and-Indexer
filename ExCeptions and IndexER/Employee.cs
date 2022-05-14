using System;
using System.Collections.Generic;
using System.Text;

namespace ExCeptions_and_IndexER
{
    internal class Employee:IPersonable
    {
        private static int _id;
        public int Id { get; }
       
        public double Salary{ get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        public override string ToString()
        {
            return Showinfo();
        }
        public string Showinfo()
        {
            return Name + Age + Salary;
        }
        public Employee(string name,int age,double salary)
        {
            Id = +_id;
            Name = name;
            Age = age;
            Salary = salary;

        }

        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
