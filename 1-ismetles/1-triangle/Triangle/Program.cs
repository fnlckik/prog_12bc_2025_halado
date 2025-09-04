using System;
using System.Collections.Generic;

namespace Triangle
{
    internal class Program
    {
        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && c + a > b;
        }

        static void F1(Random r)
        {
            Console.WriteLine("1. feladat:");
            int a = r.Next(1, 21);
            int b = r.Next(1, 21);
            int c = r.Next(1, 21);
            Console.WriteLine($"Oldalak: {a} {b} {c}");
            if (IsTriangle(a, b, c))
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
            double area = Area(3, 4, 5); // 6
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"Terület: {area}");
            Console.WriteLine($"Terület: {Area(1, 2, 3)}");
            Console.WriteLine($"Terület: {Area(1, 2, 5)}");

            Console.WriteLine($"Legnagyobb szög: {LargestAngle(3, 4, 5)}");
            Console.WriteLine($"Legnagyobb szög: {LargestAngle(4, 5, 3)}");
            Console.WriteLine($"Legnagyobb szög: {LargestAngle(3, 13, 12)}");
        }

        private static double LargestAngle(double a, double b, double c)
        {
            if (a > c) (a, c) = (c, a);
            if (b > c) (b, c) = (c, b);
            // Tfh a legnagyobb c.
            double angle = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
            return angle / Math.PI * 180;
        }

        private static double Area(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c)) return double.NaN; // early return
            double s = (a + b + c) / 2;
            //return Math.Pow(s*(s-a)*(s-b)*(s-c), 1/2d);
            // Jó lenne jelezni, ha a gyökvonás nem értelmes!
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
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
