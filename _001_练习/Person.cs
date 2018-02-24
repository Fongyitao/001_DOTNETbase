using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_练习
{
    class Person
    {
        private string _name;
        private int _age;
        private string _gender;

        public string Name { get => _name; set => _name = value; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 200)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        public string Gender { get => _gender; set => _gender = value; }

        public Person()
        {
        }

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("Hi,my name is {0},I'm {1} years old,I'm a {2}.", Name, Age, Gender);
        }
    }
}
