using System;
using System.Collections.Generic;
using System.IO;

namespace Bands
{
    internal class Manager
    {
        private string name;
        private List<Band> bands;

        public Manager(string name)
        {
            this.name = name;
            this.bands = new List<Band>();
        }

        public void LoadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                string name = temp[0];
                string genre = temp[1];
                int year = int.Parse(temp[2]);
                Band band = new Band(name, genre, year, temp[3], temp[4]);
                bands.Add(band);
            }
            sr.Close();
        }

        public Band OldestBand()
        {
            Band oldest = bands[0];
            foreach (Band band in bands)
            {
                if (band.Age() > oldest.Age())
                {
                    oldest = band;
                }
            }
            return oldest;
        }

        public void OrderByMembersCount()
        {
            for (int i = 0; i < bands.Count; i++)
            {
                for (int j = 0; j < bands.Count - i - 1; j++)
                {
                    if (bands[j].MemberCount < bands[j+1].MemberCount)
                    {
                        (bands[j], bands[j + 1]) = (bands[j + 1], bands[j]);
                    }
                }
            }

            Console.WriteLine("Bandák létszám szerint csökkenő sorrendben:");
            foreach (Band band in bands)
            {
                Console.WriteLine(band);
            }
        }

        public void InstrumentFrequency()
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach (Band band in bands)
            {
                foreach (string instrument in band.Instruments)
                {
                    if (freq.ContainsKey(instrument))
                    {
                        freq[instrument]++;
                    }
                    else
                    {
                        freq.Add(instrument, 1);
                    }
                }
            }

            StreamWriter sw = new StreamWriter("frequency.txt");
            sw.WriteLine($"{this.name} által menedzselt bandák hangszerei:");
            foreach (string instrument in freq.Keys)
            {
                sw.WriteLine($"{instrument}: {freq[instrument]} db");
            }
            sw.Close();
        }
    }
}
