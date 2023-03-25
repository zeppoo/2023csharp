namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Hello, World!");
            program.Mand(5, "appels");
        }
        void Mand(int num, string fruit)
        {
            for (int i = 0; i < num; i++) 
            {
                Console.Write(num +fruit);
            }
        }
    }
}