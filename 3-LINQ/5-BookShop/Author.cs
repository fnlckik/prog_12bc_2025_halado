namespace BookShop
{
    class Author
    {
        public int Id { get; }
        public string Name { get; }
        public string Country { get; }

        public Author(int id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Name} ({Country})";
        }
    }
}
