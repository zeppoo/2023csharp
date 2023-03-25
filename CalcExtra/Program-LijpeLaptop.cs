namespace CalcExtra
{
    internal class Program
    {
         
         
        static void Main(string[] args)
        {
            float x1 = 50f;
            float x2 = 60f;
            float y1 = 50f;
            float y2 = 50f;
            float rad1 = 5f;
            float rad2 = 5f;
            Console.WriteLine("Hello, World!");
            float dx = x2 - x1;
            float dy = y2 - y1;
            double testLength = 15;
            double length = Math.Sqrt((dx * dx) + (dy * dy));
            bool collide = length <= testLength;
            Console.WriteLine(collide);
        }
    }
}