using System;
using System.Collections.Generic;
using System.Text;

namespace LP054466
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SilnikS silnik = new SilnikS(200, 15);
            SilnikM mocnySilnik = new SilnikM(500, 30);
            var samochodPierwszegoK = new Honda(silnik);
            samochodPierwszegoK.Jedz(50);
            var samochodDrugiegoK = new Honda(mocnySilnik);
            samochodDrugiegoK.Jedz(200);
        }
    }
}
