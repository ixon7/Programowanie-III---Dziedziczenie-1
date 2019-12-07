using Dziedziczenie;
using System;

namespace OT054491
{

    class SilnikMustang : Silnik
    {
        public SilnikMustang(int moc, double spalanie, string dzwiek) : base(moc, spalanie, dzwiek)
        {
            if(spalanie < 5)
                Console.WriteLine("W sam raz dla żony!");
        }

        public void Dzialaj()
        {
            if (this.Moc <= 0)
            {
                Console.WriteLine("To przeczy prawom fizyki");
                base.Dzialaj();
                Console.WriteLine("Cos sie popsulo");
                Environment.Exit(0);
            }
        }
    }
    
    
    class Mustang : IPojazd
    {
        public void Jedz()
        {
            Jedz(200, 100, 12.1, "Krach");
        }
        public void Jedz(int dystans)
        {
            Jedz(dystans, 200, 15, "Bruuuum");
        }
        
        public void Jedz(int dystans, int moc, double spalanie, string dzwiek)
        {
            SilnikMustang silnik = new SilnikMustang(moc, spalanie, dzwiek);
            for (int i = 0; i < dystans; i++)
            {
                silnik.Dzialaj();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Mustang auto = new Mustang();
            auto.Jedz(100, 200, 4, "Wrrr");
        }
    }
}