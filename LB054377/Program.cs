using System;
using Dziedziczenie;

namespace LB054377
{
    class Program
    {
        static void Main(string[] args)
        {
            Skyactive silnik = new Skyactive(600, 40);
            var samochodzik = new Mazda(silnik);
            samochodzik.Jedz(300);
        }
    }
}
