using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace pr055550
{
    public class Silnik1 : Silnik
    {
        public int Glosnosc { get; private set; }

        public Silnik1(int moc, double spalanie, int Glosnosc) : base(moc, spalanie, "bruum") { }
    }
}
