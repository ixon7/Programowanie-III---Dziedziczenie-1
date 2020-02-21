using System;
using Dziedziczenie;

namespace MR054473
{
    class Program 
    {
        static void Main(string[] args)
        {
            IPojazd FordBenzin = new Ford(new SilnikBenzin(487, 19.8));
            IPojazd FordEco = new Ford(new SilnikEcoBoost(521, 17.8));

            FordBenzin.Jedz(200);
            FordEco.Jedz(300);
        }
                  
    }
}
