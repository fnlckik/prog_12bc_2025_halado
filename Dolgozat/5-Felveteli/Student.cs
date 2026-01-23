using System;

namespace EntranceExam
{
    internal class Student
    {
        public int ID { get; }
        public string Name { get; }
        public string School { get; } // Általános iskola neve
        public bool IsLocal { get; } // Helyi diák? (Ceglédi?)
        public DateTime Birth { get; }
        public int MathGrade { get; } // 8. osztályos félévi jegye

        public Student(int id, string name, string school, bool isLocal, DateTime birth, int mathGrade)
        {
            ID = id;
            Name = name;
            School = school;
            IsLocal = isLocal;
            Birth = birth;
            MathGrade = mathGrade;
        }

        public override string ToString()
        {
            return $"{Name} ({Birth:d}), {School}, matek jegy: {MathGrade}, helyi: {(IsLocal ? "igen" : "nem")}";
        }
    }
}
