using System;

namespace NT055298
{
    class Jazda
    {
        static void Main(string[] args)
        {
            SilnikBenzynowy Tfsi = new SilnikBenzynowy(1500,6);
            var A4B8 = new Audi(Tfsi);
            A4B8.Jedz(100);
        }
    }
}