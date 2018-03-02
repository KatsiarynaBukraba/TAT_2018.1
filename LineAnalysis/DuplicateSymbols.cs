using System;

namespace LineAnalysis
{
    /// <summary>
    ///  This class contains methods for work with duplicate symbols.
    /// </summary>
    class DuplicateSymbols
    {
        private string UserString { get; set; }

        public DuplicateSymbols(string args)
        {
            UserString = args;
        }

        /// <summary>
        /// This method calculates the maximal series of duplicate symbols of user's string.
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
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 1;
                }
            }
            return maxCount;
        }
    }
}
