using Dziedziczenie;
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Silnikinfi a = new Silnikinfi(190, 10);
            Infinitii b = new Infinitii(a);
            b.Jedz(10);
            Console.ReadLine();
        }
        
    }
}
