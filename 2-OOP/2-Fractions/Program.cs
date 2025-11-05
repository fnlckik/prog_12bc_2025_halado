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
        }
    }
}
