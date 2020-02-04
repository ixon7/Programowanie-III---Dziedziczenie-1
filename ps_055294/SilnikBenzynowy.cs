using Dziedziczenie;

namespace ps_055294
{
    public class SilnikBenzynowy : Silnik
    {
        private static int Przebieg;

        public SilnikBenzynowy(int moc, double spalanie, string dzwiek, int przebieg) : base(moc, spalanie, dzwiek)
        {
            Przebieg = przebieg;
        }


        public static int Przebieg1
        {
            get => Przebieg;
            set => Przebieg = value;
        }


        public static void zwiekszPrzebieg()
        {
            Przebieg += 1;
        }
    }
}