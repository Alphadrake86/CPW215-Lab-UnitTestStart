using System;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            bool isCorrectFormat = true;
            if (ssn.Contains("-"))
            {
                isCorrectFormat = ssn.IndexOf("-") == 3 && ssn.LastIndexOf("-") == 6;
                ssn = ssn.Replace("-", "");
            }
            
            bool isOnlyDigits = int.TryParse(ssn, out int x);
            bool isCorrectNumDigits = ssn.Length == 9;

            return isCorrectNumDigits && isOnlyDigits && isCorrectFormat;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            return numToTest <= maxValue && numToTest >= minValue;
        }
    }
}
