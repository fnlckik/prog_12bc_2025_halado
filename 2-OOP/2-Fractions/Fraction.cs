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
            // "- 1 / 2"
            string sign = ((this.a < 0) ^ (this.b < 0)) ? "- " : "";
            return $"{sign}{Math.Abs(this.a)} / {Math.Abs(this.b)}";
        }

        public static bool operator ==(Fraction x, Fraction y)
        {
            //x = x.Simplify();
            //y = y.Simplify();
            //return x.a == y.a && x.b == y.b;
            return x.a * y.b == x.b * y.a;
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

        public static Fraction operator *(Fraction x, Fraction y)
        {
            Fraction result = new Fraction(x.a * y.a, x.b * y.b);
            return result.Simplify();
        }

        public static Fraction operator +(Fraction x, Fraction y)
        {
            Fraction result = new Fraction(x.a * y.b + y.a * x.b, x.b * y.b);
            return result.Simplify();
        }

        public static Fraction operator *(int c, Fraction x)
        {
            Fraction result = new Fraction(c * x.a, x.b);
            return result.Simplify();
        }

        public static Fraction operator *(Fraction x, int c)
        {
            return c * x;
        }

        public static Fraction operator -(Fraction x, Fraction y)
        {
            return x + (-1) * y;
        }
    }
}
