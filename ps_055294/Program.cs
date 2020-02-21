using System;
using System.ComponentModel.DataAnnotations;
using Dziedziczenie;

namespace ps_055294
{
    class Program
    {
        static void Main(string[] args)
        {
            var czerwonyPunciak = new Punciak(new SilnikBenzynowy(5, 5, "brum", 0));
            czerwonyPunciak.Jedz();
        }
    }

    

    
}