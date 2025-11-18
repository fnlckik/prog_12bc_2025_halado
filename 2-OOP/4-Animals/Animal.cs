using System;

namespace _4_Animals
{
    internal class Animal
    {
        public string name;
        public int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} {age} éves. Osztály: {this.GetType().Name}";
        }

        // virtual: felülírható leszármazott osztályban
        public virtual void MakeSound()
        {
            Console.WriteLine("Általános állat hangok..");
        }
    }
}
