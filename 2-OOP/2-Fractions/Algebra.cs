using System;
using System.Collections.Generic;
using System.IO;

namespace _2_Fractions
{
    internal class Algebra
    {
        private List<Fraction> fractions;

        public Algebra(string fileName)
        {
            fractions = new List<Fraction>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream) ReadLine(sr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ReadLine(StreamReader sr)
        {
            try
            {
                string[] temp = sr.ReadLine().Split('/');
                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[1]);
                Fraction f = new Fraction(a, b); // 4 / 0
                fractions.Add(f);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //public List<Fraction> Fractions => new List<Fraction>(fractions);

        public Fraction this[int i]
        {
            get
            {
                if (i < 0 || i > fractions.Count-1)
                {
                    string msg = $"Hiba: kiindexelés. Az indexek értéke 0 és {fractions.Count - 1} között kell legyen.";
                    throw new IndexOutOfRangeException(msg);
                }
                return new Fraction(fractions[i]);
            }
        }

        public Fraction SumOfFractions()
        {
            Fraction s = new Fraction(0, 1);
            foreach (Fraction fraction in fractions)
            {
                s += fraction; // s = s + fraction
            }
            return s;
        }
    }
}
