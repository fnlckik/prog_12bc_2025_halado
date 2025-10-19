using System;
using System.Collections.Generic;

namespace Bitzeria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A. Helyben vásárlás
            List<List<int>> vasarlasok = new List<List<int>>
            {
                new List<int> { 4500, 5200, 3899, 4700, 5000, 5699 },
                new List<int> { 6200, 5700, 4800, 5100, 5900 },
                new List<int> { 4999, 5100, 6500, 4200, 5300, 6100, 4700 },
                new List<int> { 5000, 5800, 4620, 5400, 6000, 7199 },
                new List<int> { 4830, 5100, 5600, 6300, 5900 },
                new List<int> { 5300, 4900, 5800, 6100, 7000, 5500, 6400 },
                new List<int> { 4700, 5200, 5900, 6500, 5600, 6100 },
                new List<int> { 5400, 5800, 5000, 6200, 6700 },
                new List<int> { 4910, 5399, 6000, 7200, 5600, 6100, 6600 },
                new List<int> { 5200, 4800, 5400, 5900, 6300, 7000 }
            };

            Console.WriteLine("1. feladat:");


            Console.WriteLine("\n2. feladat:");


            Console.WriteLine("\n3. feladat:");


            // ------------------------------------------
            // BC. Rendelés, Forgalom osztályok
            Console.WriteLine("\n11. feladat:");
            Rendeles r = new Rendeles("Kovacs Bela", true, 8650, "Csípős nélkül kérem a gyrost!");
            //Console.WriteLine(r);
            Forgalom forgalom = new Forgalom("adatok.txt");
            //Console.WriteLine($"Rendelések száma: {forgalom.OrderCount}");
            Rendeles maxRendeles = forgalom.Legdragabb();
            Console.WriteLine("Legdrágább rendelés:");
            Console.WriteLine(maxRendeles);
            forgalom.KupontalanokFajlba();
        }
    }
}
