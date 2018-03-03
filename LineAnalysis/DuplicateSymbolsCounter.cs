using System;

namespace LineAnalysis
{
    /// <summary>
    ///  This class contains methods for work with duplicate symbols.
    /// </summary>
    class DuplicateSymbolsCounter
    {
        private string UserString { get; set; }

        public DuplicateSymbolsCounter(string args)
        {
            UserString = args;
        }

        /// <summary>
        /// This method calculates maximal series of duplicate symbols of user's string.
        /// </summary>
        /// <returns>maximal length of the series of duplicate symbols</returns>
        public int MaxSerialDuplicateSymbols()
        {
            int currentCount = 1;
            int maxCount = 1;

            for (int i = 0; i < UserString.Length - 1; i++)
            {
                if (UserString[i].Equals(UserString[i + 1]))
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