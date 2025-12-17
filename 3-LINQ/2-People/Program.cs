using System;
using System.Collections.Generic;
using System.Linq;

namespace People
{
    internal class Program
    {
        static List<Person> Generate()
        {
            return new List<Person>
            {
                new Person("Kiss Anna", "Budapest", 28, 165, false), // => { Name = "Kiss Anna", Age = 28 }
                new Person("Lakatos Géza", "Miskolc", 34, 182, true),
                new Person("Szabó Lilla", "Szeged", 33, 170, false),
                new Person("Tóth László", "Kecskemét", 41, 179, true),
                new Person("Varga Dóra", "Pécs", 29, 160, true),
                new Person("Horváth István", "Miskolc", 33, 188, true),
                new Person("Molnár Júlia", "Budapest", 25, 167, true),
                new Person("Balogh Máté", "Szeged", 33, 181, true),
                new Person("Papp Tamás", "Miskolc", 45, 176, true),
                new Person("Takács Nóra", "Kecskemét", 28, 169, false),
                new Person("Juhász Edit", "Budapest", 38, 158, true),
                new Person("Veres András", "Miskolc", 26, 183, false)
            };
        }

        static void Write<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<Person> people = Generate();
            Write("Adatok", people);

            // ---------------------------------------
            // F1 - WHERE
            IEnumerable<Person> budapestiek = people.Where(x => x.City == "Budapest");
            Write("1. Budapestiek: ", budapestiek);

            // F2 - SELECT
            // anonymous type
            // var: a fordító ki tudja találni a típusát
            IEnumerable<string> names = people.Select(x => x.Name);
            Write("2. Nevek: ", names);
            var namesAges = people.Select(x => new { Name = x.Name, Age = x.Age });
            Write("2. Nevek, életkorok: ", namesAges);

            // F3 - ORDER BY
            // TKey: meg van valósítva az IComparable interfész
            Write("3. Életkor szerint növekvő sorrend: ", people.OrderBy(x => x.Age));
            //var ageHeightOrder = people.OrderBy(x => x);
            var ageHeightOrder = people.OrderBy(x => x.Age).ThenBy(x => x.Height);
            Write("3. Életkor, magasság szerint növekvő sorrend: ", ageHeightOrder);

            // F4 - LIMIT
            // .Skip(), .Reverse()
            Write("4. Legidősebb 5 fő: ", people.OrderByDescending(x => x.Age).Take(5));

            // ---------------------------------------
            Console.Clear();
            Console.WriteLine("Feladatok: ");
            Console.WriteLine();

            // 1.Add meg a 30 év alatti házasokat!
            var youngMarried = people.Where(x => x.Age < 30 && x.IsMarried);
            Write("1. Fiatal házasok: ", youngMarried);

            // 2. Mennyi a házasok átlagéletkora?
            //var avgMarriedAge = people.Where(x => x.IsMarried).Select(x => x.Age).Average();
            var avgMarriedAge = people.Where(x => x.IsMarried).Average(x => x.Age);
            Console.WriteLine("2. Házasok átlagéletkora: " + avgMarriedAge);
            Console.WriteLine();

            // 3. Add meg a legidősebb ember minden adatát!
            // Több megoldás esetén a listában az elsőt írasd ki!
            //var oldestPerson = people.OrderBy(x => x.Age).Last();
            //var oldestPerson = people.OrderByDescending(x => x.Age).First();
            var oldestPerson = people.First(x => x.Age == people.Select(y => y.Age).Max());
            Console.WriteLine("3. Legidősebb ember adatai: ");
            Console.WriteLine(oldestPerson);
            Console.WriteLine();

            // 4. Igaz-e, hogy minden 40 év feletti házas?
            Console.WriteLine("4. Minden 40 év feletti házas? " + people.All(p => p.Age <= 40 || p.IsMarried));
            Console.WriteLine("4. Minden 40 év feletti házas? " + !people.Any(p => p.Age > 40 && !p.IsMarried));

            // 5. Összesen hány darab L vagy l betűt tartalmaznak a nevek?
            Console.WriteLine();
            var countL = people.Select(x => x.Name.Count(c => c == 'L' || c == 'l')).Sum();
            Console.WriteLine("5. Összesen ennyi L betűt tartalmaznak a nevek: " + countL);
            Console.WriteLine();

            // 6. Add meg minden ember esetén, hogy hány fiatalabb van nála!
            // Az embereket életkor szerint növekvően jelenítsd meg!
            // Pl.: { Name = Kiss Anna, Age = 28, YoungerCount = 2 }
            var youngerCounts = people.OrderBy(p => p.Age).Select(p => new { p.Name, p.Age, YoungerCount = people.Count(o => o.Age < p.Age) });
            Write("6. Fiatalabbak száma: ", youngerCounts);
        }
    }
}
