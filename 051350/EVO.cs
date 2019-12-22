using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace _051350
{
    public class EVO : IPojazd
    {
        public Silnik Silnik { get; private set; }

        public void Jedz() => Jedz(100);

        public void Jedz(int dystans)
        {
            for (int i = 0; i < dystans; i++)
            {
                Silnik.Dzialaj();
                if (0 == i % 5) Console.Write("stututu ");
            }
        }

        public EVO(_4G63T silnik)
        {
            Silnik = silnik;
        }
    }
}
