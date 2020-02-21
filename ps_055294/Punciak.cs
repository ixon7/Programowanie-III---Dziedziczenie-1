using System;
using Dziedziczenie;

namespace ps_055294
{
    public class Punciak : IPojazd
    {
        public Silnik Silnik { get; private set; }

        public void Jedz() => Jedz(1000);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                Silnik.Dzialaj();
                SilnikBenzynowy.zwiekszPrzebieg();
                if (SilnikBenzynowy.Przebieg1 > 10000)
                {
                    Zepsuj();
                }
            }
        }

        public void Zepsuj()
        {
            throw new Exception("Punciak Kaput");
        }

        public Punciak(SilnikBenzynowy silnik)
        {
            Silnik = silnik;
        }
    }
}