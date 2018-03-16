using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// This class finds the sequence of even indices.
    /// </summary>
    public class SequenceEvenIndexBuilder
    {
        /// <summary>
        /// This method returns the sequence of even indices.
        /// </summary>
        /// <returns>the sequence of even indices</returns>
        public string FindSequenceEvenIndex(string inputString)
        {
            if (inputString.Equals(string.Empty))
            {
                throw new ArgumentNullException();
            }

            StringBuilder sequenceEvenIndex = new StringBuilder(inputString);

            for(int i = 1; i < sequenceEvenIndex.Length; i++)
            {
                sequenceEvenIndex.Remove(i, 1);
            }

            return sequenceEvenIndex.ToString();
        }
    }
}
