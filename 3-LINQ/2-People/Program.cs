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
                new Person("Kiss Anna", "Budapest", 28, 165, false),
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

        static void Write(string message, IEnumerable<Person> people)
        {
            Console.WriteLine(message);
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<Person> people = Generate();
            Write("Adatok", people);

            // ---------------------------------------
            // F1 - WHERE
            //Write("1. Budapestiek: ", budapestiek);

            // F2 - SELECT
            // anonymous type
            // var: a fordító ki tudja találni a típusát
            //Write("2. Nevek: ", names);
            //Write("2. Nevek, életkorok: ", namesAges);

            // F3 - ORDER BY
            //Write("3. Életkor szerint növekvő sorrend: ", ???);
            //Write("3. Életkor, magasság szerint növekvő sorrend: ", ageHeightOrder);

            // F4 - LIMIT
            //Write("4. Legidősebb 5 fő: ", ???);

            // ---------------------------------------
            //Console.Clear();
            //Console.WriteLine("Feladatok: ");
            //Console.WriteLine();

            // 1. Add meg a 30 év alatti házasokat!
            //Write("1. Fiatal házasok: ", youngMarried);

            // 2. Mennyi a házasok átlagéletkora?
            //Console.WriteLine("2. Házasok átlagéletkora: " + avgMarriedAge);
            //Console.WriteLine();

            // 3. Add meg a legidősebb ember minden adatát!
            // Több megoldás esetén a listában az elsőt írasd ki!
            //Console.WriteLine("3. Legidősebb ember adatai: ");
            //Console.WriteLine(oldestPerson);

            // 4. Igaz-e, hogy minden 40 év feletti házas?
            //Console.WriteLine("4. Minden 40 év feletti házas? " + ???);
            //Console.WriteLine();

            // 5. Összesen hány darab L vagy l betűt tartalmaznak a nevek?
            //Console.WriteLine("5. Összesen ennyi L betűt tartalmaznak a nevek: " + countL);
            //Console.WriteLine();

            // 6. Add meg minden ember esetén, hogy hány fiatalabb van nála!
            // Az embereket életkor szerint növekvően jelenítsd meg!
            // Pl.: { Name = Kiss Anna, Age = 28, YoungerCount = 2 }
            //Write("6. Fiatalabbak száma: ", youngerCounts);
        }
    }
}
