using System;
using System.Collections.Generic;
using System.Linq;

namespace Sutemeny
{
    internal class Program
    {
        private static List<Result> CreateData()
        {
            return new List<Result>()
            {
                new Result("11.a", 45, 4.8),
                new Result("13.b", 31, 3.7),
                new Result("9.b", 38, 4.2),
                new Result("12.b", 25, 2.12),
                new Result("11.c", 34, 4.83),
                new Result("9.c", 40, 2.34),
                new Result("10.b", 45, 4.68),
                new Result("13.c", 42, 3.35),
                new Result("11.b", 48, 4.11),
                new Result("9.a", 40, 2.97),
                new Result("12.a", 46, 0.89),
                new Result("13.k", 25, 1.43),
                new Result("12.c", 45, 1.42),
                new Result("10.c", 12, 0.68),
                new Result("13.a", 34, 3.92),
                new Result("10.a", 45, 2.73)
            };
        }

        private static void Write<T>(string msg, IEnumerable<T> collection)
        {
            Console.WriteLine(msg);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        private static void WriteData<T>(string msg, T element)
        {
            Console.WriteLine(msg + " " + element);
        }

        static void Main(string[] args)
        {
            List<Result> results = CreateData();
            Write("Eredmények:", results);
            Console.WriteLine();

            // F1
            // a = ?
            

            // F2
            

            // F3
            

            // F4
            

            // F5
            

            // F6
            

            // Bonus
        }
    }
}
