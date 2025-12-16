using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    internal class Program
    {
        static void Write(string msg, IEnumerable<int> collection)
        {
            Console.Write(msg + " ");
            foreach (int item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static bool IsPositive(int x)
        {
            return x > 0;
        }

        static IEnumerable<int> F1(IEnumerable<int> collection)
        {
            List<int> result = new List<int>();
            foreach (int item in collection)
            {
                if (IsPositive(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static IEnumerable<int> F2(IEnumerable<int> collection)
        {
            List<int> result = new List<int>();
            foreach (int item in collection)
            {
                if (IsEven(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        // Kiválogatjuk a T tulajdonságú elemeket. (Filter)
        static IEnumerable<int> F(IEnumerable<int> collection, Func<int, bool> T)
        {
            List<int> result = new List<int>();
            foreach (int item in collection)
            {
                if (T(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static int Max(IEnumerable<int> collection)
        {
            IEnumerator<int> iterator = collection.GetEnumerator();
            iterator.MoveNext();
            int max = iterator.Current;
            while (iterator.MoveNext())
            {
                //if (iterator.Current > max)
                //{
                //    max = iterator.Current;
                //}
                max = iterator.Current > max ? iterator.Current : max;
                // s = s + iterator.Current
            }
            return max;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> { -2, -3, 1, 1, 6, -4, 9 };
            HashSet<int> set = new HashSet<int> { 6, -7, 3, 4, 1, 23 };
            int[] array = new int[] { 5, 2, 12, 1, 3, -1, -3, 5, 24, -3 };

            // 0. Írassuk ki az elemeket
            Write("Elemek (lista):", list);
            Write("Elemek (halmaz):", set);
            Write("Elemek (tömb):", array);

            // Pozitív elemek - kiválogatás
            Console.WriteLine();
            Write("Pozitív elemek (lista):", F(list, IsPositive));
            Write("Pozitív elemek (halmaz):", F(set, IsPositive));
            Write("Pozitív elemek (tömb):", F(array, IsPositive));
            Write("Pozitív elemek (tömb):", array.Where(IsPositive));
            Write("Pozitív elemek (tömb):", array.Where(x => x > 0)); // lambda expression

            // Páros elemek - kiválogatás
            Console.WriteLine();
            Write("Páros elemek (lista):", F(list, IsEven));
            Write("Páros elemek (halmaz):", F(set, IsEven));
            Write("Páros elemek (tömb):", F(array, IsEven));
            Write("Páros elemek (tömb):", array.Where(x => x % 2 == 0));

            // LINQ = Language INtegrated Query
            // Sablon problémák => Progtétel
            // Imperatív programozás: Hogyan oldjuk meg a problémát? (for, if, ...) -> C

            // Progtételek => Sablon függvények
            // Deklaratív programozás: Mit akarunk megoldani? (WHERE, SELECT, ...) -> SQL

            Console.WriteLine();
            // 1. Kiválogatás: Where
            Write("10-nél nagyobb elemek:", array.Where(x => x > 10));

            // 2. Másolás: Select
            Write("Elemek négyzetei:", array.Select(x => x*x));

            // Aggregáló függvények
            // 3. Megszámolás: Count
            Console.WriteLine("3. Pozitív elemek száma: " + array.Count(x => x > 0));

            // 4. Összegzés: Sum, Average
            Console.WriteLine("4. Elemek összege: " + array.Sum());
            Console.WriteLine("4. Elemek átlaga: " + array.Average());

            // 5. Minmax: Min, Max
            Console.WriteLine("5. Legnagyobb elem: " + array.Max());

            // 6. Sorozatszámítás: Aggregate
            Console.WriteLine("6. Elemek összege: " + array.Aggregate((result, element) => result + element));
            Console.WriteLine("6. Elemek szorzata: " + array.Aggregate((result, element) => result * element));
            Console.WriteLine("6. Legnagyobb elem: " + array.Aggregate((result, element) => element > result ? element : result));
            //Console.WriteLine(Max(array));

            // 7. Eldöntés: Any (Van-e adott tulajdonságú elem?)
            Console.WriteLine("7. Van-e pozitív elem? " + array.Any(x => x > 0));

            // 8. Eldöntés (optimista): All (Minden elem adott tulajdonságú?)
            Console.WriteLine("8. Minden elem pozitív? " + array.All(x => x > 0));

            // 9. Keresés: First, Last
            Console.WriteLine("9. Az első pozitív elem: " + array.First(x => x > 0));
            Console.WriteLine("9. Az utolsó pozitív elem: " + array.Last(x => x > 0));
            int first = array.First(x => x > 0);
            Console.WriteLine("9. Az első pozitív elem indexe: " + array.ToList().IndexOf(first));
            Console.WriteLine("9. Az első pozitív elem indexe: " + array.ToList().FindIndex(x => x > 0));

            // 10. Halmazkészítés: Distinct (egyedi elemek kiválogatása)
            Write("10. Elemek duplikáció nélkül:", array.Distinct());

            // 11. Unió, metszet, különbség: Union, Intersect, Except
            Write("11. Unió (lista, tömb):", list.Union(array));
            Write("11. Metszet (lista, tömb):", list.Intersect(array));
            Write("11. Különbség (lista, tömb):", list.Except(array));

            // 12. Rendezés: OrderBy
            // a keySelector függvény TKey paramétere: definiálva van rá a CompareTo
            Write("12. Rendezés (növekvő):", array.OrderBy(x => x));
            Write("12. Rendezés (csökkenő):", array.OrderByDescending(x => x));

            // ----------------------------------------------
            Console.Clear();

            // F1
            int evenSum = array.Where(x => x % 2 == 0).Sum();
            Console.WriteLine("1. Páros számok összege: " + evenSum);
        }
    }
}
