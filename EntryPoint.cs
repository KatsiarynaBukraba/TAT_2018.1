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
        /// <param name="args">It's the users string to input.</param>
        static void Main(string[] args)
        {
            DuplicateSymbols userString = new DuplicateSymbols(args[0]);
            Console.WriteLine(userString.MaxSerialDuplicateSymbols());
        }
    }
}
