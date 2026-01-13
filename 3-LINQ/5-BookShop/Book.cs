namespace BookShop
{
    class Book
    {
        public int Id { get; }
        public string Title { get; }
        public int AuthorId { get; }
        public string Genre { get; }
        public int Year { get; }
        public int Pages { get; }
        public int Price { get; }

        public Book(int id, string title, int authorId, string genre, int year, int pages, int price)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
            Genre = genre;
            Year = year;
            Pages = pages;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Title} ({Year}) – {Genre}, {Pages} oldal, {Price} Ft";
        }
    }
}
