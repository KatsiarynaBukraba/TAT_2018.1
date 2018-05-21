using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, world!");
                Console.WriteLine("And hi again!");

                Random random = new Random();
                for (int i = 1; i < random.Next(5, 50); i++)
                {
                    Console.Write("!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
