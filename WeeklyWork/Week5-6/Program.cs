using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week5_6
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 5 - CITP180 Summer 2017; this is CHAPTER 6
        /// Exercise 6 is an application to take hexadecimal characters and sum them
        /// Author: David Black
        /// Date: 6/19/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Enter any number of hexadecimal characters (0-9, A-F)");
            WriteLine("The values will be summed.");
            WriteLine("Enter -1 to stop entering numbers");

            bool continueFlag = true;
            long input = 0,
                decValue = 0,
                sum;
            string inputValue = "";
            do
            {
                WriteLine("Enter a sequence of hexadecimal characters.");
                inputValue = ReadLine();
                if (long.TryParse(inputValue, System.Globalization.NumberStyles.HexNumber, null, out input))
                {
                    sum = 0;
                    for (int i = 0; i < inputValue.Length; i++)
                    {
                        WriteLine($"Hex value:\t{inputValue[i], 5}");
                        decValue = long.Parse(inputValue[i].ToString(), System.Globalization.NumberStyles.HexNumber);
                        WriteLine($"Decimal value:\t{decValue, 5}");
                        sum += decValue;
                    }

                    WriteLine($"\nSum in hex is: {sum:X}");
                }
                else
                {
                    WriteLine("Invalid input.");
                }

                WriteLine("Do you wish to enter another number?  (Y/N)");
                if (ReadLine().ToUpper() != "Y")
                {
                    continueFlag = false;
                }
                else
                {
                    Clear();
                }

            } while (continueFlag);
            WriteLine("Ending Program");
            ReadLine();
        }
    }
}
