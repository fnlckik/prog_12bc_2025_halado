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
            ShowData(amounts);
            Console.WriteLine(IsUnique(amounts, 0)); // false
            Console.WriteLine(IsUnique(amounts, 1)); // true
            Console.WriteLine(IsUnique(amounts, 2)); // true
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
