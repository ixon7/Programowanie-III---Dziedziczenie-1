using System;

namespace BF055758
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod auto = new Samochod(250);
            auto.Jedz();
            auto.Jedz(300);
        }
    }
}