using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    public class Infinitii : IPojazd
    {
        public Silnikinfi Silnik { get; private set; }

        public void Jedz() => Jedz(100);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                Silnik.Dzialaj();
            }
        }

        public Infinitii(Silnikinfi silnik)
        {
            Silnik = silnik;
        }
    }
}

    