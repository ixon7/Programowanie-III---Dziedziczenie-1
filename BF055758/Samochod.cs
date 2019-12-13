using System;
using Dziedziczenie;

namespace BF055758
{
    public class Samochod: IPojazd
    {
        public SilnikElektryczny Silnik = new SilnikElektryczny(100);

        public int ZasiegBaterii;
        public int CzasLadowaniaMin;

        private int aktualneNaladowanieBaterii;

        private bool stop = false;

        public Samochod(int zasiegBaterii, int czasLadowaniaMin)
        {
            ZasiegBaterii = zasiegBaterii;
            aktualneNaladowanieBaterii = zasiegBaterii;
            CzasLadowaniaMin = czasLadowaniaMin;
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
                    Console.WriteLine("Przejechano: " + i + "km");
                    return;
                }
                Jedz();
            }
            Console.WriteLine("\nPrzejechano: " + dystans + "km");
        }

        public void Laduj()
        {
            Console.Write("Ladowanie ");
            for (int i = 0; i < CzasLadowaniaMin; i++)
            {
                System.Threading.Thread.Sleep(10);
                Console.Write(".");
            }
            Console.WriteLine("\nNaladowano!");
            aktualneNaladowanieBaterii = ZasiegBaterii;
            stop = false;
        }
    }
}