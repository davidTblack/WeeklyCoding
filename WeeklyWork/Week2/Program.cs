using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Week2.Conversions;

namespace Week2
{
    /// <summary>
    /// Week 2 Exercises - Formatting output
    /// Author: David Black
    /// Date: 5/27/2017
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise7();
            Exercise10();

        }

        /// <summary>
        /// Exercise 1 is to write a program that converts Celcius to Fahrenheight
        /// The numbers should be displayed aligned, and with no decimal on the 
        /// input and one on the output.
        /// Due to lack of visual example, I interpreted number aligning to line up where
        /// the decimal point would be located.
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        private static void Exercise1()
        {
            Clear();

            WriteLine("**************");
            WriteLine("* Exercise 1 *");
            WriteLine("**************\n");

            int celciusValueOne = 32,
                celciusValueTwo = 0,
                celciusValueThree = 98;

            //Temperature
            WriteCelciusToFahrenheit(celciusValueOne);
            WriteCelciusToFahrenheit(celciusValueTwo);
            WriteCelciusToFahrenheit(celciusValueThree);
            ReadLine();
        }

        /// <summary>
        /// Convert miles to feet and kilometers
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        private static void Exercise2()
        {
            Clear();
            WriteLine("**************");
            WriteLine("* Exercise 2 *");
            WriteLine("**************\n");

            float miles1 = 4.5f,
                miles2 = 1f,
                miles3 = 264.9f;


            //Temperature
            WriteMilesConversions(miles1);
            WriteMilesConversions(miles2);
            WriteMilesConversions(miles3);
            ReadLine();
        }

        /// <summary>
        /// Computer average of 5 exam scores
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        private static void Exercise3()
        {
            Clear();
            WriteLine("**************");
            WriteLine("* Exercise 3 *");
            WriteLine("**************\n");

            const int NUMBER_OF_EXAMS = 5;
            int exam1 = 90,
                exam2 = 76, 
                exam3 = 85, 
                exam4 = 99, 
                exam5 = 56;
            double average;

            average = (exam1 + exam2 + exam3 + exam4 + exam5) / (double) NUMBER_OF_EXAMS;
            WriteLine($"Exam 1: {exam1,8:f2}");
            WriteLine($"Exam 2: {exam2,8:f2}");
            WriteLine($"Exam 3: {exam3,8:f2}");
            WriteLine($"Exam 4: {exam4,8:f2}");
            WriteLine($"Exam 5: {exam5,8:f2}");
            WriteLine($"----------------");
            WriteLine($"Average:{average,8:f2}");
            ReadLine();
        }

        /// <summary>
        /// Exercise 7 is a tip calculating application
        /// Total bill along with 15% and 20% tip calculations should display
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        private static void Exercise7()
        {
            Clear();
            WriteLine("**************");
            WriteLine("* Exercise 7 *");
            WriteLine("**************\n");

            float totalBill1 = 24.59f,
                totalBill2 = 109.76f,
                totalBill3 = 100095.55f,
                totalBill4 = 63.20f;

            WriteLine("***********************************************");
            PrintBill(totalBill1);
            WriteLine("***********************************************");
            WriteLine("\n***********************************************");
            PrintBill(totalBill2);
            WriteLine("***********************************************");
            WriteLine("\n***********************************************");
            PrintBill(totalBill3);
            WriteLine("***********************************************");
            WriteLine("\n***********************************************");
            PrintBill(totalBill4);
            WriteLine("***********************************************");
            ReadLine();
        }

        /// <summary>
        /// Exercise 10 
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        private static void Exercise10()
        {
            Clear();
            WriteLine("**************");
            WriteLine("* Exercise 10 *");
            WriteLine("**************\n");

            Product poutine = new Product("Poutine", 1.29f, 100f);
            Product haricotVerts = new Product("Haricot verts", .75f, 100f);

            poutine.PrintInternationalPrices();
            WriteLine("");
            haricotVerts.PrintInternationalPrices();

            ReadLine();
        }


        /// <summary>
        /// This function calls the conversion function and formats output.
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        /// <param name="celcius">Integer value degrees Celcius</param>
        private static void WriteCelciusToFahrenheit(int celcius)
        {
            WriteLine("\n------------------------------\n");
            WriteLine($"Converting Celcius to Fahrenheight:");
            WriteLine($"Celcius:      {celcius, 10}");
            WriteLine($"Fahrenheight: {Temperature.CelciusToFahrenheit(celcius), 12:####.0}");

        }

        private static void WriteMilesConversions(float miles)
        {
            WriteLine("\n------------------------------\n");
            WriteLine($"Converting miles to feet and kilometers");
            WriteLine($"Miles:       {miles,12:f2}");
            WriteLine($"Kilometers:  {Distance.MilesToKilometers(miles),12:f2}");
            WriteLine($"Feet:        {Distance.MilesToFeet(miles),9:#,###}");
        }

        private static void PrintBill(float totalBill)
        {
            const float TIP_PERCENTAGE_1 = .15f,
                TIP_PERCENTAGE_2 = .20f;

            float tipAmount1, tipAmount2;
            float tipBill1, tipBill2;

            tipAmount1 = totalBill * TIP_PERCENTAGE_1;
            tipAmount2 = totalBill * TIP_PERCENTAGE_2;
            tipBill1 = totalBill * (TIP_PERCENTAGE_1 + 1);
            tipBill2 = totalBill * (TIP_PERCENTAGE_2 + 1);


            WriteLine($"Total Bill:{totalBill,36:c}");
            WriteLine("-----------------------------------------------");
            WriteLine(" Tip           | Tip amount    | Total with tip");
            WriteLine($" {TIP_PERCENTAGE_1, -14:p0}|{tipAmount1, 14:c} |{tipBill1, 15:c}");
            WriteLine($" {TIP_PERCENTAGE_2, -14:p0}|{tipAmount2, 14:c} |{tipBill2,15:c}");
        }

        /// <summary>
        /// This is a junk function to test out code
        /// Should be deleted in real code, but keeping for future reference
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        private void testFunction()
        {
            //Console.OutputEncoding = Encoding.Unicode;
            WriteLine("{0:c}", 255);
            WriteLine($"{255:c}");
            ReadLine();

        }
    }
}
