using System;

namespace TB055288
{
    class Program
    {
        static void Main(string[] args)
        {
            TSI silnik = new TSI(290, 8);
            var auto = new GolfR(silnik);
            auto.Jedz();
        }
    }
}
