using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace KB055289
{

    public class ElectricCar : IPojazd
    {
        public ElectricEngine Silnik { get; private set; }
        public void Jedz() => Jedz(400);


        double looper = 10;
        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                if (looper % 50 == 0)
                {
                    Console.WriteLine($"\nOdległość do najbliższej stacji dokującej: {Silnik.DistanceToStation()}");
                }
                Silnik.Dzialaj();
                looper++;
            }
        }

        public ElectricCar(ElectricEngine silnik)
        {
            Silnik = silnik;
        }
    }
    public class ElectricEngine : Silnik
    {
        static Random rnd = new Random();
        public ElectricEngine(int moc, double spalanie) : base(moc, spalanie, "wrr")
        {

        }

        public double DistanceToStation()
        {
            double toNextStation = rnd.Next(10, 100);
            return toNextStation;
        }
    }
    class ElectricVehicle
    {
    }
}
