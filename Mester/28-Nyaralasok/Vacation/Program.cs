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
