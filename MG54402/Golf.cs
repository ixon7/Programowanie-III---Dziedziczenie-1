using System;
using System.Collections.Generic;
using System.Text;
using Dziedziczenie;
using MG54402;

namespace MG54402
{
    class Golf
    {
    }
}
class Golf : IPojazd
{
    public Silnik Silnik { get; private set; }
    public void Jedz() => Jedz(100);
    public void Jedz(int dystans)
    {
        var max = new Random();
        var zasieg = 80 + max.Next(1, 69);
        for (int i = 0; i < zasieg; i++)
        {
            Silnik.Dzialaj();
        }
        if (dystans > zasieg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER! \t \t \t");
            Console.ResetColor();
        }
    }
    public Golf (Map silnik)
    {
        Silnik = silnik;
    }
}
}