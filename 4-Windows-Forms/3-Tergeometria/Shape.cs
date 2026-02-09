using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Tergeometria
{
    internal abstract class Shape
    {
        public double r;
        public double h;

        protected Shape(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        public abstract double Area { get; }
        public abstract double Volume { get; }
    }

    internal class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area => 4 * r * r * Math.PI;

        public override double Volume => 4 * r * r * r * Math.PI / 3;

        public override string ToString()
        {
            return $"Gömb: R = {r}";
        }
    }

    internal class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area => 2 * r * r * Math.PI + 2 * r * Math.PI * h;

        public override double Volume => r * r * Math.PI * h;

        public override string ToString()
        {
            return $"Henger: R = {r}, M = {h}";
        }
    }

    internal class Cone : Shape
    {
        public Cone(double r, double h) : base(r, h)
        {
        }

        public override double Area
        {
            get
            {
                double a = Math.Sqrt(h * h + r * r); // alkotó
                return r * r * Math.PI + a * r * Math.PI;
            }
        }

        public override double Volume => r * r * Math.PI * h / 3;

        public override string ToString()
        {
            return $"Kúp: R = {r}, M = {h}";
        }
    }
}
