using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace kk055291
{
    class Corshe : IPojazd
    {
        public SilnikBenzynowy silnik;

        public Corshe(SilnikBenzynowy silnik)
        {
            this.silnik = silnik;
        }

        public void Jedz() => Jedz(100);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i += 10)
            {
                if (i > silnik.MaksymalnyDystans)
                {
                    Console.WriteLine("Koniec benzyny !!");
                    break;
                }
                Console.WriteLine(i + " km " + silnik.Dzwiek);
            }
        }
    }
}
