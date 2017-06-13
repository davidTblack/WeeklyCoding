using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week4_9
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 4 - CITP180 Summer 2017; this is CHAPTER 5
        /// Exercise 9 is an application to display sales profits
        /// Author: David Black
        /// Date: 6/6/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (InputTotalSales(out decimal totalSales)) 
            {
                DisplaySalesAndProfit(totalSales);
            }
            ReadLine();
        }

        /// <summary>
        /// Prompt user for total sales.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="sales">Total Sales</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputTotalSales(out decimal sales)
        {
            bool returnValue = true;
            sales = 0m;

            WriteLine("Enter the total sales.");

            Write("Total Sales:  ");
            returnValue = decimal.TryParse(ReadLine(), out sales);

            if (!returnValue)
                WriteLine("Invalid input.");

            return returnValue;
        }

        /// <summary>
        /// Display the profit gained from the total sales
        /// </summary>
        /// <param name="sales">Total Sales</param>
        public static void DisplaySalesAndProfit(decimal sales)
        {
            if (sales < 0m)
            {
                WriteLine("No profit from a loss in sales.  Someone will be working this weekend...");
            }
            else
            {
                WriteLine("***********************************************");
                WriteLine($"Total Sales:\t\t{sales,20:c2}");
                WriteLine("-----------------------------------------------");
                WriteLine($"Profit Ratio used:\t{DetermineProfitRate(sales),21:p1}");
                WriteLine($"Profit:\t\t\t{CalculateProfit(sales),20:c2}");
                WriteLine("***********************************************");
            }
        }

        /// <summary>
        /// Calculate the Profit based on the total sales
        /// </summary>
        /// <param name="sales">Total Sales</param>
        /// <returns>Profit from sales</returns>
        private static decimal CalculateProfit(decimal sales)
        {
            return sales * DetermineProfitRate(sales);
        }

        /// <summary>
        /// Determine Profit Ratio to use
        /// </summary>
        /// <param name="sales">Total Sales</param>
        /// <returns>Ratio used to calculate profit</returns>
        private static decimal DetermineProfitRate(decimal sales)
        {
            decimal profitRate = 0m;
            if (sales < 1000.01m)
            {
                profitRate = 0.03m;
            }
            else if (sales < 5000.01m)
            {
                profitRate = 0.035m;
            }
            else if (sales <= 10000)
            {
                profitRate = 0.04m;
            }
            else
            {
                profitRate = 0.045m;
            }
            return profitRate;
        }
    }
}
