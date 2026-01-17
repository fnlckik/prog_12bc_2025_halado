using System;

namespace SportsCompetition
{
    class SportEvent
    {
        public int ID { get; }
        public string Name { get; }
        public string Type { get; }
        public DateTime Date { get; }

        public SportEvent(int id, string name, string type, DateTime date)
        {
            ID = id;
            Name = name;
            Type = type;
            Date = date;
        }

        public override string ToString() => $"{Name} ({Type}) – {Date:d}";
    }
}
