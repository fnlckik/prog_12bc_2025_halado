
namespace Bakery
{
    internal abstract class BakedItem : IProduct
    {
        protected int quantity;
        private int price;

        public BakedItem(int quantity, int price)
        {
            this.quantity = quantity;
            this.price = price;
        }

        public abstract void Buy(int n);

        public int GetPrice()
        {
            return quantity * price;
        }

        public virtual string GetCategory()
        {
            return "Péksütemény";
        }

        public override string ToString()
        {
            return $"{quantity} db - {GetPrice()} Ft";
        }
    }
}
