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

    // A Dog örököl az Animal osztálytól.
    // A Dog implementálja az ITrickPerformer interface-t.
    internal class Dog : Animal, ITrickPerformer
    {
        public string breed; // fajta

        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
            this.species = "Emlős";
        }

        // Fontos! Abtract osztály leszármazottjának
        // minden abstract metódust override-olni kell!
        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: Vau!");
        }

        public override string ToString()
        {
            return base.ToString() + $" ({this.breed}) ";
        }

        public void GivePaw()
        {
            Console.WriteLine($"{this.name} pacsit adott.");
        }

        public void PerformTrick()
        {
            Console.WriteLine($"{this.name} visszahozza a botot.");
        }
    }
}
