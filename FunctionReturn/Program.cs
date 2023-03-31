namespace FunctionReturn
{
    internal class Program
    {
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Hello, World!");
            int Getal = program.Random_Getal();
            Console.WriteLine(Getal);
            
        }
        int Random_Getal() 
        {
            return rnd.Next(1, 100);
        }
    }
}