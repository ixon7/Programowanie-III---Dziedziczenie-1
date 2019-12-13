using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace MR054473
{
    public class Ford : IPojazd
    {
        public void Jedz() => Jedz(200);

        public SilnikElektryczny Silnik { get; private set; }
        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                Silnik.Dzialaj();

            } 

        }

        public Ford(SilnikElektryczny silnik)
        {
            Silnik = silnik;
        }
    }
}
