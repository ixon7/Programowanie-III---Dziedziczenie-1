using System;

namespace WM052943
{
    class Program
    {
        static void Main(string[] args)
        {
            Benzyna1_1 silnik = new Benzyna1_1(66,7,165);

            var samochod = new HyundaiGetz(silnik);
            samochod.Jedz();
        }
    }
}
