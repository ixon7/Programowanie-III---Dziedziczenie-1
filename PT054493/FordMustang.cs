using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace PT054493
{
    public class FordMustang : IPojazd
    {
        private Silnik silniczek;
        private Random rand;


        private readonly int _maxObroty = 8000;
        private readonly int _minObroty = 1200;
        private readonly double _maxPaliwo = 50.0;


        private double _aktualneSpalanie;
        private double _iloscPaliwa;
        private int _obroty;


        public double IloscPaliwa { get => _iloscPaliwa--; private set => _iloscPaliwa = value; }
        public int Obroty
        {
            get
            {
                return _obroty;
            }
            private set
            {
                //if (value < _maxObroty && value > _minObroty)
                _obroty = value;
            }
        }
        public double AktualneSpalanie
        {
            get
            {
                return (((Obroty - 1000.0) / 1000.0) * (silniczek.Spalanie / 1.9));
            }
        }


        public FordMustang(Silnik silniczek)
        {
            this.silniczek = silniczek;
        }



        public void Jedz() => Jedz(100);

        public void Jedz(int dystans)
        {
            rand = new Random();

            for (int i = 0; i < dystans; i++)
            {
                if (IloscPaliwa <= 10)
                {
                    Obroty = 0;
                    --i;
                    for (int j = 0; j < _maxPaliwo; j++)
                    {
                        Console.WriteLine("Tankujemy");
                        IloscPaliwa++;
                    }
                }
                silniczek.Dzialaj();
                
                Obroty = rand.Next(_minObroty, _maxObroty);
                Console.Write(", {0}, Ilosc paliwa = {1}, Spalanko = {2}", Obroty, IloscPaliwa, Math.Round(AktualneSpalanie, 1));

                Console.WriteLine();
            }
        }
    }
}
