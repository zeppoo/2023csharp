using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            double totaalPrijs = 759.95;// tel hier alles bij elkaar op

            //oof wat duur, maar we hebben een kortings bon! 20% korting

            //eerst even uitrekenen wat we dan eigenlijk betalen , 100% - 20%

            double prijsProcentBetalen = totaalPrijs - (totaalPrijs * 0.2);// maak hier de som  100% - 20% (% mag je weglaten)

            //er moet nu 607.96 staan
            Console.WriteLine($"te betalen {prijsProcentBetalen}");
        }
    }
}