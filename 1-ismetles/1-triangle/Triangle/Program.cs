using System;
using System.Collections.Generic;

namespace Triangle
{
    internal class Program
    {
        static void F1(Random r)
        {
            Console.WriteLine("1. feladat:");
            int a = r.Next(1, 21);
            int b = r.Next(1, 21);
            int c = r.Next(1, 21);
            Console.WriteLine($"Oldalak: {a} {b} {c}");
            if (a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("Szerkeszthető!");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető!");
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            F1(r);
            F2(r);
        }

        static bool Equals(int x, int y, int z)
        {
            return x * x + y * y == z * z;
        }

        static bool IsPythagorean(int a, int b, int c)
        {
            return Equals(a, b, c) || Equals(b, c, a) || Equals(c, a, b);
        }

        private static void F2(Random r)
        {
            Console.WriteLine("2. feladat:");
            const int N = 10000000;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                int a = r.Next(1, 21);
                int b = r.Next(1, 21);
                int c = r.Next(1, 21);
                //Console.WriteLine($"Oldalak: {a} {b} {c}");
                if (IsPythagorean(a, b, c))
                {
                    count++;
                }
            }
            Console.WriteLine($"Derékszögűek száma: {count}");
            double p = (double)count / N * 100;
            Console.WriteLine($"Derékszögűek aránya: {p}%");
        }
    }
}
