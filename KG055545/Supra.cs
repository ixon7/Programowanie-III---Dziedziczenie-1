using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace KG055545
{
    class Supra : IPojazd
    {
        public V8_6 Silnik_v8 { get; set; }
        public double BakPaliwa { get; set; }
        public int Bieg { get; set; } = 1;
        public void Jedz() => Jedz(250);
        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                if (i > 0 && dystans % i == 0)
                {
                    if (Bieg < 6)
                    {
                        Bieg++;
                        Console.WriteLine("\nZmiana biegu na {0}\n", Bieg);
                    }
                }

                //else if (i == 80) Console.WriteLine("\nZmiana biegu na 3\n");
                //else if (i == 130) Console.WriteLine("\nZmiana biegu na 4\n");
                //else if (i == 160) Console.WriteLine("\nZmiana biegu na 5\n");
                //else if (i == 220) Console.WriteLine("\nZmiana biegu na 6\n");

                Silnik_v8.Dzialaj();
                BakPaliwa -= Silnik_v8.Spalanie/100;
                if (BakPaliwa < 0)
                {
                    Console.WriteLine("\nBRAK PALIWA!!!");
                    return;
                }

                Console.WriteLine("\tPojemność baku: {0}", Math.Round(BakPaliwa, 2));  // String.Format("{0:N2}", BakPaliwa) <-- alternatywa Math.Round
            }

        }

        public Supra(V8_6 silnik, double bak)
        {
            Silnik_v8 = silnik;
            BakPaliwa = bak;
        }

    }
}
