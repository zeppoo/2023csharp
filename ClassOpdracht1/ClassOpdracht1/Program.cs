using System;

namespace ClassOpdracht1
{
    
    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    internal class ClassStructureExercise //class word aangemaakt
    {
        private readonly string accountName; //string word aangemaakt met string naam en kan maar een keer worden aangepast

        internal ClassStructureExercise(string accountName) //dit is de constructor functie
        {
            this.accountName = accountName;
        }

        internal void ShowGreetingInConsole() //print een groeting met accountnaam
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
        }

        internal void Show1To10() //print getallen 1 tot 10 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2) //berekent afstand tussen punten
        {

            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;

        }
        internal int MultiplyToPower2(int value) //gooit een value in een kwadratische functie
        {
            int result = value * value;
            return result;
        }


        static void Main(string[] args) //start functie
        {
            Console.WriteLine("Hello, World!");

        }
    }
}