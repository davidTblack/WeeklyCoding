using System;
using static System.Console;

namespace Week3_6
{
    class Program
    {
        //Constant used in calculations
        const double INCHES_PER_METER = 39.37007874;

        /// <summary>
        /// Programming exercises for week 3 - CITP180 Summer 2017
        /// Exercise 6 is an application to convert meters into feet and inches
        /// Author: David Black
        /// Date: 5/30/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int feet,
                inches;

            if (InputMeters(out int meters))
            {
                feet = ConvertMetersToFeet(meters);
                inches = ConvertMetersToRemainingInches(meters);
                DisplayConvertedDistance(feet, inches);
            }
            ReadLine();
        }

        /// <summary>
        /// Prompt user for number of meters.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="m">Distance in Meters</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputMeters(out int m)
        {
            bool returnValue = true;
            m = 0;

            WriteLine("Enter the number of meters to convert.");
            try
            {
                Write("Meters:  ");
                m = int.Parse(ReadLine());
            }
            catch (FormatException f)
            {
                WriteLine("Integer numbers must be used to convert meters to feet and inches.  Invalid input.  Error: " + f.Message);
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// Convert Meters value to Feet
        /// </summary>
        /// <param name="m"></param>
        /// <returns>Meter value</returns>
        private static int ConvertMetersToFeet(int m)
        {
            return Convert.ToInt16((m * INCHES_PER_METER) / 12);
        }

        /// <summary>
        /// Convert Meters value to the remaining inches
        /// </summary>
        /// <param name="m">Meter value</param>
        /// <returns></returns>
        private static int ConvertMetersToRemainingInches(int m)
        {
            return Convert.ToInt16((m * INCHES_PER_METER) % 12);
        }

        /// <summary>
        /// Display the distance in feet and inches in a tabular format, numbers aligned.
        /// </summary>
        /// <param name="f">Distance in feet</param>
        /// <param name="i">Distance in inches remaining</param>
        private static void DisplayConvertedDistance(int f, int i)
        {
            WriteLine($"Your distance in meters is equivalent to:");
            WriteLine($"Feet:\t\t{f,10:f0}");
            WriteLine($"Inches:\t\t{i,10:f0}");
        }
    }
}
