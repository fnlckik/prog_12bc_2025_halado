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
            var f5 = from s in students
                     join r in results on s.ID equals r.StudentID
                     group r.Score by s into g
                     select new
                     {
                         Diák = new { g.Key.ID, g.Key.Name },
                         Összpont = g.Sum()
                     };
            Print("F5:", f5);

            // 6. Add meg annak a diáknak a nevét, aki
            // a legkevesebb versenyen vett részt!
            var f6 = from s in students
                     join r in results on s.ID equals r.StudentID
                     group s by s into g
                     orderby g.Count()
                     select g.Key;
            Console.WriteLine("\nF6: " + f6.First().Name);

            // 7. Add meg azokat a hónapokat, amikor
            // legalább két sport esemény volt!
            var f7 = from e in events
                     group e by e.Date.Month into g
                     where g.Count() >= 2
                     select new { Hónap = g.Key };
            Print("F7:", f7);

            // 8. Átlagosan hány pontot szereztek atlétika versenyeken?
            var f8 = from e in events
                     join r in results on e.ID equals r.EventID
                     where e.Type == "Atlétika"
                     select r.Score;
            Console.WriteLine("\nF8: " + f8.Average());

            // 9. Add meg minden osztály (A, B, C) esetén a 
            // legnagyobb pontszámot amit tanuló elért egy versenyen!
            // Pontszám szerint csökkenő sorrendben add meg az adatokat!
            var f9 = from r in results
                     join s in students on r.StudentID equals s.ID
                     group r.Score by s.Class into g
                     orderby g.Max() descending
                     select new
                     {
                         Class = g.Key,
                         Maxpont = g.Max()
                     };
            Print("F9:", f9);

        }
    }
}
