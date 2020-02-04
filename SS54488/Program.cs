using System;
using Dziedziczenie;

namespace SS54488
{
    class Program
    {
        static void Main()
        {
            IPojazd ferrari = new Ferrari(new SilnikFerrari());
            IPojazd slabeFerrari = new Ferrari(new SilnikMalucha());

            ferrari.Jedz(13);

            slabeFerrari.Jedz(3);
            slabeFerrari.Jedz(10);

            Console.ReadKey();
        }
    }
}