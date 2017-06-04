using System;
using static System.Console;
namespace Week3_4
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 3 - CITP180 Summer 2017
        /// Exercise 4 is an application to convert a value of seconds into hours, minutes and seconds
        /// Author: David Black
        /// Date: 5/30/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int hours,
                minutes,
                seconds;

            if(InputSeconds(out int inputSeconds))
            {
                hours = CalculateHours(inputSeconds);
                minutes = CalculateMinutes(inputSeconds);
                seconds = CalculateSeconds(inputSeconds);
                DisplayConvertedTime(hours, minutes, seconds);
            }
            ReadLine();
        }

        /// <summary>
        /// Prompt user for number of seconds.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="s">Number of seconds</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputSeconds(out int s)
        {
            bool returnValue = true;
            s = 0;

            WriteLine("Enter the number of seconds to convert.");
            try
            {
                Write("Seconds:  ");
                s = int.Parse(ReadLine());
            }
            catch (FormatException f)
            {
                WriteLine("Integer numbers must be used to convert seconds into hours, minutes, and seconds.  Invalid input.  Error: " + f.Message);
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// Calculate the number of hours
        /// </summary>
        /// <param name="s">Seconds entered by user</param>
        /// <returns>Hours</returns>
        private static int CalculateHours(int s)
        {
            return s / (60 * 60);
        }

        /// <summary>
        /// Calculate the number of miutes remaining (up to 59)
        /// </summary>
        /// <param name="s">Seconds entered by user</param>
        /// <returns>Minutes</returns>
        private static int CalculateMinutes(int s)
        {
            return (s % (60 * 60) / 60);
        }

        /// <summary>
        /// Calculate the number of seconds remaining (up to 59)
        /// </summary>
        /// <param name="s">Seconds entered by user</param>
        /// <returns>Seconds</returns>
        private static int CalculateSeconds(int s)
        {
            return (s % 60);
        }

        /// <summary>
        /// Display the time in a tabular format, numbers aligned.
        /// </summary>
        /// <param name="h">Number of hours</param>
        /// <param name="m">Number of minutes remaining</param>
        /// <param name="s">Number of seconds remaining</param>
        private static void DisplayConvertedTime(int h, int m, int s)
        {
            WriteLine($"Your time can be broken down to:");
            WriteLine($"Hours:\t\t{h,10:f0}");
            WriteLine($"Minutes:\t{m,10:f0}");
            WriteLine($"Seconds:\t{s,10:f0}");
        }
    }
}
