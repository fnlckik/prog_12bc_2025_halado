using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace BookShop
{
    partial class Program
    {
        static void Print(string message, IEnumerable collection)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintOne<T>(string message, T data)
        {
            Console.WriteLine($"\n{message}: {data}");
        }

        static void Main(string[] args)
        {
            #region Data seeding
            var authors = SeedAuthors();
            var books = SeedBooks();
            var orders = SeedOrders();

            Print("Szerzők:", authors);
            Print("\nKönyvek:", books);
            Print("\nRendelések:", orders);
            Console.Clear();
            #endregion
        }
    }
}
