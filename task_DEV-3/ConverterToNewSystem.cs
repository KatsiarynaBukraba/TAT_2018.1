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
        /// <returns>the number to convert</returns>
        public string GetConvertNumber(int inputNumber)
        {
            StringBuilder convertNumber = new StringBuilder();

            do
            {
                convertNumber.Append(GetDigit(inputNumber % baseOfNewSystem));
                inputNumber /= baseOfNewSystem;
            }
            while (inputNumber > 0);

           return ReverseValue(convertNumber);
        }

        private char GetDigit(int numberOfDigit)
        {
            string allDigits = "0123456789ABCDEFGHIJ";

            return allDigits[numberOfDigit];
        }

        private string ReverseValue(StringBuilder value)
        {
            StringBuilder reverseValue = new StringBuilder();

            for(int i = 0; i < value.Length; i++)
            {
                reverseValue.Append(value[value.Length-1-i]);
            }

            return reverseValue.ToString();
        }
    }
}
