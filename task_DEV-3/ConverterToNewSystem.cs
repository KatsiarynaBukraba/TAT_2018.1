using System;
using System.Text;

namespace task_DEV_3
{
    /// <summary>
    /// This class converts the number in other numeral system.
    /// </summary>
    class ConverterToNewSystem
    {
        private int baseOfNewSystem;

        public ConverterToNewSystem(int valueBase)
        {
            baseOfNewSystem = valueBase;
        }

        /// <summary>
        /// This method converts the one number to the other in numeral system with input base.
        /// </summary>
        /// <param name="inputNumber">the number to convert</param>
        /// <returns>the converted number</returns>
        public string GetConvertNumber(int inputNumber)
        {
            StringBuilder convertNumber = new StringBuilder();

            do
            {
                convertNumber.Insert(0, GetDigit(inputNumber % baseOfNewSystem));
                inputNumber /= baseOfNewSystem;
            }
            while (inputNumber > 0);

           return convertNumber.ToString();
        }

        private char GetDigit(int numberOfDigit)
        {
            string allDigits = "0123456789ABCDEFGHIJ";
            return allDigits[numberOfDigit];
        }
    }
}
