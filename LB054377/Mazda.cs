using System;
using Dziedziczenie;
using System.Collections.Generic;
using System.Text;

namespace LB054377
{
    class Mazda : IPojazd
    {
        public Silnik Silnik { get; private set; }

        public void Jedz() => Jedz(250);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                if (dystans > 240 & i == 245)
                {
                    Console.WriteLine("\nPajac w BMW!"); Console.WriteLine("Wypadek!"); Console.WriteLine("Karetka"); Console.WriteLine("Cmentarz");
                    break;
                }
                if (i % 25 == 1) { Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("Zmiana biegu!!"); Console.ForegroundColor = ConsoleColor.White; }
                Silnik.Dzialaj();
            }
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Koniec wrum :("); Console.ForegroundColor = ConsoleColor.White;
        }

        public Mazda(Skyactive silnik)
        {
            Silnik = silnik;
        }
    }
}
