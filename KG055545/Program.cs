using System;
using Dziedziczenie;

namespace KG055545
{
    class Program
    {
        static void Main(string[] args)
        {
            var V8_6L = new V8_6(1076, 29);
            var isThatASupra = new Supra(V8_6L, 60);
            isThatASupra.Jedz();


            
        }
    }
}
