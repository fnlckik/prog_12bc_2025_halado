using System;
using System.Collections.Generic;

namespace _4_Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Példányosítások
            Animal dumbo = new Animal("Dumbo", 70);
            Dog ubul = new Dog("Ubul", 7, "beagle");
            Animal scooby = new Dog("Scooby", 12, "dán dog");
            //Dog xy = new Animal("xy", 2);
            Cat sanyi = new Cat("Sanyi", 8, "fekete");
            Bird rico = new Bird("Rico", 5, false, "Bumm"); // pingvin
            Duck donald = new Duck("Donald", 7);
            Parrot jago = new Parrot("Jago", 8, "AAAAAA", "piros");
            List<Animal> animals = new List<Animal> 
            { 
                dumbo, ubul, scooby, sanyi, rico, donald, jago
            };

            // ToString()
            Console.WriteLine("---------- ToString() ----------");
            //Console.WriteLine(dumbo);
            //Console.WriteLine(ubul);
            //Console.WriteLine(scooby);
            //Console.WriteLine(sanyi);
            //Console.WriteLine(rico);
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();

            // MakeSound()
            Console.WriteLine("---------- MakeSound() ----------");
            //dumbo.MakeSound();
            //ubul.MakeSound();
            //scooby.MakeSound();
            //sanyi.MakeSound();
            //rico.MakeSound();
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
            Console.WriteLine();

            // GivePaw()
            Console.WriteLine("---------- GivePaw() ----------");
            //ubul.GivePaw();
            //Dog dog = scooby as Dog;
            //dog.GivePaw();
            foreach (Animal animal in animals)
            {
                //Dog dog = animal as Dog;
                //dog?.GivePaw();
                Console.WriteLine(animal is Dog);
            }
            Console.WriteLine();

            // GivePaw()
            ubul.species = "Hüllő";
            Console.WriteLine(ubul.species);
            //Console.WriteLine("---------- GivePaw() ----------");
            //Console.Write("Beszélj a papagájhoz: ");
            //string text = Console.ReadLine();
            //jago.Repeat(text);
        }
    }
}
