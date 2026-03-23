namespace Kings
{
    internal class King
    {
        public King(string name, int year, string place, int start, int end, string dynasty)
        {
            Name = name;
            Year = year;
            Place = place;
            Start = start;
            End = end;
            Dynasty = dynasty;
        }

        public string Name { get; }
        public int Year { get; }
        public string Place { get; }
        public int Start { get; }
        public int End { get; }
        public string Dynasty { get; }
    }
}
