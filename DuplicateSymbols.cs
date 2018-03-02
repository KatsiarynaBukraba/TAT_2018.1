using System;

namespace LineAnalysis
{
    /// <summary>
    ///  This class is about search dublicate symbols in a string.
    /// </summary>
    class DuplicateSymbols
    {
        private string userString;

        public DuplicateSymbols(string args)
        {
            userString = args;
        }

        /// <summary>
        /// This method researches users string to found maximal series of duplicate symbols.
        /// </summary>
        /// <returns>maximal length of series of duplicate symbols</returns>
        public int MaxSerialDuplicateSymbols()
        {
            int count = 0;
            int maxCount = 0;

            for(int i = 0; i < userString.Length - 1; i++)
            {
                if (userString[i].Equals(userString[i+1]))
                {
                    count++;
                }
                else
                {
                    if(count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }

            }

            return maxCount + 1;
            
        }
    }
}
