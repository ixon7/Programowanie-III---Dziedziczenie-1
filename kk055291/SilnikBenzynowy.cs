using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace kk055291
{
    public class SilnikBenzynowy : Silnik
    {
        public int MaksymalnyDystans;

        public SilnikBenzynowy(int moc, double spalanie, string dzwiek) : base(moc, spalanie, "Zium  ")
        {
            MaksymalnyDystans = 150;
        }
    }
}
