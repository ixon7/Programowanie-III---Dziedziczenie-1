using System;
using System.Collections.Generic;
using System.Text;

namespace pr055550
{
    class Program
    {
        public static void Main(string[] args)
        {
            Silnik1 silnik = new Silnik1(5000, 9);
            var Kierowca = new Nissan(silnik);
            Kierowca.Jedz(101);
        }
    }
}
