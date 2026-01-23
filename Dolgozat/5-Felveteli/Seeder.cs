using System;
using System.Collections.Generic;

namespace EntranceExam
{
    partial class Program
    {
        private static List<Task> SeedTasks()
        {
            return new List<Task>
            {
                new Task(1, "Számelmélet", "Mennyi 36 és 56 legnagyobb közös osztója?", 2),
                new Task(2, "Algebra", "Számítsd ki: 4/15 + 5/6", 2),
                new Task(3, "Statisztika", "Mennyi a 20%-a 150-nek?", 2),
                new Task(4, "Statisztika", "Egy termék ára 8000 Ft, 10%-kal csökkentik. Mennyi az új ár?", 2),
                new Task(5, "Algebra", "Oldd meg az egyenletet: 7 + 3x = 25", 2),
                new Task(6, "Algebra", "Oldd meg: 21/x + 18/x = 26", 3),
                new Task(7, "Algebra", "Két szám aránya 2:5, összegük 56. Melyek ezek a számok?", 3),
                new Task(8, "Algebra", "Egy autó 2 óra alatt 120 km-t tesz meg, majd 3 óra alatt 40 km-t. Mennyi az átlagsebessége?", 3),
                new Task(9, "Geometria", "Egy rombusz egyik szöge 20°. Mekkora a másik szöge?", 1),
                new Task(10, "Geometria", "Egy téglalap oldalai 6 cm és 8 cm. Mekkora az átlója?", 2),
                new Task(11, "Geometria", "Hány cm hosszú annak az egyenlő szárú háromszögnek az alapja, amelynek a szára 17 cm, a kerülete 43 cm?", 2),
                new Task(12, "Algebra", "Egy dobozban 11 nem piros, 12 nem kék, 13 nem sárga labda van. Hány labda van?", 5),
                new Task(13, "Függvények", "Hol veszi fel az f(x) = 5x - 2 függvény az 58 értéket?", 2),
                new Task(14, "Statisztika", "Számítsd ki az adatsor átlagát: 1, 4, 7, 8!", 2),
                new Task(15, "Számelmélet", "I vagy H: ha egy szám osztható 2-vel és 6-tal, akkor 12-vel is osztható.", 1)
            };
        }

        private static List<Student> SeedStudents()
        {
            return new List<Student>
            {
                new Student(1, "Kiss Ádám", "Petőfi Sándor Általános Iskola", true,  new DateTime(2011, 3, 12), 5),
                new Student(2, "Molnár Bence", "Arany János Általános Iskola", true, new DateTime(2011, 7, 5), 2),
                new Student(3, "Tóth Lilla", "Petőfi Sándor Általános Iskola", true,  new DateTime(2011, 1, 22), 5),
                new Student(4, "Szabó Márk", "Kölcsey Ferenc Általános Iskola", false, new DateTime(2012, 11, 30), 3),
                new Student(5, "Varga Ádám", "Petőfi Sándor Általános Iskola", true,  new DateTime(2011, 5, 18), 4),
                new Student(6, "Kovács Dóra", "Arany János Általános Iskola", false, new DateTime(2011, 9, 9), 5),
                new Student(7, "Horváth Péter", "Kölcsey Ferenc Általános Iskola", true,  new DateTime(2012, 12, 14), 2),
                new Student(8, "Balogh Zsófia", "Petőfi Sándor Általános Iskola", false, new DateTime(2011, 6, 2), 3),
                new Student(9, "Farkas Levente", "Arany János Általános Iskola", true,  new DateTime(2012, 12, 21), 5),
                new Student(10, "Molnár Eszter", "Kölcsey Ferenc Általános Iskola", false, new DateTime(2010, 1, 20), 5),
                new Student(11, "Papp Gergő", "Petőfi Sándor Általános Iskola", true,  new DateTime(2011, 8, 16), 3),
                new Student(12, "Lakatos Nóra", "Arany János Általános Iskola", false, new DateTime(2011, 9, 3), 2),
                new Student(13, "Takács Milán", "Kölcsey Ferenc Általános Iskola", true,  new DateTime(2010, 4, 25), 4),
                new Student(14, "Tóth Kata", "Petőfi Sándor Általános Iskola", false, new DateTime(2012, 12, 1), 5),
                new Student(15, "Simon Áron", "Arany János Általános Iskola", true,  new DateTime(2010, 6, 20), 3)
            };
        }

        private static List<Result> SeedResults()
        {
            return new List<Result>
            {
                new Result(7, 10, 2),
                new Result(2, 12, 4),
                new Result(9, 1, 0),
                new Result(5, 4, 2),
                new Result(14, 7, 3),

                new Result(1, 5, 2),
                new Result(9, 6, 0),
                new Result(10, 11, 2),
                new Result(7, 12, 3),
                new Result(3, 6, 2),

                new Result(14, 10, 2),
                new Result(6, 8, 2),
                new Result(2, 15, 1),
                new Result(9, 15, 0),
                new Result(12, 5, 2),

                new Result(5, 11, 2),
                new Result(4, 10, 2),
                new Result(14, 12, 5),
                new Result(11, 15, 1),
                new Result(7, 2, 2),

                new Result(8, 7, 2),
                new Result(2, 6, 2),
                new Result(13, 6, 1),
                new Result(1, 1, 1),
                new Result(9, 3, 2),

                new Result(5, 6, 3),
                new Result(14, 8, 3),
                new Result(3, 3, 1),
                new Result(10, 1, 2),
                new Result(7, 14, 2),

                new Result(6, 4, 1),
                new Result(12, 3, 2),
                new Result(2, 1, 2),
                new Result(11, 14, 1),
                new Result(8, 2, 1),

                new Result(5, 12, 4),
                new Result(15, 12, 2),
                new Result(2, 13, 2),
                new Result(4, 9, 1),
                new Result(14, 2, 2),

                new Result(7, 7, 3),
                new Result(9, 9, 1),
                new Result(10, 11, 2),
                new Result(12, 5, 2),
                new Result(14, 8, 3)
            };
        }
    }
}
