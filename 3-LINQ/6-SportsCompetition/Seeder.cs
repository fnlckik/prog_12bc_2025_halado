using System;
using System.Collections.Generic;

namespace SportsCompetition
{
    partial class Program
    {
        static List<Student> SeedStudents()
        {
            return new List<Student>
            {
                new Student(1, "Kovács Anna", 10, 'A'),
                new Student(2, "Nagy Bence", 10, 'B'),
                new Student(3, "Tóth Eszter", 11, 'A'),
                new Student(4, "Farkas Gábor", 11, 'A'),
                new Student(5, "Molnár Júlia", 12, 'A'),
                new Student(6, "Kiss László", 12, 'B'),
                new Student(7, "Varga Petra", 10, 'C'),
                new Student(8, "Horváth Dávid", 11, 'C')
            };
        }

        static List<SportEvent> SeedSportEvents()
        {
            return new List<SportEvent>
            {
                new SportEvent(1, "Síkfutás", "Atlétika", new DateTime(2024,5,15)),
                new SportEvent(2, "Kosárlabda", "Labdajáték", new DateTime(2025,6,17)),
                new SportEvent(3, "Szertorna", "Torna", new DateTime(2026,3,24)),
                new SportEvent(4, "Gyorsúszás", "Úszás", new DateTime(2025,7,22)),
                new SportEvent(5, "Magasugrás", "Atlétika", new DateTime(2026,5,18)),
                new SportEvent(6, "Labdarúgás", "Labdajáték", new DateTime(2024,9,21)),
                new SportEvent(7, "Judo", "Küzdősport", new DateTime(2025,11,25)),
                new SportEvent(8, "Távolugrás", "Atlétika", new DateTime(2026,5,16)),
                new SportEvent(9, "Súlyemelés", "Erőpróba", new DateTime(2024,8,23)),
                new SportEvent(10, "Tenisz", "Labdajáték", new DateTime(2025,9,27)),
                new SportEvent(11, "Maraton", "Atlétika", new DateTime(2024,6,20)),
                new SportEvent(12, "Taekwondo", "Küzdősport", new DateTime(2026,5,30)),
                new SportEvent(13, "Hosszúugrás", "Atlétika", new DateTime(2025,5,26)),
                new SportEvent(14, "Mellúszás", "Úszás", new DateTime(2024,4,28)),
                new SportEvent(15, "Röplabda", "Labdajáték", new DateTime(2026,5,19)),
                new SportEvent(16, "Kötélhúzás", "Erőpróba", new DateTime(2025,3,29))
            };
        }

        static List<Result> SeedResults()
        {
            return new List<Result>
            {
                new Result(1, 4, 2, 22), new Result(2, 2, 9, 15), new Result(3, 8, 4, 18),
                new Result(4, 5, 1, 12), new Result(5, 7, 4, 20), new Result(6, 1, 6, 16),
                new Result(7, 3, 7, 25), new Result(8, 2, 8, 14), new Result(9, 6, 10, 19),
                new Result(10,1, 3, 17), new Result(11,4,12,23), new Result(12,7,5,18),
                new Result(13,8,11,21), new Result(14,2,15,20), new Result(15,5,9,17),
                new Result(16,3,14,19), new Result(17,1,13,22), new Result(18,6,2,18),
                new Result(19,7,16,21), new Result(20,8,6,15), new Result(21,2,1,14),
                new Result(22,5,12,24), new Result(23,4,8,16), new Result(24,1,5,20),
                new Result(25,3,3,19), new Result(26,6,14,18), new Result(27,7,10,22),
                new Result(28,8,7,25), new Result(29,2,13,21), new Result(30,5,16,20),
                new Result(31,1,9,17), new Result(32,4,11,19), new Result(33,3,2,22),
                new Result(34,6,15,20), new Result(35,7,1,12), new Result(36,8,4,18),
                new Result(37,2,6,16), new Result(38,5,5,19), new Result(39,1,12,23),
                new Result(40,3,8,15), new Result(41,6,3,20), new Result(42,7,14,18),
                new Result(43,8,15,21), new Result(44,2,7,24), new Result(45,5,13,22),
                new Result(46,1,16,20), new Result(47,4,10,19), new Result(48,3,6,17),
                new Result(49,6,1,13), new Result(50,7,12,28)
            };
        }
    }
}
