using System;
using System.Collections.Generic;
using System.IO;

namespace Illness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Simulate(7);
            List<List<int>> costs = new List<List<int>>();
            T2(costs);
            T3(costs);
            T4(costs);
            Dictionary<int, int> dictionary = T5(costs);
            WriteToFile(dictionary, "stats.txt");
        }

        private static void WriteToFile(Dictionary<int, int> dictionary, string file)
        {
            StreamWriter sw = new StreamWriter(file);
            int maxi = 0;
            foreach (int key in dictionary.Keys)
            {
                sw.WriteLine($"{key + 1}. beteg: {dictionary[key]} Ft");
                if (dictionary[key] > dictionary[maxi])
                {
                    maxi = key;
                }
            }
            sw.WriteLine($"Legtöbbet költötte: {maxi + 1}. beteg.");
            sw.Close();
        }

        private static Dictionary<int, int> T5(List<List<int>> costs)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < costs.Count; i++)
            {
                int sum = 0;
                foreach (int cost in costs[i])
                {
                    sum += cost;
                }
                dictionary.Add(i, sum);
            }
            return dictionary;
        }

        private static void T4(List<List<int>> costs)
        {
            Console.WriteLine("4. feladat:");
            double avg = AverageCost(costs);
            Console.WriteLine($"Átlagos költség: {Math.Round(avg)} Ft");
        }

        private static double AverageCost(List<List<int>> costs)
        {
            int sum = 0;
            int count = 0;
            foreach (List<int> row in costs)
            {
                foreach (int cost in row)
                {
                    sum += cost;
                    count++;
                }
                //count += row.Count;
            }
            Console.WriteLine($"{sum} {count}");
            double avg = (double)sum / count;
            return avg;
        }

        private static void T3(List<List<int>> costs)
        {
            Console.WriteLine("3. feladat:");
            int i = 0;
            while (i < costs.Count && !(costs[i].Count <= 5))
            {
                i++;
            }
            if (i < costs.Count)
            {
                Console.WriteLine($"Maximum 5-ször volt gyógyszertárban: {i+1}. beteg");
            }
            else
            {
                Console.WriteLine("Nincs olyan beteg, aki maximum 5-ször volt.");
            }
        }

        private static void T2(List<List<int>> costs)
        {
            StreamReader sr = new StreamReader("data.txt");
            while (!sr.EndOfStream)
            { 
                string[] temp = sr.ReadLine().Split(' ');
                List<int> row = new List<int>();
                foreach (string item in temp)
                {
                    row.Add(int.Parse(item));
                }
                costs.Add(row);
            }
            sr.Close();
        }

        static void Simulate(int n)
        {
            Console.WriteLine("1. feladat");
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int price = r.Next(6, 13) * 1000;
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }
    }
}
