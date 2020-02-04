using Dziedziczenie;

namespace OT054491
{
    class Mustang : IPojazd
    {
        public void Jedz()
        {
            Jedz(200, 100, 12.1, "Krach");
        }
        public void Jedz(int dystans)
        {
            Jedz(dystans, 200, 15, "Bruuuum");
        }
        
        public void Jedz(int dystans, int moc, double spalanie, string dzwiek)
        {
            SilnikMustang silnik = new SilnikMustang(moc, spalanie, dzwiek);
            for (int i = 0; i < dystans; i++)
            {
                silnik.Dzialaj();
            }
        }
    }
}