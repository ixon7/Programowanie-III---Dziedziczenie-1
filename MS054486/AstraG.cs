using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{

    class AstraG : IPojazd
    {
        private SilnikElektryczny silnik;

        public AstraG(SilnikElektryczny silnik)
        {
            this.silnik = silnik;
        }
        public void Jedz()
        {
            this.Jedz(50);
        }

        public void Jedz(int dystans)
        {
            for (int i = 1; i <= dystans; i++)
            {
                if (i > silnik.MaksymalnyDystans)
                {
                    Console.WriteLine("Rozładowany akumulator ;C");
                    break;
                }
                Console.WriteLine(i + "km..." + silnik.Dzwiek);
            }
        }
    }
}
