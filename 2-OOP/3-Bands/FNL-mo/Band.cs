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
                if (value.Length >= 3)
                {
                    this.name = value;
                }
            }
        }

        public HashSet<string> Instruments { get => new HashSet<string>(instruments); }

        public int MemberCount { get => members.Count; }

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
