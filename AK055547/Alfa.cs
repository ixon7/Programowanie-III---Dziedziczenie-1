using System;
using Dziedziczenie;

namespace AK055547
{
    public class Alfa : IPojazd
    {
        public Silnik Diesel { get; }
        public void Jedz() => Jedz(700);
        public void Jedz(int dystans)
        {
            int zasieg = 900;
            if (dystans < zasieg)
            {
                for (int i = 0; i < dystans; i++)
                {
                    if (i==zasieg/4)
                    {
                        Console.WriteLine(" \nHai il 75% di carburante!");
                    }
                    else if(i==zasieg/2)
                    {
                        Console.WriteLine("\nMetà del serbatoio!");
                    }
                    Diesel.Dzialaj();
                }
            }
            else
            {
                Console.WriteLine("\nNessun carburante!");
            }
        }
        public Alfa(JTDm poj19)
        {
            Diesel = poj19;
        }
    }
}