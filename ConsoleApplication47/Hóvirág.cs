using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication47
{
    public class Hóvirág : Versenyzők
    {
        private int mSorszám;
        private int mSebesség;
        private int mLábak;
        private float mKör;

        public Hóvirág(int Sorszám, int Sebesség, int Lábak, float Kör) : base(Sorszám, Sebesség, Lábak, Kör)
        {
            mSorszám = Sorszám;
            mSebesség = Sebesség;
            mLábak = Lábak;
            mKör = Kör;
        }

        public void Kiír()
        {
            StringBuilder g = new StringBuilder();
            g.AppendFormat("Sorszám:{0}", "Sebesség:{1}", "Lábak:{2}", "Kör:{3}", mSorszám.ToString(), mSebesség.ToString(), mLábak.ToString(), mKör.ToString());
            Console.WriteLine(g);
        }
    }
}