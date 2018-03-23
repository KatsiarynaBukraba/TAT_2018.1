using System;
using System.Numerics;
using System.Text;

namespace task_DEV_3
{
    /// <summary>
    /// This class converts the number in other numeral system.
    /// </summary>
    public class ConverterToOtherSystem
    {
        private int baseOfSystem;

        public ConverterToOtherSystem(int valueBase)
        {
            if (valueBase < 2 || valueBase > 20)
            {
                throw new ArgumentException();
            }
            baseOfSystem = valueBase;
        }

        /// <summary>
        /// This method converts the one number to the other in numeral system with input base.
        /// </summary>
        /// <param name="inputNumber">the number to convert</param>
        /// <returns>the converted number</returns>
        public string GetConvertedNumber(int inputNumber)
        {
            if (inputNumber < 0)
            {
                throw new ArgumentException();
            }

            StringBuilder convertedNumber = new StringBuilder();

            do
            {
                convertedNumber.Insert(0, GetPartOfNumber(inputNumber % baseOfSystem));
                inputNumber /= baseOfSystem;
            }
            while (inputNumber > 0);

           return convertedNumber.ToString();
        }

        private char GetPartOfNumber(int numberOfSymbol)
        {
            string allSymbols = "0123456789ABCDEFGHIJ";
            return allSymbols[numberOfSymbol];
        }
    }
}
