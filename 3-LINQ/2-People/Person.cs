using System;

namespace People
{
    internal class Person : IComparable<Person>
    {
        public string Name { get; }
        public string City { get; }
        public int Age { get; }
        public int Height { get; }
        public bool IsMarried { get; }

        public Person(string name, string city, int age, int height, bool isMarried)
        {
            Name = name;
            City = city;
            Age = age;
            Height = height;
            IsMarried = isMarried;
        }

        public override string ToString()
        {
            string isMarried = this.IsMarried ? "házas" : "nem házas";
            return $"{this.Name}; {this.City}; {this.Age} éves; {this.Height} cm; {isMarried}";
        }

        public int CompareTo(Person other)
        {
            if (this.Age < other.Age) return -1;
            else if (this.Age == other.Age && this.Height < other.Height) return -1;
            else if (this.Age > other.Age) return 1;
            else if (this.Age == other.Age && this.Height > other.Height) return 1;
            return 0;
        }
    }
}
