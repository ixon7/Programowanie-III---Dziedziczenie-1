using System;
using Dziedziczenie;

namespace SS54488
{
    class Program
    {
        class Ferrari : IPojazd
        {
            public Silnik Silnik { get; set; }

            public Ferrari(Silnik silnik)
            {
                Silnik = silnik;
            }

            public void Jedz()
            {
                Jedz(10);
            }

            public void Jedz(int dystans)
            {
                ConsoleColor currentColor = Console.ForegroundColor;

                Console.WriteLine("Jedziemy! Zapnij pasy!");

                if (dystans < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                else if (dystans > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                for (int i = 0; i < dystans; i++)
                {
                    Silnik.Dzialaj();
                };

                Console.ForegroundColor = currentColor;

                Console.WriteLine("\nKoniec jazdy!\n");
            }
        }

        class SilnikFerrari : Silnik
        {
            public SilnikFerrari() : base(600, 13, "Wrrr") { }
        }

        class SilnikMalucha : Silnik
        {
            public SilnikMalucha() : base(35, 5, "Dup") { }
        }

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