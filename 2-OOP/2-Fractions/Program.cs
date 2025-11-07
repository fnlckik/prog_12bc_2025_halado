using System;

namespace _2_Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fraction a = new Fraction(2, 3);
                Console.WriteLine($"Az első tört: {a}, értéke: {a.Value}");
                Fraction b = new Fraction(3, 0);
                Console.WriteLine($"A hibás tört: {b}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            // Logikai operátorok
            Fraction x = new Fraction(3, 4);
            Fraction y = new Fraction(3, 4);
            Console.WriteLine($"{x} == {y}: {x == y}");
            Fraction z = new Fraction(370368, 493824);
            Console.WriteLine($"{x} == {z}: {x == z}");
            Console.WriteLine($"{z} => {z.Simplify()}");
            //Fraction w = new Fraction(-3, 4);
            //Fraction v = new Fraction(3, -4);
            //Console.WriteLine($"{w} == {v}: {v == w}");
            //Fraction s = new Fraction(-3, -4);
            //Console.WriteLine($"{x} == {s}: {s == x}");
            //Console.WriteLine($"{w} => {w.Simplify()}");
            //Console.WriteLine($"{v} => {v.Simplify()}");
            //Console.WriteLine($"{s} => {s.Simplify()}");
            //Console.WriteLine($"{x} == {w}: {x == w}");
            Console.WriteLine();

            // Aritmetikai operátorok
            Fraction w = new Fraction(5, -6);
            Console.WriteLine($"{x} * {w} = {x * w}");
            Console.WriteLine($"{x} + {w} = {x + w}");
            Console.WriteLine($"3 * {x} = {3 * x}");
            Console.WriteLine($"3 * {x} = {x * 3}");
            Console.WriteLine($"{x} - {w} = {x - w}");
            Console.Clear();

            // Indexer
            try
            {
                Console.WriteLine($"{x} tört számlálója: {x["a"]} nevezője: {x["b"]}");
                Console.WriteLine(x["c"]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Clear();

            // Algebra osztály
            Algebra algebra = new Algebra("tortek.txt");
            Console.WriteLine($"Törtek száma: {algebra.Fractions.Count}");
            Console.WriteLine("Program vége.");
        }
    }
}
