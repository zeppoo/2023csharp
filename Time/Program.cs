namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                DateTime localTime = DateTime.UtcNow;
                Console.Write("\r"+localTime);
            }

        }

    }
}