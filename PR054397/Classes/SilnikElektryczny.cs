using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace PR054397
{
    class SilnikElektryczny : Silnik
    {
        public SilnikElektryczny(int moc, double spalanie, string dzwiek) : base(moc, spalanie, "pykpykpyk")
        {

        }
    }
}
