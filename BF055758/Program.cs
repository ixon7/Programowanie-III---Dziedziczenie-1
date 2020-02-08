using System;

namespace BF055758
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod auto = new Samochod(250, 100);
            auto.Jedz();
            auto.Jedz(300);
            auto.Laduj();
            auto.Jedz(125);
        }
    }
}