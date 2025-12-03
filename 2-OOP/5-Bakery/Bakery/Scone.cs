using System;

namespace Bakery
{
    internal class Scone : BakedItem
    {
        public string type;

        public Scone(int quantity, int price, string type)
               : base(quantity, price)
        {
            this.type = type;
        }

        public override void Buy(int n)
        {
            if (quantity - n >= 10)
            {
                quantity -= n;
            }
            else
            {
                throw new ArgumentException("Nem vásárolható ennyi pogácsa.");
            }
        }

        public sealed override string GetCategory()
        {
            return $"{this.type} Pogácsa";
        }

        public override string ToString()
        {
            return this.GetCategory() + " " + base.ToString();
        }
    }
}
