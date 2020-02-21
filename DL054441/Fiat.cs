using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL054441
{
    public class Fiat : Dziedziczenie.IPojazd
    {
        public Silnik TwinAir { get; private set; }

        public void Jedz() => Jedz(10);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                TwinAir.Dzialaj();
            }
        }

        public Fiat(Benzyna silnik)
        {
            TwinAir = silnik;
        }

    }
    public class Benzyna : Silnik
    {
        public Benzyna(int moc, double spalanie) : base(moc, spalanie, "BooM")
        {

        }
    }

}
