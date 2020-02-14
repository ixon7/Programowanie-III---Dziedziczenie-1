using System;

namespace ep054472
{
    public class Samochod : IPojazd
    {
        public SilnikSamochodowy SilnikSamochodowy { get; private set; }

        public void Jedz() => Jedz(65);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                SilnikSamochodowy.Dzialaj();
            }

            Console.WriteLine();
        }

        public Samochod(SilnikDzialajacy silnikSamochodowy)
        {
            SilnikSamochodowy = silnikSamochodowy;
        }
    }
}