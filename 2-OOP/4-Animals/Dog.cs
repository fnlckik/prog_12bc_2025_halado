using System;

namespace _4_Animals
{
    // Inheritance: öröklődés
    // Dog: leszármazott (derived class)
    // Animal: ősosztály (base class)

    // Az öröklődés olyan OOP technika,
    // amely során a leszármazott osztály örökli 
    // az ősosztály adattagjait, metódusait.

    // A leszármazott osztálynak kötelező meghívni
    // az ősosztály konstruktorát.
    internal class Dog : Animal
    {
        public string breed; // fajta

        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: Vau!");
        }

        public override string ToString()
        {
            return base.ToString() + $" ({this.breed}) ";
        }
    }
}
