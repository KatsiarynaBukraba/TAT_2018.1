using System;
using System.Numerics;

namespace task_DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (!(args.Length == 2))
                {
                    throw new FormatException();
                }

                int inputNumber = Int32.Parse(args[0]);
                int baseOfNewSystem = Int32.Parse(args[1]);
                ConverterToOtherSystem converter = new ConverterToOtherSystem(baseOfNewSystem);
                Console.WriteLine(converter.GetConvertedNumber(inputNumber));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
