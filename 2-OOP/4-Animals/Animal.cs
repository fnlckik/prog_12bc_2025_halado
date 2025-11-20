using System;

namespace _4_Animals
{
    internal class Animal
    {
        // static: osztályszintű, nem objektumhoz tartozik
        public string name;
        public int age;
        // protected: leszármazott osztályokban látható
        protected string species;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.species = "Ismeretlen faj";
        }

        public override string ToString()
        {
            return $"{name} {age} éves. Család: {this.species} Osztály: {this.GetType().Name}";
        }

        // virtual: felülírható leszármazott osztályban
        public virtual void MakeSound()
        {
            Console.WriteLine("Általános állat hangok..");
        }
    }
}
