using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week4_3
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 4 - CITP180 Summer 2017; this is CHAPTER 5
        /// Exercise 3 is an application to Calculate and display BMI, based on user input weight and height
        /// Use 2 classes
        /// Use constructors
        /// Handle both imperial and metric object instantiation
        /// Author: David Black
        /// Date: 6/6/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string continueFlag = "";
            //string weightMessage;
            //double bmi;
            do
            {
                if (InputBmiFactors(out Bmi myBmi))
                {
                    DisplayBmiInformation(myBmi);
                }
                WriteLine("\nPress enter to rerun program, or 9 to exit");
                continueFlag = ReadLine();
            } while (continueFlag != "9");
                
        }

        /// <summary>
        /// Prompt user for height and weight.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="theBmi">A new Bmi object</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputBmiFactors(out Bmi theBmi)
        {
            bool returnValue = true;
            double h = 0, w = 0;
            MeasurementSystem sys = MeasurementSystem.Imperial;

            WriteLine("Measurements can be either Imperial (pounds and inches) or Metric (kilograms and meters).");
            WriteLine("Do you wish to enter Imperial or Metric?");
            switch (ReadLine().ToUpper())
            {
                case "IMPERIAL":
                    sys = MeasurementSystem.Imperial;
                    break;
                case "METRIC":
                    sys = MeasurementSystem.Metric;
                    break;
                default:
                    returnValue = false;
                    break;
            }

            //Get height
            if (returnValue)
            {
                Write("Please enter your height:  ");
                returnValue = double.TryParse(ReadLine(), out h);

            }

            //Get width
            if (returnValue)
            {
                Write("Please enter your weight:  ");
                returnValue = double.TryParse(ReadLine(), out w);

            }

            if (!returnValue)
                WriteLine("Invalid input.");

            theBmi = new Bmi();
            theBmi.Height = h;
            theBmi.Weight = w;
            theBmi.MeasureTypePreference = sys;

            return returnValue;
        }

        /// <summary>
        /// Display formatted BMI
        /// </summary>
        /// <param name="theBmi">Populated BMI</param>
        private static void DisplayBmiInformation(Bmi theBmi)
        {
            double bmi = theBmi.CalculateBMI();
            string weightMessage = theBmi.DetermineWeightStatus();
            
            WriteLine("***********************************************");
            WriteLine($"Body Mass Index:\t{bmi,7:####.00}");
            switch (theBmi.MeasureTypePreference)
            {
                case MeasurementSystem.Imperial:
                    WriteLine($"Height\t\t\t{theBmi.Height,7:####.00} Inches");
                    WriteLine($"Weight\t\t\t{theBmi.Weight,7:####.00} Pounds");
                    break;
                case MeasurementSystem.Metric:
                    WriteLine($"Height\t\t\t{theBmi.Height,7:####.00} Centimeters");
                    WriteLine($"Weight\t\t\t{theBmi.Weight,7:####.00} Kilograms");
                    break;
                default:
                    WriteLine("Unknown measurement type.");
                    break;
            }
            WriteLine($"\nYour body mass index classification is: {theBmi.DetermineWeightStatus()}");
            WriteLine("***********************************************");
        }
    }
}
