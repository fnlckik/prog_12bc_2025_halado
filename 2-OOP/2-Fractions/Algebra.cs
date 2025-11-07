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

        public List<Fraction> Fractions => new List<Fraction>(fractions);
    }
}
