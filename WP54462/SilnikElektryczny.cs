using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;

namespace WP54462
{
    public class SilnikElektryczny : Silnik
    {
        public int Bateria { get; private set; }
        public SilnikElektryczny(int bateria) : base(250, 0, "...") 
        {
            Bateria = bateria;
        }
    }
}
