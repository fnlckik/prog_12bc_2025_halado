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
            ReadFromFile(vacations, out int studentCount, "be1.txt");
            T1(vacations);
            T2(vacations, out Dictionary<int, int> vacationCounts);
            T3(vacations);
            T4(vacationCounts, studentCount);
        }

        static void T4(Dictionary<int, int> vacationCounts, int studentCount)
        {
            Console.WriteLine("#");
            int i = 1;
            while (i <= studentCount && vacationCounts.ContainsKey(i))
            {
                i++;
            }
            Console.WriteLine(i);
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
