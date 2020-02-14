using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace MS055452
{
    class Passeratti : IPojazd
    {
        public Silnik Silnik { get; private set; }
        public void Jedz() => Jedz(100);
        public void Jedz(int dystans)
        {
            var naFarcie = new Random();
            var zasieg = 80 + naFarcie.Next(1, 69);
            for (int i = 0; i < zasieg; i++)
            {
                Silnik.Dzialaj();
            }
            if (dystans>zasieg)
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("KABOOM! \t \t \t");
                Console.ResetColor();
            }
        }
        public Passeratti(SilnikTuningExtraPlus silnik)
        {
            Silnik = silnik;
        }
    }
}
