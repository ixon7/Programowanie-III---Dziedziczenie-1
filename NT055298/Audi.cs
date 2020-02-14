using System;
using Dziedziczenie;

namespace NT055298
{
    public class Audi : IPojazd
    {
        public SilnikBenzynowy SilnikBenzynowy { get; private set; }

        public void Jedz() => Jedz(1000);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                SilnikBenzynowy.Obroty();
                SilnikBenzynowy.AktualneObroty += 100;
                if (SilnikBenzynowy.AktualneObroty == 3000)
                {
                    if (SilnikBenzynowy.AktualnyBieg < SilnikBenzynowy.LiczbaBiegow)
                    {
                        SilnikBenzynowy.AktualnyBieg++;
                        Console.WriteLine($"Aktualne obroty silnika: {SilnikBenzynowy.AktualneObroty}");
                        SilnikBenzynowy.AktualneObroty -= 1500;
                        Console.WriteLine();
                        Console.WriteLine($"Aktualny bieg: {SilnikBenzynowy.AktualnyBieg}");
                        Console.WriteLine();
                    }
                }

                if (SilnikBenzynowy.AktualneObroty < SilnikBenzynowy.MinObroty)
                {
                    Console.WriteLine("Silnik zgasł!");
                    return;
                }

                if (SilnikBenzynowy.AktualneObroty > SilnikBenzynowy.MaxObroty)
                {
                    Console.WriteLine("Awaria silnika!");
                    return;
                }
            }
        }
        public Audi(SilnikBenzynowy silnikBenzynowy)
        {
            SilnikBenzynowy = silnikBenzynowy;
        }
    }
}