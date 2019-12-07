using System;
using System.ComponentModel.DataAnnotations;
using Dziedziczenie;

namespace ps_055294
{
    class Program
    {
        static void Main(string[] args)
        {
            var czerwonyPunciak = new Punciak(new SilnikBenzynowy(5, 5, "brum", 0));
            czerwonyPunciak.Jedz();
        }
    }

    public class Punciak : IPojazd
    {
        public Silnik Silnik { get; private set; }

        public void Jedz() => Jedz(1000);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                Silnik.Dzialaj();
                SilnikBenzynowy.zwiekszPrzebieg();
                if (SilnikBenzynowy.Przebieg1 > 10000)
                {
                    Zepsuj();
                }
            }
        }

        public void Zepsuj()
        {
            throw new Exception("Punciak Kaput");
        }

        public Punciak(SilnikBenzynowy silnik)
        {
            Silnik = silnik;
        }
    }

    public class SilnikBenzynowy : Silnik
    {
        private static int Przebieg;

        public SilnikBenzynowy(int moc, double spalanie, string dzwiek, int przebieg) : base(moc, spalanie, dzwiek)
        {
            Przebieg = przebieg;
        }


        public static int Przebieg1
        {
            get => Przebieg;
            set => Przebieg = value;
        }


        public static void zwiekszPrzebieg()
        {
            Przebieg += 1;
        }
    }
}