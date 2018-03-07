using System;
using System.Text;

namespace task_DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            if (!(args.Length == 2))
            {
                Console.WriteLine("Error! Incorrect format of the data!");
                return;
            }

            try
            {
                long inputNumber = Int64.Parse(args[0]);
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
