using System;

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

            // ToString()
            Console.WriteLine("---------- ToString() ----------");
            Console.WriteLine(dumbo);
            Console.WriteLine(ubul);
            Console.WriteLine(scooby);
            Console.WriteLine(sanyi);
            Console.WriteLine(rico);
            Console.WriteLine();

            // MakeSound()
            Console.WriteLine("---------- MakeSound() ----------");
            dumbo.MakeSound();
            ubul.MakeSound();
            scooby.MakeSound();
            sanyi.MakeSound();
            rico.MakeSound();
        }
    }
}
