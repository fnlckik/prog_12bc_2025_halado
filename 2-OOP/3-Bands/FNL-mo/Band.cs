using System;
using System.Collections.Generic;

namespace Bands
{
    internal class Band
    {
        private string name;
        private string genre;
        private int foundedYear;
        private List<string> members;
        private HashSet<string> instruments;

        public Band(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
            this.foundedYear = DateTime.Now.Year;
            this.members = new List<string>();
            this.instruments = new HashSet<string>();
        }

        public Band(string name, string genre, int year, string members, string instruments)
        {
            if (year < 0 || year > DateTime.Now.Year)
            {
                string msg = $"year. Az alapítás éve 0 és {DateTime.Now.Year} között legyen.";
                throw new ArgumentOutOfRangeException(msg);
            }
            this.name = name;
            this.genre = genre;
            this.foundedYear = year;
            this.members = new List<string>(members.Split(','));
            this.instruments = new HashSet<string>(instruments.Split(','));
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Hiba: A zenekar neve legalább 3 karakter kell legyen.");
                }
                this.name = value;
            }
        }

        public HashSet<string> Instruments { get => new HashSet<string>(instruments); }

        public int MemberCount { get => members.Count; }

        public static bool operator <(Band x, Band y)
        {
            return x.MemberCount < y.MemberCount;
        }

        public static bool operator >(Band x, Band y)
        {
            //return !(x < y); // x >= y
            return x.MemberCount > y.MemberCount;
        }

        public static bool operator >=(Band x, Band y)
        {
            return !(x < y);
        }

        public static bool operator <=(Band x, Band y)
        {
            return !(x > y);
        }

        public int Age()
        {
            return DateTime.Now.Year - this.foundedYear;
        }

        public override string ToString()
        {
            return $"{this.name} ({this.genre}) – Alapítva: {this.foundedYear}";
        }
    }
}
