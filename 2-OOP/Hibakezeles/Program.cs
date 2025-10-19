using System;
using System.IO;

namespace Hibakezeles
{
    internal class Program
    {
        // veszélyes kódrészletek => try{} blokkba
        // hiba esetén mi történjen => catch{} blokkba
        static void E1()
        {
            Console.WriteLine("1. példa: oszthatóság");
            int a = 23;
            int b = 0;
            try
            {
                Console.WriteLine($"Hányados: {a / b}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nem lehet 0-val osztani!");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //E1();
            //E2();
            //E3();
            E4();
            Console.WriteLine("Program vége.");
        }

        private static void E4()
        {
            Console.WriteLine("4. példa: fájl hiányzik");
            Console.Write("Fájl neve: ");
            string fileName = Console.ReadLine();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                string[] temp = sr.ReadLine().Split();
                int a = int.Parse(temp[0]); // rossz3 => OverflowException
                int b = int.Parse(temp[1]); // rossz3 => IndexoutOfRangeException
            }
            catch (FileNotFoundException e) { Console.WriteLine(e.Message); }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("A fájlban csak egész számok legyenek!");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("A fájl első sorában legalább két szám legyen!");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"A fájlban lévő adatok {int.MinValue} és {int.MaxValue} között legyenek!");
            }
            catch (Exception e) { Console.WriteLine(e.Message); } //jogosultság
            if (sr != null)
            {
                sr.Close();
            }
            Console.WriteLine();
        }

        private static void E3()
        {
            Console.WriteLine("3. példa: tömb indexelés");
            string[] a = { "alma", "banán", "citrom", "dinnye" };
            Console.Write("Adj meg egy sorszámot: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine($"A(z) {i}. gyümölcs: {a[i-1]}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Adj meg egész számot 1 és {a.Length} között!");
            }
            catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }
            Console.WriteLine();
        }

        private static void E2()
        {
            Console.WriteLine("2. példa: konverzió");
            Console.Write("Adj meg egy egész számot: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("A szám ötszöröse: " + 5*n);
            }
            catch (FormatException e)
            {
                //Console.WriteLine("Nem egész számot adtál meg!");
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine();
        }
    }
}
