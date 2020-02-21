using System;
using System.Collections.Generic;
using System.Text;

namespace JK054428
{
    public class Silnik
    {

        public int Moc { get; set; }

        public double Spalanie { get; set; }

        public string Dzwiek { get; set; }

        public void Dzialaj()
        {
            Console.WriteLine(Dzwiek + " ");
        }

        public Silnik(int moc, double spalanie, string dzwiek)
        {
            Moc = moc;
            Spalanie = spalanie;
            Dzwiek = dzwiek;
        }

    }
}
