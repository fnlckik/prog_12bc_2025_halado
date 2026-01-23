using System;
using System.Collections;
using System.Linq;

namespace EntranceExam
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
            var tasks = SeedTasks();
            var students = SeedStudents();
            var results = SeedResults();

            // Ügyelj a minta pontos követésére!
            // Imperatív (ciklusos) és deklaratív (LINQ) megoldás is elfogadott.
            // Maximális pontszám: 22 pont

            // F1 - 3 pont
            // Írasd ki a diákok nevét, 8. osztályos matematika jegyét
            // általános iskolák szerint csoportosítva!
            var q1 = from s in students
                     group s by s.School;
            Console.WriteLine("1. feladat:");
            foreach (var g in q1)
            {
                Console.WriteLine(g.Key);
                foreach (var item in g)
                {
                    Console.WriteLine($"\t{item.Name} ({item.MathGrade})");
                }
            }


            // F2 - 6 pont
            // Számold ki a diákok összpontszámait!
            // Rendezd az adatokat életkor szerint növekvő sorrendbe!
            // Jelenjen meg a diák neve, összpontszáma, életkora!
            // Tipp: Az aktuális dátum a DateTime struct Now statikus tulajdonsága.
            var q2 = from s in students
                     join r in results on s.ID equals r.StudentID
                     //orderby s.Birth descending
                     group (s, r) by s into g
                     let age = DateTime.Now.Year - g.Key.Birth.Year
                     orderby age
                     select new
                     {
                         Student = g.Key.Name,
                         TotalPoints = g.Sum(e => e.r.Point),
                         Age = age
                     };
            Print("2. feladat:", q2);

            // F3 - 4 pont
            // Add meg, hogy Molnár Bence melyik feladatra hány pontot kapott!
            // A feladat leírását, a pontszámot, és a maximális szerezhető
            // pontszámot jelenítsd meg!
            var q3 = from r in results
                     join s in students on r.StudentID equals s.ID
                     join t in tasks on r.TaskID equals t.ID
                     where s.Name == "Molnár Bence"
                     select new
                     {
                         Text = t.Description,
                         r.Point,
                         t.MaxPoint
                     };
            Print("3. feladat:", q3);


            // F4 - 4 pont
            // Add meg minden témakörhöz a feladatok számát, és a
            // legnehezebb feladat pontszámát! Csak azokat a témaköröket
            // sorold fel, amelyekben legalább 2 feladat volt!
            var q4 = from t in tasks
                     group t by t.Topic into g
                     where g.Count() >= 2
                     select new
                     {
                         Topic = g.Key,
                         Quantity = g.Count(),
                         MaxPoint = g.Max(t => t.MaxPoint)
                     };
            Print("4. feladat:", q4);


            // F5 - 5 pont
            // Add meg minden témakörhöz, hogy a pontszám hány 
            // százalékát szerezték meg átlagosan a diákok!
            var q5 = from t in tasks
                     join r in results on t.ID equals r.TaskID
                     group (t, r) by t.Topic into g
                     select new
                     {
                         Topic = g.Key,
                         Percent = Math.Round(g.Average(e => (double)e.r.Point / e.t.MaxPoint) * 100) + "%"
                     };
            Print("5. feladat:", q5);

        }
    }
}
