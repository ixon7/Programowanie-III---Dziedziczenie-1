using System;
using Dziedziczenie;

namespace WP54462
{
    public class CyberTruck : IPojazd
    {
        public Silnik Silnik { get; private set; }
       
        public CyberTruck(SilnikElektryczny silnik)
        {
            Silnik = silnik;
        }
        public void Jedz() => Jedz(200);
        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                Silnik.Dzialaj();
            }
        }
    }
}
