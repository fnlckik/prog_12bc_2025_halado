using System;

namespace Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Coffee.BASEPRICE);
            //Coffee c = new Coffee(true);
            //Console.WriteLine(c);
            Bakery bakery = new Bakery("products.txt");
            bakery.ListProducts();

            // 7. feladat
            Scone cheese = bakery.GetScone("Sajtos");
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                int count = r.Next(3, 21);
                Console.Write($"Vásárlás: {count} db -> ");
                try
                {
                    cheese.Buy(count);
                    Console.WriteLine(cheese);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
