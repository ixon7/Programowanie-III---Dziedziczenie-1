using System;

namespace ep054472
{
    class Program
    {
        static void Main(string[] args)
        {
            var silnikDzialajacy = new SilnikDzialajacy(1000, 250);
            
            var samochod = new Samochod(silnikDzialajacy);

            samochod.Jedz();
            Console.WriteLine("Dotarles na miejsce. Chcialbys wrocic?");
            string powrot = Console.ReadLine();
            switch (powrot)
            {
                case "tak":
                    samochod.Jedz();
                    break;
                case "nie":
                    Console.WriteLine("Udanego pobytu.");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Badz bardziej zdecydowany");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            
        }
    }
}