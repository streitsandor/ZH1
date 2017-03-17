using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication47
{
    public class Hóvirág : Versenyzők
    {
        public Hóvirág(int Sorszám, int Sebesség, int Lábak, float Kör) : base(Sorszám, Sebesség, Lábak, Kör)
        {
            this.Sorszám = Sorszám;
            this.Sebesség = Sebesség;
            this.Lábak = Lábak;
            this.Kör = Kör;
        }
    }
}