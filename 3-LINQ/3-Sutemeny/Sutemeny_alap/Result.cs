namespace Sutemeny
{
    internal class Result
    {
        public Result(string name, int popularity, double point)
        {
            Name = name;
            Popularity = popularity;
            Point = point;
        }

        public string Name { get; }
        public int Popularity { get; }
        public double Point { get; }

        public override string ToString()
        {
            return $"{this.Name}; {this.Popularity}; {this.Point}";
        }
    }
}
