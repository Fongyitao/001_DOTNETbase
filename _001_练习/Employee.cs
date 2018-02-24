using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_练习
{
    class Employee : Person
    {
        private decimal _salary;

        public decimal Salary { get => _salary; set => _salary = value; }

        public Employee(string name, int age, string gender, decimal salary) : base(name, age, gender)
        {
            Salary = salary;
        }

        public override void SayHi()
        {
            Console.WriteLine("Hi,my name is {0},I'm {1} years old,I'm a {2},my salary is {3}.", Name, Age, Gender, Salary);
        }
    }
}
