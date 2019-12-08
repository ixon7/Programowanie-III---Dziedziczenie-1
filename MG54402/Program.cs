using Dziedziczenie;
using System;

namespace MG54402
{
    class Program
    {
        public class Osobowy : IPojazd
        {
            public Dziedziczenie.Silnik JTDM { get; private set; }
            public void Jedz() => Jedz(160);
            public void Jedz(int dystans)
            {
                for (int i = 0; i < dystans; i++)
                {
                    JTDM.Dzialaj();
                }
            }
            public Osobowy(TurboDiesel silnik)
            {

                JTDM = silnik;
            }
            public class TurboDiesel : Silnik
            {
                public TurboDiesel(int moc, double spalanie) : base(moc, spalanie, "wziuuu")
                {

                }
            }
                    static void Main(string[] args)
                {
                    Osobowy Alfa = new Osobowy(new TurboDiesel(100, 20.6));
                    Alfa.Jedz(150);
                }
            }
        }
    }