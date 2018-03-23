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
            try
            {
                SequenceEvenIndexBuilder inputString = new SequenceEvenIndexBuilder();
                Console.WriteLine(inputString.FindSequenceEvenIndex(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            };

        }
    }
}
