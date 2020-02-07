using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace WM052943
{
    public class HyundaiGetz : IPojazd
    {
        public Silnik silnik { get; set; }

        public double Przyspieszenie = 2.32;
        public int MaxPredkosc = 165;

        public void Jedz() => Jedz(150);

        public void Jedz(int dystans)
        {
            Stopwatch stoper = new Stopwatch();

            for (int i = 0; i < dystans; i++)
            {
                silnik.Dzialaj();

                stoper.Start();
                
                if (i%3==0) { Console.WriteLine(Math.Round(Przyspieszenie,1) + " km/h"); Przyspieszenie += 3.68; }
                

                Console.WriteLine(" ");
                if (Przyspieszenie >= 100)
                {
                    stoper.Stop();

                }
                if (Przyspieszenie >=MaxPredkosc )
                {
                    
                    Console.WriteLine($"Szybciej niż {MaxPredkosc} nie pojedzie");
                    break;
                }
                
            }
                   
              TimeSpan ts = stoper.Elapsed*10000; // czas zalezy od oporu powietrza
              string czas = String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);
              Console.WriteLine($"{czas}sek do 100km/h");
        }
        public HyundaiGetz(Benzyna1_1 Silnik)
        {
            silnik = Silnik;
        }
    }
}
