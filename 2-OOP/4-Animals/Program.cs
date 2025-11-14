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

            // ToString()
            Console.WriteLine("---------- ToString() ----------");
            Console.WriteLine(dumbo);
            Console.WriteLine(ubul);
            Console.WriteLine(scooby);
            Console.WriteLine();

            // MakeSound()
            Console.WriteLine("---------- MakeSound() ----------");
            dumbo.MakeSound();
            ubul.MakeSound();
            scooby.MakeSound();
        }
    }
}
