namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Hello, World!");
            int[] nummerarr = { 10, 20, 30, 40, 50, 60 };
            int getal = program.optellen(nummerarr);
            Console.WriteLine(getal);
        }
        int optellen(int[] nummers)
        {
            return nummers.Sum();
        }
    }
}