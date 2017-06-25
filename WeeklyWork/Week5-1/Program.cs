using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week5_1
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 5 - CITP180 Summer 2017; this is CHAPTER 6
        /// Exercise 1 is an application to take valid input in a loop (1-99)
        /// Author: David Black
        /// Date: 6/19/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Enter any number of values between 1 and 99, inclusive.");
            int input = 0,
                validCount = 0,
                invalidCount = 0;
            do
            {
                if (int.TryParse(ReadLine(), out input))
                {
                    if (input > 0 && input < 100)
                    {
                        validCount++;
                    }
                    else if (input != -1)
                    {
                        invalidCount++;
                    }
                }
                else
                {
                    invalidCount++;
                }
            } while (input != -1);

            WriteLine("Here are the results:");
            WriteLine($"Valid Inputs:\t{validCount,4}");
            WriteLine($"Invalid Inputs:\t{invalidCount,4}");
            ReadLine();
        }
        
    }
}
