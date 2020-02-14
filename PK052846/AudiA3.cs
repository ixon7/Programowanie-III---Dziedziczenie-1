using System;
using Dziedziczenie;

namespace PK052846
{
    class AudiA3 : IPojazd
    {
        // Właściwości
        public Silnik silnik { get; set; }
        public double FuelTank { get; set; }

        // Ograniczenia auta
        private readonly double fuelTankMax = 50.0;
        private readonly double speedMax = 250;

        // Konstruktor
        public AudiA3(Silnik silnik, double fuelTank)
        {
            this.silnik = silnik;
            if (fuelTank > fuelTankMax)
            {
                fuelTank = fuelTankMax;
            }
            else if (fuelTank < 0)
            {
                fuelTank = 0;
            }
            else
            {
                FuelTank = fuelTank;
            }
        }

        public void Jedz() => Jedz(100);

        public void Jedz(int dystans)
        {
            double spalanieNaKm = silnik.Spalanie / 100;
            double speed = 1;
            for (int i = 0; i <= dystans; i++)
            {
                // Obliczanie pozostałego paliwa
                if (FuelTank <= 0)
                {
                    Console.WriteLine("Brak paliwa");
                    break;
                }
                FuelTank = Math.Round(FuelTank - spalanieNaKm, 3);


                // Obliczanie prędkości
                double calcSpeed = Math.Round((speed + speed * Math.Exp(silnik.Moc / 100) * 10) / speed);
                if (calcSpeed + speed >= speedMax)
                {
                    speed = speedMax;
                }
                else
                {
                    speed += Math.Round(calcSpeed);
                }

                // Wypisanie inforamcji
                Console.WriteLine($"{silnik.Dzwiek}\tF:{FuelTank}\tV:{speed}");
            }
        }
    }
}
