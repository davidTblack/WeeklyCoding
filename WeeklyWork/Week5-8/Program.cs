using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week5_8
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 5 - CITP180 Summer 2017; this is CHAPTER 6
        /// Exercise 8 is an application to take three lengths and compute if they can form a triangle
        /// Author: David Black
        /// Date: 6/19/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] length = new int[3];
            int[] tempArray;
            int counter;
            bool continueFlag = true,
                validEntry;
            string displayLengths;

            WriteLine("This program takes 3 lengths and determines if lines of those lengths can form a triangle.");

            do
            {
                WriteLine("Enter three lengths.");

                validEntry = true;
                counter = 0;
                while (counter < 3 && validEntry)
                {
                    validEntry = InputALength(counter + 1, out length[counter]);
                    counter++;
                }
                
                if (validEntry)
                {
                    //Prepare output string for lengths before sorting array
                    displayLengths = "";
                    for (int i = 0; i < length.Length; i++)
                    {
                        displayLengths += $"Length {i + 1}: {length[i]}\n";
                    }
                    //arrange by size to compare
                    Array.Sort(length);
                    if ((length[0] + length[1]) > length[2])
                    {
                        WriteLine("These 3 lengths can form a triangle:");
                        WriteLine(displayLengths);
                    }
                    else
                    {
                        WriteLine("The values do not form a triangle.");
                    }

                    WriteLine("Do you want to enter another set of values? (Y/N)");
                    if (ReadLine().ToUpper() != "Y")
                    {
                        continueFlag = false;
                    }
                }
                else
                {
                    WriteLine("Numbers entered were not valid.  Try again.");
                }
                
            } while (continueFlag);
            
        }

        /// <summary>
        /// Method to input a single length value
        /// </summary>
        /// <param name="counter">Which length (number) is being recorded</param>
        /// <param name="length">The length returned</param>
        /// <returns>True if valid user input, false if not valid (an integer > 0)</returns>
        private static bool InputALength(int counter, out int length)
        {
            bool returnValue = true;
            length = 0;
            
            Write($"Length {counter}:  ");
            returnValue = int.TryParse(ReadLine(), out length);

            if (!returnValue)
            {
                WriteLine("Invalid input.");
            }
            else if (length < 1)
            {
                WriteLine("0 and negative numbers are not valid lengths.");
                returnValue = false;
            }

            return returnValue;
        }
       
    }
}
