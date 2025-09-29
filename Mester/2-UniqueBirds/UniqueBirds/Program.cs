using System;
using System.Collections.Generic;
using System.IO;

namespace UniqueBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> amounts = new List<List<int>>();
            ReadFromFile(amounts, "be1.txt");
            //ShowData(amounts);
            //Console.WriteLine(HasUnique(amounts, 0)); // false
            //Console.WriteLine(HasUnique(amounts, 1)); // true
            //Console.WriteLine(HasUnique(amounts, 2)); // true
            //Console.WriteLine(HasUnique(amounts, 3)); // false
            List<int> places = GetPlaces(amounts);
            ShowPlaces(places);
        }

        static void ShowPlaces(List<int> places)
        {
            Console.WriteLine(places.Count);
            foreach (int place in places)
            {
                Console.Write($"{place + 1} ");
            }
        }

        static List<int> GetPlaces(List<List<int>> amounts)
        {
            List<int> places = new List<int>();
            for (int i = 0; i < amounts.Count; i++)
            {
                if (HasUnique(amounts, i))
                {
                    places.Add(i);
                }
            }
            return places;
        }

        // Van-e az index-edik helységen egyedi madár?
        static bool HasUnique(List<List<int>> amounts, int index)
        {
            int j = 0; // j-edik madár
            while (j < amounts[index].Count && !(amounts[index][j] > 0 && IsUnique(amounts, j)))
            {
                j++;
            }
            return j < amounts[index].Count;
        }

        // Egyedi-e az index-edik madár?
        static bool IsUnique(List<List<int>> amounts, int index)
        {
            int count = 0;
            for (int i = 0; i < amounts.Count; i++) // j-dik helység
            {
                if (amounts[i][index] != 0)
                {
                    count++;
                }
            }
            return count == 1;
        }

        static void ShowData(List<List<int>> amounts)
        {
            for (int i = 0; i < amounts.Count; i++)
            {
                for (int j = 0; j < amounts[i].Count; j++)
                {
                    Console.Write(amounts[i][j] + " "); // amounts[i, j]
                }
                Console.WriteLine();
            }
        }

        static void ReadFromFile(List<List<int>> amounts, string file)
        {
            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split();
                List<int> row = new List<int>();
                foreach (string item in temp)
                {
                    row.Add(int.Parse(item));
                }
                amounts.Add(row);
            }
            sr.Close();
        }
    }
}
