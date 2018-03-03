using System;

namespace LineAnalysis
{
    /// <summary>
    /// It's an entry point in the program.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// It's an entry point in the program.
        /// </summary>
        /// <param name="args">the user's string to input</param>
        static void Main(string[] args)
        {
            try
            {
                DuplicateSymbolsCounter inputString = new DuplicateSymbolsCounter(args[0]);
                Console.WriteLine(inputString.MaxSerialDuplicateSymbols());
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
        }
    }
}
