using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    
        class SilnikElektryczny : Silnik
        {
            public int MaksymalnyDystans;
            public SilnikElektryczny(int moc, double spalanie, string dzwiek) : base(moc, spalanie, dzwiek)
            {
                MaksymalnyDystans = 50;
            }
        }
    
}
