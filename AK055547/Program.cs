using System;

namespace AK055547
{
    class Program
    {
        static void Main(string[] args)
        {
            JTDm poj19 = new JTDm(150, 5.5);
            var bella = new Alfa(poj19);
            bella.Jedz();
        }
    }
}