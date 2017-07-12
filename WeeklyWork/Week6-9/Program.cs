using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week6_9
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 6 - CITP180 Summer 2017; this is CHAPTER 7
        /// Exercise 9 is an application to display a frequency distribution bar chart
        /// Data will be based on user input of values 0-10
        /// Include error messages for invaid inputs
        /// Author: David Black
        /// Date: 6/25/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int countOutOfRange = 0,
                countInvalid = 0,
                tempInt;
            string userInput;
            //Use array of length 11 to store the number of times each index is the valid number (index 0 increments when 0 entered).
            //The array indices are merely counting the number of times that index integer was entered.
            int[] userInputInteger = new int[11];

            WriteLine("This program takes valid inputs from 0 to 10 and displays frequency of valid inputs.");
            WriteLine("type STOP to finish entering values");
            //Gather Input
            do
            {
                userInput = ReadLine();
                if (int.TryParse(userInput, out tempInt))
                {
                    if (tempInt > -1 && tempInt < 11)
                    {
                        userInputInteger[tempInt]++;
                    }
                    else
                    {
                        countOutOfRange++;
                        WriteLine("That number is not between 0 and 10.  \nEnter another number betweeen 0 and 10.");
                    }
                }
                else if (userInput.ToUpper() != "STOP")
                {
                    countInvalid++;
                    WriteLine("That entry is not a number between 0 and 10.  \nEnter another number betweeen 0 and 10.");
                }
            } while (userInput.ToUpper() != "STOP");

            //Show results
            WriteLine("\nValues entered -");
            WriteLine("*****************************************************");
            WriteLine("Number\t\t\tFrequency");
            WriteLine("      |  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20+");
            WriteLine("-----------------------------------------------------");
            for (int i = 0; i < 11; i++)
            {
                if (userInputInteger[i] != 0)
                {
                    Write($"{i,3}   |");
                    for(int j = 0; j < userInputInteger[i] && j < 20; j++)
                    {
                        Write("  *");
                    }
                    WriteLine("");
                }
            }
            //WriteLine("-----------------------------------------------------");
            //WriteLine($"Number of invalid string inputs:  {countInvalid,10}");
            //WriteLine($"Number of integer inputs out of range:  {countOutOfRange,4}");
            WriteLine("*****************************************************");

            ReadLine();
        }
    }
}
