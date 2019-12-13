using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    public class SportovySamochod : IPojazd
    {
        public SilnikBenz x;
        public SportovySamochod(SilnikBenz x)
        {
            x.Dzialaj();
        }

        public void Jedz()
        {
            Console.WriteLine("jade");
        }
        public void Jedz(int a)
        {
            Console.WriteLine("Podany dystans" + a);

            for (int i = 0; i < a; i++)
            {
                Console.Write("br");
            }
            Console.WriteLine();        
        }

    }

}
