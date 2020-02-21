using Dziedziczenie;
using System;

namespace DL054441
{
    class Program
    {

        
      
        static void Main(string[] args)
        {

            Fiat Bravo = new Fiat(new Benzyna(120,5.5));
            Bravo.Jedz(150);

        }
    }
}
