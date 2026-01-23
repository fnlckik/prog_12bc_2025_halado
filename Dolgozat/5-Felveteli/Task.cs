namespace EntranceExam
{
    internal class Task
    {
        public int ID { get; }
        public string Topic { get; }
        public string Description { get; }
        public int MaxPoint { get; }

        public Task(int id, string topic, string description, int maxPoint)
        {
            ID = id;
            Topic = topic;
            Description = description;
            MaxPoint = maxPoint;
        }

        public override string ToString()
        {
            return $"{ID}. feladat, {Topic} – {Description} ({MaxPoint} pont)";
        }
    }
}
