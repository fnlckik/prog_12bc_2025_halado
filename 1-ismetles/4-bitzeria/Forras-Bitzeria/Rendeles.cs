using System;

namespace Bitzeria
{
    internal class Rendeles
    {
        // Adattagok, Field
        private string nev;
        private bool kupon;
        private int koltseg;
        private string megjegyzes;

        // Konstruktorok
        // function overload
        public Rendeles()
        {
            this.nev = "";
            this.kupon = false;
            this.koltseg = 0;
            this.megjegyzes = "";
        }

        public Rendeles(string nev, bool kupon, int koltseg, string megjegyzes)
        {
            this.nev = nev;
            this.kupon = kupon;
            this.koltseg = koltseg;
            this.megjegyzes = megjegyzes;
        }

        // Getter, Setter
        public string Nev { get => nev; }
        public bool Kupon { get => kupon; }
        public int Koltseg { get => koltseg; }

        public int Fizetendo
        {
            get
            {
                if (kupon) return (int)(koltseg * 0.85); // 1241.51
                else return koltseg;
            }
        }

        // Metódusok
        public override string ToString()
        {
            return $"{nev} ({Fizetendo} Ft): {megjegyzes}";
        }
    }
}
