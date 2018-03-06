using System;
using System.Text;

namespace task_DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int inputNumber; 
            int baseOfNewSystem;

            bool checkNumber = Int32.TryParse(args[0], out inputNumber);
            bool checkFormatBase = Int32.TryParse(args[1], out baseOfNewSystem);
            bool checkIntervalBase = baseOfNewSystem > 2 && baseOfNewSystem < 20;

            if (checkNumber && checkFormatBase && checkIntervalBase)
            {
                ConverterToOtherSystem converter = new ConverterToOtherSystem(baseOfNewSystem);
                Console.WriteLine(converter.GetConvertNumber(inputNumber));
            }
            else
            {
                Console.WriteLine("Error! Incorrect format of the data!");
            }
        }
    }
}
