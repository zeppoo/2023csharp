namespace functions_depth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Hello, World!");
            program.BoomKleur("Groen");
        }
        void BoomKleur(string kleur)
        {
            Console.WriteLine(kleur);
            BomenKleuren("Groen", 10);
        }

        void BomenKleuren(string kleur,int aantal)
        {
            Console.WriteLine(kleur + aantal);
            BomenDoodofNiet("Groen", 10, true);
        }

        void BomenDoodofNiet(string kleur,int aantal, bool Dood)
        {
            Console.WriteLine(kleur+aantal+Dood);
        }
    }
}