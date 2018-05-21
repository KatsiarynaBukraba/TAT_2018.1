using System;

namespace task2
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(string[] args)
        {
            if (args.Length != 2)
                throw new ArgumentException();
  
            Width = Single.Parse(args[1]);         
            Length = Single.Parse(args[2]);

            if (Length <= 0 || Width <= 0)
                throw new ArgumentException();
        }
        public double CalculateSquare()
        {
            return (double)Width * Length;
        }
    }
}
