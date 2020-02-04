using System;
using Dziedziczenie;

namespace pr055550
{
    public class Nissan : IPojazd
    {
        public Silnik1 Silnik { get; private set; }

        public void Jedz() => Jedz(100);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                if (i == 100)
                {
                    Console.WriteLine("Koniec jazdy");
                }
                if (i == 50)
                {
                    Console.WriteLine("Przejechano połowe dystansu");
                }
                if (i == 25)
                {
                    Console.WriteLine("Znajdujemy się w 1/4 drogi");
                }
                if (i < 100 && i > 50)
                {
                    Console.WriteLine("Mamy już ponad połowe dystansu");
                }
                if (i < 50 && i > 25)
                {
                    Console.WriteLine("Jestesmy juz poza 1/4 drogi");
                }
                if (i == 0)
                {
                    Console.WriteLine("Zaczynamy");
                }
                if (i > 0 && i < 25)
                {
                    Console.WriteLine("Jestes przed 1/4 drogi");
                }

                if (i == 95)
                {
                    Console.WriteLine("Juz prawie koniec");
                }
          
            }
        }
        public Nissan(Silnik1 silnik)
        {
            Silnik = silnik;
        }
    }
}
