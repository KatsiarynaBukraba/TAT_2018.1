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
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                SequenceEvenIndex inputString = new SequenceEvenIndex(args[0]);
                inputString.FindSequenceEvenIndex();
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
        }
    }
}
