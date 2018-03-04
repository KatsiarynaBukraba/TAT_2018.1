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
                SequenceEvenIndex inputString = new SequenceEvenIndex(Console.ReadLine());
                inputString.FindSequenceEvenIndex();
        }
    }
}
