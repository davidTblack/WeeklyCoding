using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week5_10
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 5 - CITP180 Summer 2017; this is CHAPTER 6
        /// Exercise 10 is an application to calculate GPA from scores
        /// Author: David Black
        /// Date: 6/19/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool continueFlag = true,
                validInput;
            int tempGrade = 0,
                tempHours = 0,
                countGrades,
                pointTotal,
                hoursTotal;

            do
            {
                countGrades = 0;
                pointTotal = 0;
                hoursTotal = 0;
                WriteLine("Enter Grades and Credit hours to calculate GPA.");
                WriteLine("Grades can be A, B, C, D, E, F.");
                WriteLine("Credit Hours must be positive whole numbers.");
                WriteLine("Enter -1 for Grade to stop entering.");
                do
                {
                    validInput = InputGrade(out tempGrade);
                    if (validInput && tempGrade != -1)
                    {
                        validInput = InputCreditHours(out tempHours);
                    }
                    if (validInput && tempGrade != -1)
                    {
                        countGrades++;
                        pointTotal += (tempGrade * tempHours); 
                        hoursTotal += tempHours;
                    }
                    else
                    {
                        WriteLine("Invalid Input.  Re-enter grade and credit hours.");
                    }
                } while (tempGrade != -1);

                if (countGrades > 0)
                {
                    WriteLine($"Hours earned:\t{hoursTotal,10}");
                    WriteLine($"GPA:\t\t{(pointTotal / (double)(hoursTotal)),10:0.0}");
                }

                WriteLine("Calculate a new GPA? (Y/N)");
                if (ReadLine().ToUpper() != "Y")
                {
                    continueFlag = false;
                }
            } while (continueFlag);
            

        }

        /// <summary>
        /// Input the grade
        /// </summary>
        /// <param name="grade">Letter grade converted to an integer</param>
        /// <returns>True for valid input, false for invalid input</returns>
        private static bool InputGrade(out int grade)
        {
            bool returnValue = true;
            string input;
            grade = 0;

            Write("Grade:  ");
            input = ReadLine().ToUpper();
            switch (input)
            {
                case "A":
                    grade = 4;
                    break;
                case "B":
                    grade = 3;
                    break;
                case "C":
                    grade = 2;
                    break;
                case "D":
                    grade = 1;
                    break;
                case "E":
                case "F":
                    grade = 0;
                    break;
                //Case for ceasing grade entry
                case "-1":
                    grade = -1;
                    break;
                default:
                    returnValue = false;
                    break;
            }
            
            if (!returnValue)
            {
                WriteLine("Invalid input.");
            }

            return returnValue;
        }

        /// <summary>
        /// User input for credit hours of a class
        /// </summary>
        /// <param name="hours">Credit hours for the grade</param>
        /// <returns>True for valid input, false for invalid input</returns>
        private static bool InputCreditHours(out int hours)
        {
            bool returnValue = true;
            hours = 0;

            Write("Hours:  ");
            returnValue = int.TryParse(ReadLine(), out hours);

            if (!returnValue)
            {
                WriteLine("Invalid input.");
            }
            else if (hours < 1)
            {
                WriteLine("0 and negative numbers are not valid Hours.");
                returnValue = false;
            }

            return returnValue;
        }
    }
}
