using System;

namespace TripReview
{
    internal class Traveller
    {
        public Traveller(int iD, string name, string email, DateTime birthDate)
        {
            ID = iD;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public int ID { get; }
        public string Name { get; }
        public string Email { get; }
        public DateTime BirthDate { get; }

        public override string ToString()
        {
            return $"{Name} ({BirthDate.Year})";
        }
    }
}
