using System;

namespace PropertyOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persoon persoon = new Persoon();

            persoon.Naam = "Mark";//maak deze string aan als property in persoon, gebruik get set
            persoon.Leeftijd = 17;//maak deze int aan als property in persoon, gebruik get set
        }
    }
}