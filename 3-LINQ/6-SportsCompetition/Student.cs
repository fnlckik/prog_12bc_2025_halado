namespace SportsCompetition
{
    class Student
    {
        public int ID { get; }
        public string Name { get; }
        public int Grade { get; } // évfolyam
        public char Class { get; } // osztály

        public Student(int id, string name, int grade, char @class)
        {
            ID = id;
            Name = name;
            Grade = grade;
            Class = @class;
        }

        public override string ToString() => $"{Name} ({Grade}.{Class})";
    }
}
