using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_1
{
    static class Roman
    {
        /// <summary>
        /// Convert a decimal number to a Roman Numeral string
        /// </summary>
        /// <param name="number">Decimal number to convert</param>
        /// <param name="romanNumeral">Returned Roman Numeral, or an error message</param>
        /// <returns>True or False, depending on whether conversion was successful</returns>
        public static bool DecimalToRoman(decimal number, out string romanNumeral)
        {
            bool returnValue = true;
            switch (number)
            {
                case 1:
                    romanNumeral = "I";
                    break;
                case 2:
                    romanNumeral = "II";
                    break;
                case 3:
                    romanNumeral = "III";
                    break;
                case 4:
                    romanNumeral = "IV";
                    break;
                case 5:
                    romanNumeral = "V";
                    break;
                case 6:
                    romanNumeral = "VI";
                    break;
                case 7:
                    romanNumeral = "VII";
                    break;
                case 8:
                    romanNumeral = "VIII";
                    break;
                case 9:
                    romanNumeral = "IX";
                    break;
                case 10:
                    romanNumeral = "X";
                    break;
                default:
                    returnValue = false;
                    romanNumeral = "Input decimal number could not be converted to a Roman Numeral between 1 and 10.";
                    break;
            }
            return returnValue;
        }
    }
}
