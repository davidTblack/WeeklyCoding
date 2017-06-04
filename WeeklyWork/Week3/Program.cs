using System;
using static System.Console;

namespace Week3
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 3 - CITP180 Summer 2017
        /// Exercise 3 is an application to compute area and perimeter from user input
        /// Author: David Black
        /// Date: 5/30/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double perimeter,
                area;

            if (InputValues(out double length, out double width))
            {
                perimeter = CalculatePerimeter(length, width);
                area = CalculateArea(length, width);
                DisplayRectangleProperties(length, width, area, perimeter);
            }

            ReadLine();

        }

        /// <summary>
        /// Prompt user for inputs of rectangle's length and width.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="l">Length of the rectangle</param>
        /// <param name="w">Width of the rectangle</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputValues(out double l, out double w)
        {
            bool returnValue = true;
            l = 0;
            w = 0;
            WriteLine("Enter values for length and width to calculate properties of a rectangle.");
            try
            {
                Write("Length:  ");
                //Note that convert probably calls parse anyway 
                l = Convert.ToDouble(ReadLine());
                Write("Width:  ");
                w = double.Parse(ReadLine());
            }
            catch(FormatException f)
            {
                WriteLine("Numbers must be used to calculate the properties of the rectangle.  Invalid input.  Error: " + f.Message);
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// Calculate the perimeter of a rectangle given the length and width
        /// </summary>
        /// <param name="l">Length of rectangle</param>
        /// <param name="w">Width of rectangle</param>
        /// <returns></returns>
        private static double CalculatePerimeter(double l, double w)
        {
            return 2 * l + 2 * w;
        }

        /// <summary>
        /// Calculate the area of a rectangle given the length and width
        /// </summary>
        /// <param name="l">Length of rectangle</param>
        /// <param name="w">Width of rectangle</param>
        /// <returns></returns>
        private static double CalculateArea(double l, double w)
        {
            return l * w;
        }

        /// <summary>
        /// Display the properties of the rectangle
        /// </summary>
        /// <param name="l">Length of rectangle</param>
        /// <param name="w">Width of rectangle</param>
        private static void DisplayRectangleProperties(double l, double w, double a, double p)
        {
            WriteLine("Your rectangle is:");
            WriteLine($"Length:\t\t{l,10:f1}");
            WriteLine($"Width:\t\t{w,10:f1}");
            WriteLine($"Area:\t\t{a,10:f1}");
            WriteLine($"Permimeter:\t{p,10:f1}");
        }
    }
}
