using System;

namespace LineAnalysis
{
    /// <summary>
    ///  This class contains methods for work with duplicate symbols.
    /// </summary>
    class DuplicateSymbolsCounter
    {
        private string InputString { get; set; }

        public DuplicateSymbolsCounter(string value)
        {
            InputString = value;
        }

        /// <summary>
        /// This method calculates maximal series of duplicate symbols of user's string.
        /// </summary>
        /// <returns>maximal length of the series of duplicate symbols</returns>
        public int MaxSerialDuplicateSymbols()
        {
            int currentCount = 1;
            int maxCount = 1;

            for (int i = 0; i < InputString.Length - 1; i++)
            {
                if (InputString[i].Equals(InputString[i + 1]))
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            return maxCount;
        }
    }
}
