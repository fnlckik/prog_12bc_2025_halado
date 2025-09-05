using System;
using System.Security.Policy;

namespace Roulette
{
    internal class Program
    {
        // Visszatérés: nyeremény mennyisége
        static int Plain(int bet, int number)
        {
            Random r = new Random();
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
                int bet = GetBet(money);
                Console.Write("Szám: ");
                int number = int.Parse(Console.ReadLine());
                money = money - bet + Plain(bet, number);
                Console.WriteLine($"Jelenlegi pénz: {money}");
            }
        }

        static void Main(string[] args)
        {
            int money = 60000;
            Play(money);
        }
    }
}
