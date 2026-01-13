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

            #region Method VS Query [1-5]
            // 1. A szerzők nevei
            var m1 = authors.Select(a => a.Name);
            Print("1. A szerzők nevei: ", m1);

            // SELECT Name
            // FROM authors;

            // A query vége "mindig" SELECT. => vagy GROUPBY
            var q1 = from a in authors
                     select a.Name;
            Print("1. A szerzők nevei: ", q1);

            // 2. A 400 oldalnál hosszabb könyvek: cím, oldalszám
            var m2 = books.Where(b => b.Pages > 400).Select(b => new { b.Title, b.Pages });
            Print("2. A 400 oldalnál hosszabb könyvek: ", m2);

            var q2 = from b in books
                     where b.Pages > 400
                     select new { b.Title, b.Pages };
            Print("2. A 400 oldalnál hosszabb könyvek: ", q2);

            // 3. Fantasy könyvek, év szerint növekvően
            var m3 = books.Where(b => b.Genre == "Fantasy").OrderBy(b => b.Year);
            Print("3. Fantasy könyvek, év szerint növekvően: ", m3);

            var q3 = from b in books
                     where b.Genre == "Fantasy"
                     orderby b.Year, b.Pages
                     select b;
            Print("3. Fantasy könyvek, év szerint növekvően: ", q3);

            // 4. A 6 legdrágább könyv
            var q4 = (from b in books
                     orderby b.Price descending
                     select b).Take(6);
            Print("4. A 6 legdrágább könyv: ", q4);

            // 5. Különböző műfajok
            var q5 = (from b in books
                     select b.Genre).Distinct();
            Print("5. Különböző műfajok: ", q5);
            Console.Clear();
            #endregion

            // 6. Műfajonként csoportok
            Console.WriteLine("6. Műfajonként csoportok: ");
            IEnumerable<IGrouping<string, Book>> groups = books.GroupBy(b => b.Genre);
            foreach (IGrouping<string, Book> group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (Book item in group)
                {
                    Console.WriteLine("\t" + item.Title);
                }
            }

            var q6 = from book in books
                     group book.Title by book.Genre;
            Console.WriteLine("\n6. Műfajonként csoportok: ");
            foreach (var group in q6)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("\t" + item);
                }
            }
        }
    }
}
