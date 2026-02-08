using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Tergeometria
{
    internal interface IShape
    {
        double R { get; set; }
        double H { get; set; }
        double Area { get; }
        double Volume { get; }
    }

    internal class Sphere : IShape
    {
        public Sphere(double r)
        {
            R = r;
            H = 0;
        }

        public double R { get; set; }
        public double H { get; set; }

        public double Area => 4 * R * R * Math.PI;

        public double Volume => 4 * R * R * R * Math.PI / 3;
    }
}
