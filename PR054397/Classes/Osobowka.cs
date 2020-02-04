using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace PR054397
{
    class Osobowka : IPojazd
    {
        public Silnik Silnik { get; private set; }
        public void Jedz()
        {
            Console.WriteLine("Twoj super inteligenty google car nie wie ile ma jechac");
        }

        public void Jedz(int dystans)
        {
            for (int i = 1; i <= dystans; i++)
            {
                Silnik.Dzialaj();
                Console.WriteLine($"{i} km przejechane");
            }
            Console.WriteLine("Przelaczam na turbo");

            int t = 20;
            SilnikElektryczny turbo = new SilnikElektryczny(t, 2, "bzzzz");
            for (int i = 1; i <= t; i++)
            {
                turbo.Dzialaj();
                Console.WriteLine($"Dodatkowo przejechano {i} km ");
            }


        }

        public Osobowka(SilnikBenzyna silnik)
        {
            Silnik = silnik;
        }
    }
}
