using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle rectangle = new Rectangle(args);
                Console.WriteLine(rectangle.CalculateSquare());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
