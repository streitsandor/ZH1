using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication47
{
    public class Versenyzők
    {
        public float Kör;

        public int Lábak;

        public int Sebesség;

        public int Sorszám;

        public Versenyzők(int sorszám, int sebesség, int lábak, float kör)
        {
            Sorszám = sorszám;
            Sebesség = sebesség;
            Lábak = lábak;
            Kör = kör;
        }
    }
}