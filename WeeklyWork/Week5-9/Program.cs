using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week5_9
{
    class Program
    {
        static int defaultWidth = 3;
        static int widthMax = 10;
        static char defaultChar = '*';

        /// <summary>
        /// Programming exercises for week 5 - CITP180 Summer 2017; this is CHAPTER 6
        /// Exercise 9 is an application to print an isosceles triangle of variable size
        /// Author: David Black
        /// Date: 6/19/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool continueFlag = true;
            bool validInput;
            char character;
            int width;
            

            WriteLine("Enter a width and a character to draw an isosceles triangle.");

            do
            {
                validInput = true;
                if (!InputAWidth(out width))
                {
                    width = defaultWidth;
                }
                width = (width > widthMax) ? defaultWidth : width;

                if (!InputACharacter(out character))
                {
                    character = defaultChar;
                }
                //Write lines up to and including full width
                for(int i = 0; i <= width; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Write(character);
                    }
                    Write("\n");
                }
                        
                //Write lines descending not including full width
                for (int i = width - 1; i >= 0; i--)
                {
                    for (int j = i -1; j >= 0; j--)
                    {
                        Write(character);
                    }
                    Write("\n");
                }
                
                if (!validInput)
                {
                    WriteLine("No triangle determined due to invalid input.");
                }
                WriteLine("Do you want to create another triangle? (Y/N)");
                if (ReadLine().ToUpper() != "Y")
                {
                    continueFlag = false;
                }
            } while (continueFlag);
            
        }

        /// <summary>
        /// Method to input a single width value
        /// </summary>
        /// <param name="width">The length returned</param>
        /// <returns>True if valid user input, false if not valid (an integer > 0)</returns>
        private static bool InputAWidth(out int width)
        {
            bool returnValue = true;
            width = 0;

            Write("Width:  ");
            returnValue = int.TryParse(ReadLine(), out width);

            if (!returnValue)
            {
                WriteLine("Invalid input, using default value.");
            }
            else if (width < 1)
            {
                WriteLine("0 and negative numbers are not valid widths.  Using default value.");
                returnValue = false;
            }else if (width > widthMax)
            {
                WriteLine($"Max width of {widthMax} was exceeded.  Using default value.");
                width = defaultWidth;
            }

            return returnValue;
        }

        /// <summary>
        /// Method to input a single length value
        /// </summary>
        /// <param name="width">The length returned</param>
        /// <returns>True if valid user input, false if not valid (an integer > 0)</returns>
        private static bool InputACharacter(out char theChar)
        {
            bool returnValue;
            theChar = ' ';

            Write("Character:  ");
            try
            {
                theChar = ReadKey().KeyChar;
                returnValue = true;
            }
            catch (Exception e)
            {
                WriteLine($"Invalid Input.  {e.Message}.  Using default value.");
                returnValue = false;
            }

            if (!returnValue)
            {
               
            }
            else if ((int)theChar < 1)
            {
                WriteLine("0 and negative numbers are not valid widths.");
                returnValue = false;
            }

            return returnValue;
        }
    }
}
