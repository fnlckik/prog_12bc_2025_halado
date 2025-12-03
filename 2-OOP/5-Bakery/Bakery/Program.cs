using System;

namespace Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Coffee.BASEPRICE);
            Coffee c = new Coffee(true);
            Console.WriteLine(c);
        }
    }
}
