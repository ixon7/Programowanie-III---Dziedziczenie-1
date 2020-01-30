using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    public class Ciezarowka : IPojazd
    {
        public Silnik Silnik { get; private set; }

        public void Jedz() => Jedz(100);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                Silnik.Dzialaj();
            }
        }

        public Ciezarowka(SilnikDiesla silnik)
        {
            Silnik = silnik;
        }
    }
}
