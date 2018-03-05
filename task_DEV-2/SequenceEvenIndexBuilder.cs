using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// This class finds the sequence of even indices.
    /// </summary>
    class SequenceEvenIndexBuilder
    {
        private string inputString;

        public SequenceEvenIndexBuilder(string value)
        {
            inputString = value;
        }

        /// <summary>
        /// This method returns the sequence of even indices.
        /// </summary>
        /// <returns>the sequence of even indices</returns>
        public string FindSequenceEvenIndex()
        {
            StringBuilder sequenceEvenIndex = new StringBuilder(inputString);

            for(int i = 1; i < sequenceEvenIndex.Length; i++)
            {
                sequenceEvenIndex.Remove(i, 1);
            }

            return sequenceEvenIndex.ToString();
        }
    }
}
