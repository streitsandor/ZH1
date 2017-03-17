using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication47
{
    public class Másnapos_a_szöcske : Versenyzők
    {

        public Másnapos_a_szöcske(int Sorszám, int Sebesség, int Lábak, float Kör) : base(Sorszám, Sebesség, Lábak, Kör)
        {
            this.Sorszám = Sorszám;
            this.Sebesség = Sebesség;
            this.Lábak = Lábak;
            this.Kör = Kör;
        }

        public void Lép()
        {
            Random rnd = new Random();
            Sebesség = rnd.Next(-1, 2);

            Lépés = Kör;
        }
    }
}