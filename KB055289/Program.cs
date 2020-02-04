using System;
using Dziedziczenie;

namespace KB055289
{
    public class Program
    {
        static void Main(string[] args)
        {
            ElectricEngine silnikk = new ElectricEngine(300, 10);
            ElectricCar ct = new ElectricCar(silnikk);
            ct.Jedz(500);
            Console.WriteLine();
        }
    }
}
