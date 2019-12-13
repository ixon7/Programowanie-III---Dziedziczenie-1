using Dziedziczenie;
using System;
namespace LP054466
{
   public class Honda : IPojazd
    {
        public Silnik Silnik { get; private set; }

        public void Jedz() => Jedz(230);


        public void Jedz(int dystans)
        {
            if (dystans < 60)
            {
                Console.WriteLine($"{dystans} km: Wyjazd z Polski");
                Console.WriteLine();
            }
            if (dystans >= 60 && dystans < 100)
            {
                Console.WriteLine($"{dystans} km: Terytorium czeskie");
                Console.WriteLine();
            }
            if (dystans >= 100 && dystans < 140)
            {
                Console.WriteLine($"{dystans} km: Zbliżamy się do granicy z Niemcami");
                Console.WriteLine();
            }
            if (dystans >= 140 && dystans < 230)
            {
                Console.WriteLine($"{dystans} km: Terytorium niemieckie");
                Console.WriteLine();
            }
            if (dystans == 230)
            {
                Console.WriteLine($"{dystans} km: Cel podróży");
                Console.WriteLine();
            }

        }
        public Honda(SilnikS silnik)
        {
            Silnik = silnik;
        }

        public Honda(SilnikM silnik)
        {
            Silnik = silnik;
        }

    }
}
