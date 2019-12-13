using System;

namespace MR054473
{
    class Program 
    {
        static void Main(string[] args)
        {
            SilnikElektryczny silnik = new SilnikElektryczny(50, 100,100);
            var auto = new Ford(silnik);
            auto.Jedz(200);
        }
    }
}
