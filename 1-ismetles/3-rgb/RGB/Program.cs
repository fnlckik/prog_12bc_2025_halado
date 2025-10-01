using System;
using System.Collections.Generic;
using System.IO;

namespace RGB
{
    internal class Program
    {
        struct Color
        {
            public byte red;
            public byte green;
            public byte blue;
            private int sum;

            public int Sum { get => sum; }

            public Color(byte red, byte green, byte blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
                this.sum = red + green + blue;
            }

            public Color(string red, string green, string blue)
            {
                this.red = byte.Parse(red);
                this.green = byte.Parse(green);
                this.blue = byte.Parse(blue);
                this.sum = this.red + this.green + this.blue;
            }

            public override string ToString()
            {
                return $"RGB({red},{green},{blue})";
            }
        }

        static void Main(string[] args)
        {
            List<List<Color>> picture = new List<List<Color>>();
            ReadFromFile(picture, "kep.txt");
            //Console.WriteLine($"{picture.Count} {picture[0].Count}");
            //T2(picture);
            T3(picture);
            T4(picture);
            T6(picture);
        }

        static void T6(List<List<Color>> picture)
        {
            Console.WriteLine("6. feladat:");
            int i = 0;
            while (i < picture.Count && !(Hatar(picture, i, 10)))
            {
                i++;
            }
            Console.WriteLine($"A felhő legfelső sora: {i+1}");

            i = picture.Count - 1;
            while (i >= 0 && !(Hatar(picture, i, 10)))
            {
                i--;
            }
            Console.WriteLine($"A felhő legalsó sora: {i+1}");
        }

        static bool Hatar(List<List<Color>> picture, int index, int difference)
        {
            int j = 0;
            List<Color> row = picture[index];
            while (j < row.Count-1 && !(Math.Abs(row[j].blue - row[j+1].blue) > difference))
            {
                j++;
            }
            return j < row.Count - 1;
        }

        static void T4(List<List<Color>> picture)
        {
            Console.WriteLine("4. feladat:");
            //int minValue = int.MaxValue;
            int minValue = picture[0][0].Sum;
            foreach (List<Color> pixels in picture)
            {
                foreach (Color color in pixels)
                {
                    if (color.Sum < minValue) minValue = color.Sum;
                }
            }
            Console.WriteLine($"A legsötétebb pont RGB összege: {minValue}");
            Console.WriteLine("A legsötétebb pixelek színe:");
            foreach (List<Color> pixels in picture)
            {
                foreach (Color color in pixels)
                {
                    if (color.Sum == minValue) Console.WriteLine(color);
                }
            }
        }

        static void T3(List<List<Color>> picture)
        {
            Console.WriteLine("3. feladat:");
            int count = 0;
            foreach (List<Color> pixels in picture)
            {
                foreach (Color color in pixels)
                {
                    if (color.Sum > 600) count++;
                }
            }
            Console.WriteLine($"A világos képpontok száma: {count}");
        }

        static void T2(List<List<Color>> picture)
        {
            Console.WriteLine("2. feladat:");
            Console.WriteLine("Kérem egy képpont adatait!");
            Console.Write("Sor: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Oszlop: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"A képpont színe {picture[x-1][y-1]}");
        }

        static void ReadFromFile(List<List<Color>> picture, string file)
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split();
                List<Color> row = new List<Color>();
                for (int i = 0; i < temp.Length; i += 3)
                {
                    Color c = new Color(temp[i], temp[i + 1], temp[i + 2]);
                    row.Add(c);
                }
                picture.Add(row);
            }
            sr.Close();
        }
    }
}
