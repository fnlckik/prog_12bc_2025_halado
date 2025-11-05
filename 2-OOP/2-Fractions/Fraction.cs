using System;

namespace _2_Fractions
{
    internal class Fraction
    {
        // numerator, denominator: a / b
        private int a;
        private int b;

        public Fraction(int a, int b)
        {
            if (b == 0)
            {
                string message = $"Hiba: {a}/{b}. Nem lehet 0-val osztani.";
                throw new DivideByZeroException(message);
            }
            this.a = a;
            this.b = b;
        }

        public double Value { get => (double)a / b; }

        // => 2 / 3
        public override string ToString()
        {
            return $"{this.a} / {this.b}";
        }

        public static bool operator ==(Fraction x, Fraction y)
        {
            x = x.Simplify();
            y = y.Simplify();
            return x.a == y.a && x.b == y.b;
        }

        public static bool operator !=(Fraction x, Fraction y)
        {
            return !(x == y);
        }

        public Fraction Simplify()
        {
            int a = this.a;
            int b = this.b;
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            } // b: legnagyobb közös osztó
            return new Fraction(this.a / b, this.b / b);
        }
    }
}
