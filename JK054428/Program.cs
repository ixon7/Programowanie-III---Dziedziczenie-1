using System;

namespace JK054428
{
    class Program
    {
        static void Main(string[] args)
        {
            SilnikSpalinowy silnik = new SilnikSpalinowy(200, 50);
            var auto = new Seat(silnik);
            auto.Jedz(400);

            Console.Read();
        }
    }
}
