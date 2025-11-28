using System;

namespace _4_Animals
{
    // abstract osztály: lehet benne abstract metódus
    internal abstract class Animal : IComparable<Animal>
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
        //public virtual void MakeSound()
        //{
        //    Console.WriteLine("Általános állat hangok..");
        //}

        // abstract metódus: csak egy fejléc, nincs implementáció (törzs)
        // Fontos! Abstract metódus csak abstract osztályban lehet!
        public abstract void MakeSound();

        public int CompareTo(object obj)
        {
            if (!(obj is Animal))
            {
                throw new ArgumentException("Nem állat a hasonlítandó.");
            }
            Animal other = obj as Animal;
            // ...
            throw new NotImplementedException();
        }

        // +: this > other (1)
        // -: this < other (-1)
        // 0: this == other
        public int CompareTo(Animal other)
        {
            //if (this.age > other.age) return 1;
            //if (this.age < other.age) return -1;
            //return 0;
            //return (-1)*(this.age - other.age);
            throw new NotImplementedException();
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{this.name} alszik.");
        }
    }
}
