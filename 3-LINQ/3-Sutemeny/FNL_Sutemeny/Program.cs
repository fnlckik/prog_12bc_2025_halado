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
            var a = results.First(x => x.Point == results.Select(y => y.Point).Max()).Name;
            WriteData("A:", a);

            // F2
            var b = results.Where(x => x.Name[0] == '9').Select(x => x.Popularity).Average();
            WriteData("B:", b);

            // F3
            try
            {
                var c = results.First(x => x.Point < 1 && x.Popularity > 40).Name;
                WriteData("C:", c);
            }
            catch (Exception)
            {
                WriteData("C:", "Nincs ilyen.");
            }

            // F4
            try
            {
                var d = results.Where(x => x.Point >= 3.5).OrderBy(x => x.Popularity).First().Name;
                WriteData("D:", d);
            }
            catch (Exception)
            {
                WriteData("D:", "Nincs ilyen osztály!");
            }

            // F5
            var e = results.OrderByDescending(x => x.Popularity).ThenByDescending(x => x.Point).Take(5);
            Write("E:", e);

            // F6
            Console.WriteLine(results.Average(x => x.Point));
            var f = results.Select(x => new { x.Name, Difference = Math.Round(Math.Abs(x.Point - results.Average(y => y.Point)), 2) });
            Write("F:", f);

            // Bonus
            var first = results.First(x => results.Any(y => y != x && y.Popularity == x.Popularity));
            var last = results.First(x => x != first && x.Popularity == first.Popularity);
            var result = new { First = first.Name, Last = last.Name };
            WriteData("XY:", result);
        }
    }
}
