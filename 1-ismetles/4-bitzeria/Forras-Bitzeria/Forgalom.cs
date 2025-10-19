using System;
using System.Collections.Generic;
using System.IO;

namespace Bitzeria
{
    internal class Forgalom
    {
        private List<Rendeles> rendelesek;

        public Forgalom(string fileName)
        {
            rendelesek = new List<Rendeles>();
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                string megjegyzes = sr.ReadLine();
                string nev = temp[0];
                bool kupon = temp[1] == "1";
                //bool kupon = Convert.ToBoolean(temp[1]);
                int koltseg = int.Parse(temp[2]);
                Rendeles r = new Rendeles(nev, kupon, koltseg, megjegyzes);
                rendelesek.Add(r);
            }
            sr.Close();
        }

        public int OrderCount { get => rendelesek.Count; }

        public Rendeles Legdragabb()
        {
            Rendeles maxRendeles = rendelesek[0];
            foreach (Rendeles rendeles in rendelesek)
            {
                if (rendeles.Fizetendo > maxRendeles.Fizetendo)
                {
                    maxRendeles = rendeles;
                }
            }
            return maxRendeles;
        }

        public void KupontalanokFajlba()
        {
            HashSet<string> nevek = new HashSet<string>();
            HashSet<string> kuponosak = new HashSet<string>(); // akik használtak kupont
            foreach (Rendeles rendeles in rendelesek)
            {
                nevek.Add(rendeles.Nev);
                if (rendeles.Kupon) kuponosak.Add(rendeles.Nev);
            }

            nevek.ExceptWith(kuponosak);
            StreamWriter sw = new StreamWriter("nevek.txt");
            foreach (string nev in nevek)
            {
                sw.WriteLine(nev);
            }
            sw.Close();
        }
    }
}
