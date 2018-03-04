using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// This class finds sequence of even indices.
    /// </summary>
    class SequenceEvenIndex
    {
        private string InputString { get; set; }

        public SequenceEvenIndex(string value)
        {
            InputString = value;
        }

        /// <summary>
        /// This method outputs sequence of even indices.
        /// </summary>
        public void FindSequenceEvenIndex()
        {
            StringBuilder sequenceEvenIndex = new StringBuilder(InputString);

            for(int i = 1; i < sequenceEvenIndex.Length - 1; i++)
            {
                sequenceEvenIndex.Remove(i, 1);
            }

            Console.WriteLine(sequenceEvenIndex);
        }
    }
}
