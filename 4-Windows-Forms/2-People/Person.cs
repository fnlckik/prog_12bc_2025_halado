using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_People
{
    internal class Person
    {
        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Salary = Program.r.Next(200, 501) * 1000;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }
}
