using Dziedziczenie;
using System;

namespace pr_40969
{
    class Program
    {
        static void Main(string[] args)
        {
            SilnikBenz x = new SilnikBenz(163, 9.5, 90);
            IPojazd a = new SportovySamochod(x);
            a.Jedz(10);

        }
    }
}
