using System;
using System.Collections.Generic;
using System.IO;
//using System.Threading;

namespace Roulette
{
    internal class Program
    {
        // static: osztályszintű, nem kell példányosítani a használatához
        static Random r = new Random();
        static HashSet<int> black, red;

        // Visszatérés: nyeremény mennyisége
        static int Plain(int bet, int number)
        {
            //Thread.Sleep(1);
            int winner = r.Next(37);
            Console.WriteLine($"Kapott szám: {winner}");
            if (number == winner)
            {
                Console.WriteLine($"Nyert!");
                return 36 * bet;
            }
            else
            {
                Console.WriteLine("Vesztett!");
                return 0;
            }
        }

        static int GetBet(int money)
        {
            int bet;
            do
            {
                Console.Write("Tét: ");
                bet = int.Parse(Console.ReadLine());
            }
            while (bet <= 0 || bet > money);
            return bet;
        }

        static void Play(int money)
        {
            while (money > 0)
            {
                int bet = GetBet(money); // 1000
                Console.Write("Szám / Szín: ");
                //int number = int.Parse(Console.ReadLine()); // 1
                string color = Console.ReadLine(); // R, B
                //money = money - bet + Plain(bet, number);
                money = money - bet + RedBlack(bet, color);
                Console.WriteLine($"Jelenlegi pénz: {money}\n");
            }
        }

        static int RedBlack(int bet, string color)
        {
            int winner = r.Next(37);
            Console.WriteLine($"Kapott szám: {winner}");
            if (false) // TODO
            {
                Console.WriteLine($"Nyert!");
                return 2 * bet;
            }
            else
            {
                Console.WriteLine("Vesztett!");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            ReadFromFile("szinek.txt");
            int money = 60000;
            Console.WriteLine($"Kezdőpénz: {money}");
            Play(money);
            //Autoplay(money);
        }

        static void ReadFromFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            red = new HashSet<int>();
            string[] temp = sr.ReadLine().Split(' ');
            foreach (string item in temp)
            {
                red.Add(int.Parse(item));
            }
            black = new HashSet<int>();
            temp = sr.ReadLine().Split(' ');
            foreach (string item in temp)
            {
                black.Add(int.Parse(item));
            }
            sr.Close();
        }

        static void Autoplay(int money)
        {
            int BET = GetBet(money);
            while (money > 0)
            {
                money = money - BET + Plain(BET, 1);
                Console.WriteLine($"Jelenlegi pénz: {money}\n");
            }
        }
    }
}
