using System;

namespace Game
{
    internal static class Rng
    {
        public static Random r = new Random();

        public static int Randint(int a, int b)
        {
            return r.Next(a, b + 1);
        }
    }
}
