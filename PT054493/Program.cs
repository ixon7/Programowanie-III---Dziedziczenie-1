using System;
using Dziedziczenie;

namespace PT054493
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPojazd fordzik = new FordMustang(new SilnikBenzynowy50(521, 17.8));
            IPojazd fordzikEco = new FordMustang(new SilnikBenzynowy23EcoBoost(223, 11.2));

            fordzik.Jedz(200);
            fordzikEco.Jedz(100);
        }
    }
}
