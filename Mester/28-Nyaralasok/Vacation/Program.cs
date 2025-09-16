using System;
using System.Collections.Generic;
using System.IO;

namespace Vacation
{
    internal class Program
    {
        struct Vacation
        {
            public int id;
            public string place;
        }

        static void Main(string[] args)
        {
            List<Vacation> vacations = new List<Vacation>();
            ReadFromFile(vacations, out int studentCount, "be2.txt");
            T1(vacations);
            T2(vacations, out Dictionary<int, int> vacationCounts);
            T3(vacations);
            T4(vacationCounts, studentCount);
            T5(vacations);
        }

        static void GetStudentVacations(Dictionary<int, HashSet<string>> studentVacations, List<Vacation> vacations)
        {
            foreach (Vacation vacation in vacations)
            {
                int id = vacation.id;
                string place = vacation.place;
                if (studentVacations.ContainsKey(id))
                {
                    studentVacations[id].Add(place);
                }
                else
                {
                    studentVacations.Add(id, new HashSet<string> { place });
                }
            }
        }

        static void T5(List<Vacation> vacations)
        {
            Console.WriteLine("#");
            Dictionary<int, HashSet<string>> studentVacations = new Dictionary<int, HashSet<string>>();
            GetStudentVacations(studentVacations, vacations);

            //foreach (int id in studentVacations.Keys)
            //{
            //    Console.Write(id + " ");
            //    foreach (string place in studentVacations[id])
            //    {
            //        Console.Write(place + " ");
            //    }
            //    Console.WriteLine();
            //}
            int count = 0;
            Dictionary<int, int> groups = new Dictionary<int, int>();
            foreach (int id in studentVacations.Keys)
            {
                if (!groups.ContainsKey(id))
                {
                    SetGroups(ref count, groups, studentVacations, id);
                }
            }

            //Console.WriteLine();
            //foreach (int id in groups.Keys)
            //{
            //    Console.WriteLine($"{id} => {groups[id]}. csoport");
            //}
            Console.WriteLine(count);
        }

        static void SetGroups(ref int count, Dictionary<int, int> groups, Dictionary<int, HashSet<string>> studentVacations, int id)
        {
            count++;
            groups.Add(id, count);
            foreach (int other in studentVacations.Keys)
            {
                bool isSamePlaces = studentVacations[id].SetEquals(studentVacations[other]);
                if (id != other && isSamePlaces)
                {
                    groups.Add(other, count);
                }
            }
        }

        static void T4(Dictionary<int, int> vacationCounts, int studentCount)
        {
            Console.WriteLine("#");
            int i = 1;
            while (i <= studentCount && vacationCounts.ContainsKey(i))
            {
                i++;
            }
            if (i <= studentCount) Console.WriteLine(i);
            else Console.WriteLine(-1);
        }

        static void T3(List<Vacation> vacations)
        {
            Console.WriteLine("#");
            Dictionary<string, int> placeCounts = new Dictionary<string, int>(); ;
            foreach (Vacation vacation in vacations)
            {
                if (placeCounts.ContainsKey(vacation.place))
                {
                    placeCounts[vacation.place]++;
                }
                else
                {
                    placeCounts.Add(vacation.place, 1);
                }
            }

            int max = -1; // Max hányan voltak?
            string maxPlace = "";
            foreach (string place in placeCounts.Keys)
            {
                if (placeCounts[place] > max)
                {
                    max = placeCounts[place];
                    maxPlace = place;
                }
            }
            Console.WriteLine(maxPlace);
        }

        static void T2(List<Vacation> vacations, out Dictionary<int, int> vacationCounts)
        {
            Console.WriteLine("#");
            vacationCounts = new Dictionary<int, int>(); ;
            foreach (Vacation vacation in vacations)
            {
                if (vacationCounts.ContainsKey(vacation.id))
                {
                    vacationCounts[vacation.id]++;
                }
                else
                {
                    vacationCounts.Add(vacation.id, 1);
                }
            }
            foreach (int id in vacationCounts.Keys)
            {
                Console.WriteLine($"{id} {vacationCounts[id]}");
            }
        }

        static void T1(List<Vacation> vacations)
        {
            Console.WriteLine("#");
            HashSet<string> places = new HashSet<string>();
            foreach (Vacation vacation in vacations)
            {
                places.Add(vacation.place);
            }
            Console.WriteLine(places.Count);
        }

        static void ReadFromFile(List<Vacation> vacations, out int studentCount, in string file)
        {
            StreamReader sr = new StreamReader(file);
            string[] temp = sr.ReadLine().Split();
            studentCount = int.Parse(temp[0]);
            while (!sr.EndOfStream)
            {
                Vacation vacation;
                vacation.id = int.Parse(sr.ReadLine());
                vacation.place = sr.ReadLine();
                vacations.Add(vacation);
            }
            sr.Close();
        }
    }
}
