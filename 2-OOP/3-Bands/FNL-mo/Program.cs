using System;

namespace Bands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Band osztály
            Band csharpers = new Band("Éleslátók", "pop");
            //csharpers.Name = "Él";
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
            Console.WriteLine();

            //Console.Clear();

            // --------------------------
            //try
            //{
            //    Console.WriteLine(manager[1]); // Republic: 5
            //    Console.WriteLine(manager[2]); // Quimby: 4
            //    Console.WriteLine(manager[120]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.WriteLine(manager[1] < manager[2]); // false
        }
    }
}
