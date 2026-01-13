using System;

namespace BookShop
{
    class Order
    {
        public int Id { get; }
        public int BookId { get; }
        public int Quantity { get; }
        public DateTime OrderDate { get; }

        public Order(int id, int bookId, int quantity, DateTime orderDate)
        {
            Id = id;
            BookId = bookId;
            Quantity = quantity;
            OrderDate = orderDate;
        }

        public override string ToString()
        {
            return $"BookId: {BookId}, Qty: {Quantity}, Date: {OrderDate:d}";
        }
    }
}
