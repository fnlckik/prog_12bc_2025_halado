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

        // 0-tól (n-1)-ig helyett 1-től n-ig.
        // manager[1] => bands[0];
        public Band this[int i]
        {
            get
            {
                if (i < 1 || i > bands.Count)
                {
                    throw new IndexOutOfRangeException("Hiba! Nincs ilyen indexű zenekar.");
                }
                return bands[i-1];
            }
        }

        public void LoadFromFile(string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream) ReadBand(sr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ReadBand(StreamReader sr)
        {
            try
            {
                string[] temp = sr.ReadLine().Split(';');
                string name = temp[0];
                string genre = temp[1];
                int year = int.Parse(temp[2]);
                Band band = new Band(name, genre, year, temp[3], temp[4]);
                bands.Add(band);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Nem megfelelő adatok vannak a fájlban!");
                Console.WriteLine("Minta: <Név>;<Műfaj>;<Alapítási_év>;<Tagok...>;<Hangszerek...>");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Hiba: az alapítás éve nem egész szám.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
