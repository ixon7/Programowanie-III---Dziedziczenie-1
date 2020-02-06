using System;

namespace ep054472
{
    public class SilnikSamochodowy 
    {
        public int Moc { get; private set; }
        public double Spalanie { get; private set; }
        public string Dzwiek { get; private set; }

        public void Dzialaj()
        {
            Console.Write(Dzwiek + " ");
        }


        protected SilnikSamochodowy(int moc, double spalanie, string dzwiek)
        {
            Moc = moc;
            Spalanie = spalanie;
            Dzwiek = dzwiek;
        }
    }
}