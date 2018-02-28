using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_使用this调用自己的构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Person
    {
        private string _name;
        private int _age;
        private string _email;
        private double _height;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Email { get => _email; set => _email = value; }
        public double Height { get => _height; set => _height = value; }

        public Person()
        {
        }

        public Person(string name, int age, string email, double height)
        {
            Name = name;
            Age = age;
            Email = email;
            Height = height;
            
        }

        //调用本类中的构造函数
        public Person(string name,int age) : this(name, age, null, 0)
        {

        }
        public Person(int age,double height) : this(string.Empty, age, null, height)
        {

        }
        
    }
}
