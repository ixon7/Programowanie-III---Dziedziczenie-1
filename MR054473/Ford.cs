using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace MR054473
{
    public class Ford : IPojazd
    {
        private Silnik silnik;
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
                
                _obroty = value;
            }
        }
        public double AktualneSpalanie
        {
            get
            {
                return (((Obroty - 1000.0) / 1000.0) * (silnik.Spalanie / 1.9));
            }
        }


        public Ford(Silnik silniczek)
        {
            this.silnik = silniczek;
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
                silnik.Dzialaj();

                Obroty = rand.Next(_minObroty, _maxObroty);
                Console.Write(", {0}, Ilosc paliwa = {1}, Spalanko = {2}", Obroty, IloscPaliwa, Math.Round(AktualneSpalanie, 1));

                Console.WriteLine();
            }
        }
    }
}
