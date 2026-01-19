using System;
using System.Collections;
using System.Linq;

namespace SportsCompetition
{
    partial class Program
    {
        static void Print(string message, IEnumerable collection)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            var students = SeedStudents();
            var events = SeedSportEvents();
            var results = SeedResults();

            // 1. Hány darab volt az egyes verseny típusokból?
            var f1 = from e in events
                     group e by e.Type into g
                     select new
                     {
                         Típus = g.Key,
                         Mennyiség = g.Count()
                     };
            Print("F1: ", f1);

            // 2. Add meg a labdarúgás eredményét,
            // pontszám szerint csökkenő sorrendben!
            var f2 = from e in events
                     join r in results on e.ID equals r.EventID
                     where e.Name == "Labdarúgás"
                     orderby r.Score descending
                     select r;
            Print("F2: ", f2);

            // 3. Sorold fel a neveket évfolyamonként csoportosítva!
            var f3 = from s in students
                     group s.Name by s.Grade;
            Console.WriteLine("\nF3: ");
            foreach (var g in f3)
            {
                Console.WriteLine($"{g.Key}. évfolyam:");
                foreach (var item in g)
                {
                    Console.WriteLine("\t" + item);
                }
            }

            // 4. Add meg, hogy Molnár Júlia milyen versenyeken 
            // vett részt és azokon hány pontot szerzett!
            var f4 = from r in results
                     join s in students on r.StudentID equals s.ID
                     join e in events on r.EventID equals e.ID
                     where s.Name == "Molnár Júlia"
                     select new
                     {
                         Verseny = e.Name,
                         Pontszám = r.Score
                     };
            Print("F4: ", f4);

            // 5. Melyik diák hány pontot szerzett összesen a versenyek során?



            // 6. Add meg annak a diáknak a nevét, aki
            // a legkevesebb versenyen vett részt!



            // 7. Add meg azokat a hónapokat, amikor
            // legalább két sport esemény volt!
            Console.WriteLine(events.First().Date);


            // 8. Átlagosan hány pontot szereztek atlétika versenyeken?
            


            // 9. Add meg minden osztály (A, B, C) esetén a 
            // legnagyobb pontszámot amit tanuló elért egy versenyen!
            // Pontszám szerint csökkenő sorrendben add meg az adatokat!
            


        }
    }
}
