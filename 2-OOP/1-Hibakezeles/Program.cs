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
            //E4();
            //E5();
            E6();
            Console.WriteLine("Program vége.");
        }

        private static double Pythagoras(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("A befogó nem lehet negatív vagy nulla!");
            }
            return Math.Sqrt(a * a + b * b);
        }

        private static void E6()
        {
            Console.WriteLine("6. példa: ");
            Console.Write("Fájl neve: ");
            string fileName = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string[] temp = sr.ReadLine().Split();
                    int a = int.Parse(temp[0]);
                    int b = int.Parse(temp[1]);
                    double c = Pythagoras(a, b);
                    Console.WriteLine($"Átfogó: {c:0.00}");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine();
        }

        private static void E5()
        {
            Console.WriteLine("5. példa: fájlba írás");
            Console.Write("Fájl: ");
            string fileName = Console.ReadLine();
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine("Sikeres fájlba írás!");
                }
            }
            catch (Exception e) // UnauthorizedAccessException
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }

        // finally: garantáltan végre fogja hajtani (akár hiba van akár nincs)
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
                return;
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
            finally
            {
                //if (sr != null)
                //{
                //    sr.Close();
                //}
                // null-conditional operator: ?.
                sr?.Close();
                Console.WriteLine("Fájl sikeresen lezárva!");
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
