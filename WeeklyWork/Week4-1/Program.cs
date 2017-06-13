using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week4_1
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 4 - CITP180 Summer 2017; this is CHAPTER 5
        /// Exercise 1 is an application to convert numbers 1-10 to roman numerals
        /// An error message should be written for invalid input
        /// Use 2 classes, where input is handled in second class (with main)
        /// Author: David Black
        /// Date: 6/6/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (InputDecimal(out decimal userDecimal))
            {
                WriteLine(Roman.DecimalToRoman(userDecimal, out string romanNumber) ? 
                    $"The decimal {userDecimal} can be converted to Roman Numeral {romanNumber}" 
                    : romanNumber);
            }
            ReadLine();
        }

        /// <summary>
        /// Prompt user for a decimal value.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="d">Number in decimal format</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputDecimal(out decimal d)
        {
            bool returnValue = true;
            d = 0;

            WriteLine("Enter the number to convert.");
           
            Write("Decimal value between 1 and 10:  ");
            returnValue = decimal.TryParse(ReadLine(), out d);
            
            if (!returnValue)
                WriteLine("Decimal numbers must be used to convert to Roman numerals.  Invalid input.");
            
            return returnValue;
        }
    }
}
