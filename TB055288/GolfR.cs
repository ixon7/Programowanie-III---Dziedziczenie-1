using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace TB055288
{
    public class GolfR : IPojazd
    {
        public Silnik silnik { get; set; }
        public int Przyspieszenie;
        
        public void Jedz() => Jedz(150);

        public void Jedz(int dystans)
        {
            
            for (int i = 0; i < dystans; i++)
            {
                Przyspieszenie += 2;
                if (i % 25 == 0)
                    Console.WriteLine(Przyspieszenie + " km/h");
                    
                Console.WriteLine(" ");
                silnik.Dzialaj();
            }
        }
        public GolfR(TSI Silnik)
        {
            silnik = Silnik;
        }
    }
}
