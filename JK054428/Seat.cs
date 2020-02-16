using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace JK054428
{
    public class Seat : IPojazd
    {
        public Silnik Silnik { get; set; }

        public void Jedz() => Jedz(400);


        public void Jedz(int dystans)
        {
            for (int i = 0; i <= dystans; i++)
            {
                if (i == 400)
                {
                    Console.WriteLine("Zatankuj samochód!");
                }

                Console.Write($"{i} km.   ");
                Silnik.Dzialaj();
            }
        }

        public Seat(SilnikSpalinowy silnik)
        {
            Silnik = silnik;
        }
    }
}
