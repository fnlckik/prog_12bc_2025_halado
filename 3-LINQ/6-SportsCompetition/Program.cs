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
            


            // 2. Add meg a labdarúgás eredményét,
            // pontszám szerint csökkenő sorrendben!
            


            // 3. Sorold fel a neveket évfolyamonként csoportosítva!
            


            // 4. Add meg, hogy Molnár Júlia milyen versenyeken 
            // vett részt és azokon hány pontot szerzett!
            


            // 5. Melyik diák hány pontot szerzett összesen a versenyek során?
            
            

            // 6. Add meg annak a diáknak a nevét, aki
            // a legkevesebb versenyen vett részt!
            


            // 7. Add meg azokat a hónapokat, amikor
            // legalább két sport esemény volt!
            


            // 8. Átlagosan hány pontot szereztek atlétika versenyeken?
            


            // 9. Add meg minden osztály (A, B, C) esetén a 
            // legnagyobb pontszámot amit tanuló elért egy versenyen!
            // Pontszám szerint csökkenő sorrendben add meg az adatokat!
            


        }
    }
}
