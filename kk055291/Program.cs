using System;
using Dziedziczenie;

namespace kk055291
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            Corshe corshe = new Corshe(new SilnikBenzynowy(150, 11, "Zium"));
            corshe.Jedz(150);
        }
    }
}
