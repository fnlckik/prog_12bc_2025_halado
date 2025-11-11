using System;

namespace Bands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Band osztály
            Band csharpers = new Band("Éleslátók", "pop");
            Console.WriteLine(csharpers);
            Console.WriteLine();

            // Manager osztály
            Manager manager = new Manager("Farkas Norbert");
            manager.LoadFromFile("bands.txt");
            Band oldest = manager.OldestBand();
            Console.WriteLine($"Legrégebbi zenekar: {oldest}");
            Console.WriteLine();

            manager.OrderByMembersCount();
            manager.InstrumentFrequency();
        }
    }
}
