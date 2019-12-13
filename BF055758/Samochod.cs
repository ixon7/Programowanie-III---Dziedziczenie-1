using System;
using Dziedziczenie;

namespace BF055758
{
    public class Samochod: IPojazd
    {
        public SilnikElektryczny Silnik = new SilnikElektryczny(100);

        public int ZasiegBaterii;

        private int aktualneNaladowanieBaterii;

        private bool stop = false;

        public Samochod(int zasiegBaterii)
        {
            ZasiegBaterii = zasiegBaterii;
            aktualneNaladowanieBaterii = zasiegBaterii;
        }

        public void Jedz()
        {
            if (aktualneNaladowanieBaterii == 0)
            {
                Console.WriteLine("\nBateria pusta. Nie da sie jechac dalej");
                stop = true;
            }
            else
            {
                Silnik.Dzialaj();
                aktualneNaladowanieBaterii -= 1;
            }
        }

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                if (stop)
                {
                    Console.WriteLine("\nPrzejechano: " + i + "km");
                    return;
                }
                Jedz();
            }
            Console.WriteLine("\nPrzejechano: " + dystans + "km");
        }
    }
}