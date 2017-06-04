using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Week3_7
{
    class Program
    {
        const double TAX_RATE = .09;

        /// <summary>
        /// Programming exercises for week 3 - CITP180 Summer 2017
        /// Exercise 7 is an application to calculate the top from a bill the user enters
        /// -Apply tax to the bill before calculating tip
        /// Author: David Black
        /// Date: 5/30/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Clear();
            WriteLine("**************");
            WriteLine("* Exercise 10 *");
            WriteLine("**************\n");

            double userBill;

            if (InputBill(out userBill))
            {
                WriteLine("***********************************************");
                PrintBill(userBill);
                WriteLine("***********************************************");
            }
            ReadLine();
        }

        /// <summary>
        /// Prompt user for a bill amount.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="b">Amount of bill</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputBill(out double b)
        {
            bool returnValue = true;
            b = 0;

            WriteLine("Enter the bill amount before taxes.");
            try
            {
                Write("Bill Amount:  ");
                b = double.Parse(ReadLine());
                //Enforce two decimal places for a bill
                if (Math.Round(b, 2) != b)
                    throw new FormatException("Bill amount can only include 2 decimal places");
            }
            catch (FormatException f)
            {
                WriteLine("Bill amounts must be numeric and contain only two decimal places.  Invalid input.  Error: " + f.Message);
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// Put together values and display the bill to the user
        /// </summary>
        /// <param name="subTotalBill">The bill subtotal before taxes and tip</param>
        private static void PrintBill(double subTotalBill)
        {
            const double TIP_PERCENTAGE_1 = .15,
                TIP_PERCENTAGE_2 = .20;

            double tipAmount1, tipAmount2;
            double tipBill1, tipBill2;
            double tax, billPlusTax;

            //NOTE: Round derived values to eliminate addition discrepencies
            subTotalBill = Math.Round(subTotalBill, 2);
            
            tax = CalculateTax(subTotalBill);
            billPlusTax = subTotalBill + tax;

            tipAmount1 = CalculateTip(billPlusTax, TIP_PERCENTAGE_1);
            tipBill1 = billPlusTax + tipAmount1;
            tipAmount2 = CalculateTip(billPlusTax, TIP_PERCENTAGE_2);
            tipBill2 = billPlusTax + tipAmount2;

            WriteLine($"Bill Subtotal:{subTotalBill,33:c}");
            WriteLine($"Tax ({TAX_RATE, 4:p0}):{tax,36:c}");
            WriteLine($"Total with Tax:{(subTotalBill + tax),32:c}");
            WriteLine("-----------------------------------------------");
            WriteLine(" Tip           | Tip amount    | Total with tip");
            WriteLine($" {TIP_PERCENTAGE_1,-14:p0}|{tipAmount1,14:c} |{tipBill1,15:c}");
            WriteLine($" {TIP_PERCENTAGE_2,-14:p0}|{tipAmount2,14:c} |{tipBill2,15:c}");
        }

        /// <summary>
        /// Calculate the tax on a bill using a standard tax rate
        /// </summary>
        /// <param name="bill">The bill amount before taxes</param>
        /// <returns></returns>
        private static double CalculateTax(double bill)
        {
            return  Math.Round(bill * TAX_RATE, 2);
        }

        /// <summary>
        /// Calculate the tip based on a bill value
        /// </summary>
        /// <param name="bill">The bill amount</param>
        /// <param name="percentTip">Percentage tip to calculate</param>
        /// <returns></returns>
        private static double CalculateTip(double bill, double percentTip)
        {
            return Math.Round(bill * percentTip, 2);
        }


    }
}
