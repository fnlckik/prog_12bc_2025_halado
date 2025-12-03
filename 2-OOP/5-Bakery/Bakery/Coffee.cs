using System;

namespace Bakery
{
    // static: osztályszintű
    // -> az osztályhoz tartozik, nem az objektumhoz
    // -> nem kell példányosítani a használatához
    internal class Coffee : IProduct
    {
        private bool isMilky;
        public static int BASEPRICE = 480;

        public Coffee(bool isMilky)
        {
            this.isMilky = isMilky;
        }

        public int GetPrice()
        {
            if (!isMilky)
            {
                return BASEPRICE;
            }
            else
            {
                return (int)(Math.Round(1.5 * BASEPRICE));
            }
        }

        public override string ToString()
        {
            string type = this.isMilky ? "Tejeskávé" : "Kávé";
            return $"{type} - {this.GetPrice()} Ft";
        }
    }
}
