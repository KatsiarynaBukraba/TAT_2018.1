using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// The entry point to the program.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point to the program.
        /// </summary>
        static void Main()
        {
            SequenceEvenIndexBuilder inputString = new SequenceEvenIndexBuilder(Console.ReadLine());
            Console.WriteLine(inputString.FindSequenceEvenIndex());
        }
    }
}
