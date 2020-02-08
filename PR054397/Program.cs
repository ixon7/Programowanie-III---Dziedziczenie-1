using Dziedziczenie;
using System;

namespace PR054397
{
    class Program
    {
        static void Main(string[] args)
        {
            IPojazd auto = new Osobowka(new SilnikBenzyna(120, 4, "pyrpyrpyr"));
            auto.Jedz(120);
        }
    }
}
