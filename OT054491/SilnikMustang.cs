using System;
using Dziedziczenie;

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
}