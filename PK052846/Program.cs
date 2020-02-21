using System;
using Dziedziczenie;

namespace PK052846
{
    class Program
    {
        static void Main(string[] args)
        {
            IPojazd gruz = new AudiA3(new AGN(125, 11.2), 5);

            gruz.Jedz(10);
            gruz.Jedz(100);
        }
    }
}
