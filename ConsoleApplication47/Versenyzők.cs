using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication47
{
    public class Versenyzők
    {
        private float Kör;

        private int Lábak;

        private int Sebesség;

        private int Sorszám;

        public Versenyzők(int Sorszám, int Sebesség, int Lábak, float Kör)
        {
            this.Sorszám = Sorszám;
            this.Sebesség = Sebesség;
            this.Lábak = Lábak;
            this.Kör = Kör;
        }

        public float Lépés { set { Kör = Kör + 1 * Sebesség; } }

    }
}