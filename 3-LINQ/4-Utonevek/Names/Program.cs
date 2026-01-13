using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Names
{
    internal class Program
    {
        static List<Name> Seed()
        {
            return new List<Name>
            {
                new Name("Ádám", 43373, 5339, true),
                new Name("Adrián", 4984, 900, true),
                new Name("Adrienn", 27817, 1954, false),
                new Name("Ágnes", 96914, 14521, false),
                new Name("Ákos", 21889, 3421, true),
                new Name("Alex", 6652, 1389, true),
                new Name("Alexandra", 30416, 3250, false),
                new Name("András", 106266, 18045, true),
                new Name("Andrea", 90905, 8569, false),
                new Name("Anett", 15693, 1418, false),
                new Name("Anita", 49989, 3520, false),
                new Name("Anna", 159383, 28782, false),
                new Name("Annamária", 19160, 1524, false),
                new Name("Antal", 38843, 8899, true),
                new Name("Árpád", 25584, 5197, true),
                new Name("Attila", 140992, 23705, true),
                new Name("Balázs", 60175, 7397, true),
                new Name("Béla", 69931, 12371, true),
                new Name("Bence", 28682, 4557, true),
                new Name("Bernadett", 25246, 2842, false),
                new Name("Csaba", 88938, 15563, true),
                new Name("Csilla", 31577, 5365, false),
                new Name("Dávid", 46252, 6467, true),
                new Name("Dóra", 31528, 3713, false),
                new Name("Eszter", 64441, 10925, false),
                new Name("Éva", 187157, 29711, false),
                new Name("Ferenc", 192402, 29757, true),
                new Name("Gábor", 164742, 23276, true),
                new Name("István", 338851, 55192, true),
                new Name("János", 272467, 43773, true),
                new Name("József", 316996, 52822, true),
                new Name("Zsófia", 31838, 5907, false),
                new Name("Zsuzsanna", 146160, 23478, false)
            };
        }

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            List<Name> names = Seed();
            Print("Adatok:", names);

            Console.Clear();

            // F1 - 2 pont
            // lambda expression
            var a = names.Any(x => x.Last > x.First);
            Console.WriteLine("A: " + a);

            // F2 - 3 pont
            var b = names.Where(x => x.IsMale && x.NameText[0] == 'B').Select(x => x.NameText);
            Print("B: ", b);

            // F3 - 3 pont
            var c = names.Where(x => !x.IsMale).OrderByDescending(x => x.First).Take(5);
            Print("C: ", c);

            // F4 - 2 pont
            //var d = names.OrderByDescending(x => x.First + x.Last).First();
            //Console.WriteLine("D: " + (d.First + d.Last));
            //var d = names.Select(x => x.First + x.Last).Max();
            var d = names.Max(x => x.First + x.Last);
            Console.WriteLine("D: " + d);

            // F5 - 2 pont
            var e = Math.Round(names.Average(x => x.NameText.Length), 2);
            Console.WriteLine("E: " + e);


            // F6 - 3 pont
            /*
             * SELECT NameText, (First + Last) AS Freq
             * FROM names
             * */
            var f = names.Where(x => x.NameText.Length < 5).Select(x => new { x.NameText, Freq = x.First + x.Last });
            Print("F: ", f);


            // F7 - 4 pont
            var g = names.Last(x => !x.IsMale).NameText.ToLower().Distinct().Count();
            Console.WriteLine("G: " + g);
        }
    }
}
