using Dziedziczenie;
using System;

namespace DL054441
{
    class Program
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

        static void Main(string[] args)
        {

            Fiat Bravo = new Fiat(new Benzyna(120,5.5));
            Bravo.Jedz(150);

        }
    }
}
